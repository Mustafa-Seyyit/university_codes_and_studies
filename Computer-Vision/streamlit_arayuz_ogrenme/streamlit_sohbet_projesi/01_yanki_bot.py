import streamlit as st

# Sayfanın başlığı
st.title("💬 Yankı Botu")

# Kullanıcıya kısa açıklama
st.write("Merhaba! Yazdıklarını tekrar eden bir botum.")

# Sohbet geçmişini oluştur
if "messages" not in st.session_state:
    st.session_state.messages = []

# Önceki mesajları ekranda göster
for message in st.session_state.messages:
    with st.chat_message(message["role"]):
        st.write(message["content"])

# Kullanıcıdan yeni mesaj al
prompt = st.chat_input("Bir mesaj yaz...")

if prompt:

    # Kullanıcı mesajını göster
    with st.chat_message("user"):
        st.write(prompt)

    # Kullanıcı mesajını geçmişe kaydet
    st.session_state.messages.append({
        "role": "user",
        "content": prompt
    })

    # Botun yanıtını oluştur
    response = f"sen bana '{prompt}' yazdın."

    # Botun yanıtını göster
    with st.chat_message("assistant"):
        st.write(response)

    # Botun yanıtını geçmişe kaydet
    st.session_state.messages.append({
        "role": "assistant",
        "content": response
    })