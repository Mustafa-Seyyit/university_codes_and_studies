import streamlit as st
from openai import OpenAI, OpenAIError

# Sayfa ayarları
st.set_page_config(
    page_title="Yapay Zekâ Sohbet",
    page_icon="🤖"
)

st.title("🤖 Yapay Zekâ Sohbet Uygulamam")

if st.button("🗑️ Sohbeti temizle"):
    st.session_state.messages = []
    st.rerun()

# OpenAI API bağlantısı
client = OpenAI(
    api_key=st.secrets["OPENAI_API_KEY"]
)

# Kullanılacak yapay zekâ modeli
if "openai_model" not in st.session_state:
    st.session_state["openai_model"] = "gpt-5.4-mini"

# Sohbet geçmişini oluştur
if "messages" not in st.session_state:
    st.session_state.messages = []

# Önceki mesajları ekranda göster
for message in st.session_state.messages:
    with st.chat_message(message["role"]):
        st.markdown(message["content"])

# Kullanıcıdan mesaj al
prompt = st.chat_input("Bir mesaj yaz...")

if prompt:

    # Kullanıcının mesajını kaydet
    st.session_state.messages.append({
        "role": "user",
        "content": prompt
    })

    # Kullanıcının mesajını göster
    with st.chat_message("user"):
        st.markdown(prompt)

    # Yapay zekâdan cevap al
    with st.chat_message("assistant"):

        try:
            stream = client.chat.completions.create(
                model=st.session_state["openai_model"],
                messages=st.session_state.messages,
                stream=True
            )

            # Gelen cevabı akış halinde göster
            response = st.write_stream(stream)

        except OpenAIError:
            st.error(
                "API isteği başarısız oldu. "
                "Anahtarını, bakiyeni ve bağlantını kontrol et."
            )
            st.stop()

    # Yapay zekâ cevabını geçmişe kaydet
    st.session_state.messages.append({
        "role": "assistant",
        "content": response
    })