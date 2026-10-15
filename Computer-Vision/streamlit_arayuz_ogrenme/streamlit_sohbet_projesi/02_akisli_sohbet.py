import streamlit as st
import random
import time

# Sayfa başlığı
st.title("💬 Akışlı Sohbet Botu")


# Botun cevaplarını üreten fonksiyon
def response_generator():

    # Rastgele bir cevap seç
    response = random.choice([
        "Merhaba! Sana nasıl yardımcı olabilirim?",
        "Selam! Bugün nasıl gidiyor?",
        "Merhaba! Bir sorun mu var?",
        "hey!! yardıma hazırım varmı bir isteğin?"
    ])

    # Cevabı kelime kelime üret
    for word in response.split():
        yield word + " "
        time.sleep(0.1)


# Sohbet geçmişini oluştur
if "messages" not in st.session_state:
    st.session_state.messages = []


# Önceki mesajları göster
for message in st.session_state.messages:
    with st.chat_message(message["role"]):
        st.markdown(message["content"])


# Kullanıcıdan mesaj al
prompt = st.chat_input("Bir mesaj yaz...")


if prompt:

    # Kullanıcının mesajını göster
    with st.chat_message("user"):
        st.markdown(prompt)

    # Mesajı geçmişe ekle
    st.session_state.messages.append({
        "role": "user",
        "content": prompt
    })

    # Botun cevabını akış halinde göster
    with st.chat_message("assistant"):
        response = st.write_stream(
            response_generator()
        )

    # Botun cevabını geçmişe ekle
    st.session_state.messages.append({
        "role": "assistant",
        "content": response
    })