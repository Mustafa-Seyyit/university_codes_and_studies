import streamlit as st
import lorem
from random import randint
import time

# SAYFA AYARLARI
st.set_page_config(
    page_title="Cevap Düzenleme Botu",
    page_icon="📝"
)

st.title("📝 Cevap Düzenleme Botu")
st.write("Bot cevaplarını kontrol edin ve düzenleyin.")


# 1. AKIŞLI CEVAP ÜRETME
def chat_stream():

    for i in range(randint(3, 9)):
        yield lorem.sentence() + " "
        time.sleep(0.2)


# 2. CÜMLELERİ KONTROL ETME
def validate(response):

    sentences = [
        sentence.strip(". ") + "."
        for sentence in response.split(". ")
        if sentence.strip(". ") != ""
    ]

    valid = [
        sentence.count(" ") > 4
        for sentence in sentences
    ]

    return sentences, valid


# 3. ŞÜPHELİ CÜMLELERİ RENKLENDİRME
def highlight(sentences, valid, focus=None):

    result = []

    for i, (sentence, is_valid) in enumerate(
        zip(sentences, valid)
    ):

        if is_valid:
            result.append(sentence)

        elif focus is None or i == focus:
            result.append(
                f":red[:red-background[{sentence}]]"
            )

        else:
            result.append(
                f":gray[:gray-background[{sentence}]]"
            )

    return " ".join(result)


# 4. CEVABI ONAYLAMA FONKSİYONU
def finish_response(response):

    st.session_state.history.append({
        "role": "assistant",
        "content": response
    })

    st.session_state.pending = None
    st.session_state.validation = {}
    st.session_state.stage = "user"

    st.rerun()


# 5. SESSION STATE OLUŞTURMA
if "stage" not in st.session_state:

    st.session_state.stage = "user"
    st.session_state.history = []
    st.session_state.pending = None
    st.session_state.validation = {}


# 6. ÖNCEKİ MESAJLARI GÖSTERME
for message in st.session_state.history:

    with st.chat_message(message["role"]):
        st.write(message["content"])


# 7. KULLANICI MESAJI AŞAMASI
if st.session_state.stage == "user":

    prompt = st.chat_input("Bir mesaj yaz...")

    if prompt:

        st.session_state.history.append({
            "role": "user",
            "content": prompt
        })

        with st.chat_message("user"):
            st.write(prompt)

        with st.chat_message("assistant"):
            response = st.write_stream(chat_stream())
            st.session_state.pending = response

        st.session_state.stage = "validate"
        st.rerun()


# 8. CEVAP KONTROL AŞAMASI
elif st.session_state.stage == "validate":

    st.chat_input(
        "Önce cevabı inceleyin.",
        disabled=True
    )

    sentences, valid = validate(
        st.session_state.pending
    )

    with st.chat_message("assistant"):
        st.markdown(highlight(sentences, valid))

    st.divider()

    col1, col2, col3 = st.columns(3)

    # Hataları düzelt
    if col1.button(
        "Hataları düzelt",
        disabled=all(valid)
    ):

        st.session_state.validation = {
            "sentences": sentences,
            "valid": valid
        }

        st.session_state.stage = "correct"
        st.rerun()

    # Cevabı kabul et
    if col2.button("Kabul et"):

        finish_response(
            st.session_state.pending
        )

    # Cevabı yeniden yaz
    if col3.button("Yeniden yaz"):

        st.session_state.stage = "rewrite"
        st.rerun()


# 9. CÜMLE DÜZELTME AŞAMASI
elif st.session_state.stage == "correct":

    st.chat_input(
        "Önce düzeltmeyi tamamlayın.",
        disabled=True
    )

    sentences = st.session_state.validation["sentences"]
    valid = st.session_state.validation["valid"]

    # İlk şüpheli cümleyi bul
    focus = next(
        (i for i, value in enumerate(valid) if not value),
        None
    )

    with st.chat_message("assistant"):
        st.markdown(
            highlight(sentences, valid, focus)
        )

    # Düzeltilmesi gereken cümle varsa
    if focus is not None:

        new_sentence = st.text_input(
            "Cümleyi düzelt:",
            value=sentences[focus]
        )

        col1, col2 = st.columns(2)

        # Cümleyi güncelle
        if col1.button(
            "Güncelle",
            disabled=not new_sentence.strip(". ")
        ):

            sentences[focus] = (
                new_sentence.strip(". ") + "."
            )

            valid[focus] = True

            st.session_state.pending = " ".join(
                sentences
            )

            st.rerun()

        # Cümleyi sil
        if col2.button("Cümleyi sil"):

            sentences.pop(focus)
            valid.pop(focus)

            st.session_state.pending = " ".join(
                sentences
            )

            st.rerun()

    # Bütün cümleler incelendiyse
    else:

        if not sentences:

            st.warning(
                "Tüm cümleleri sildiniz. "
                "Yeni bir cevap yazmalısınız."
            )

            if st.button("Yeniden yaz"):
                st.session_state.stage = "rewrite"
                st.rerun()

        else:

            col1, col2 = st.columns(2)

            if col1.button("Cevabı kabul et"):

                finish_response(
                    st.session_state.pending
                )

            if col2.button("Yeniden kontrol et"):

                st.session_state.stage = "validate"
                st.rerun()


# 10. CEVABI YENİDEN YAZMA AŞAMASI
elif st.session_state.stage == "rewrite":

    st.chat_input(
        "Önce cevabı düzenleyin.",
        disabled=True
    )

    with st.chat_message("assistant"):

        new_response = st.text_area(
            "Cevabı yeniden yaz:",
            value=st.session_state.pending,
            height=200
        )

    if st.button(
        "Kaydet",
        disabled=not new_response.strip()
    ):

        if new_response.strip():

            finish_response(new_response)