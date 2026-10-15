import streamlit as st
import time

# Sayfa ayarları
st.set_page_config(
    page_title="Cevap Değerlendirme Botu",
    page_icon="👍"
)

st.title("💬 Cevap Değerlendirme Botu")

st.write("Mesaj gönderin ve botun cevabını değerlendirin.")


# Botun akışlı cevap fonksiyonu
def chat_stream(prompt):

    response = f'Sen şunu söyledin: "{prompt}" ... İlginç!'

    for char in response:
        yield char
        time.sleep(0.02)


# Değerlendirmeyi kaydetme fonksiyonu
def save_feedback(index):

    st.session_state.history[index]["feedback"] = (
        st.session_state[f"feedback_{index}"]
    )


# Sohbet geçmişini oluştur
if "history" not in st.session_state:
    st.session_state.history = []


# Önceki mesajları göster
for i, message in enumerate(st.session_state.history):

    with st.chat_message(message["role"]):

        st.write(message["content"])

        # Yalnızca bot mesajlarına değerlendirme ekle
        if message["role"] == "assistant":

            feedback = message.get("feedback", None)

            # Kaydedilmiş değerlendirmeyi yükle
            st.session_state[f"feedback_{i}"] = feedback

            st.feedback(
                "stars",
                key=f"feedback_{i}",
                disabled=feedback is not None,
                on_change=save_feedback,
                args=[i]
            )


# Kullanıcıdan mesaj al
prompt = st.chat_input("Bir mesaj yaz...")


if prompt:

    # Kullanıcı mesajını göster
    with st.chat_message("user"):
        st.write(prompt)

    # Mesajı geçmişe kaydet
    st.session_state.history.append({
        "role": "user",
        "content": prompt
    })

    # Botun cevabını göster
    with st.chat_message("assistant"):

        response = st.write_stream(
            chat_stream(prompt)
        )

        # Yeni bot mesajının sıra numarası
        index = len(st.session_state.history)

        # Cevabı değerlendirme butonları
        st.feedback(
            "stars",
            key=f"feedback_{index}",
            on_change=save_feedback,
            args=[index]
        )

    # Bot cevabını geçmişe kaydet
    st.session_state.history.append({
        "role": "assistant",
        "content": response,
        "feedback": None
    })