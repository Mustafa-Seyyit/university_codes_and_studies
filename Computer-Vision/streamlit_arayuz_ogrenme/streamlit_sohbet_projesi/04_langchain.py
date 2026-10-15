import streamlit as st
from langchain_openai import ChatOpenAI
from openai import OpenAIError

# Sayfa ayarları
st.set_page_config(
    page_title="LangChain Uygulaması",
    page_icon="🦜"
)

# Başlık
st.title("🦜 LangChain Yapay Zekâ Uygulaması")

st.write("Sorunuzu yazın ve yapay zekâdan yanıt alın.")

# Sol menüde API anahtarı alanı
openai_api_key = st.sidebar.text_input(
    "OpenAI API Anahtarı",
    type="password"
)

# Modelden cevap üreten fonksiyon
def cevap_uret(soru, api_anahtari):

    model = ChatOpenAI(
        model="gpt-5.4-mini",
        api_key=api_anahtari
    )

    cevap = model.invoke(soru)

    return cevap.content


# Kullanıcıdan soru alma formu
with st.form("soru_formu"):

    soru = st.text_area(
        "Sorunuzu yazın:",
        "Python öğrenmeye nereden başlamalıyım?"
    )

    gonderildi = st.form_submit_button("Gönder")


# Gönder butonuna basıldığında
if gonderildi:

    # API anahtarını kontrol et
    if not openai_api_key.strip():
        st.warning("Lütfen API anahtarınızı girin.")

    # Sorunun boş olup olmadığını kontrol et
    elif not soru.strip():
        st.warning("Lütfen bir soru yazın.")

    else:

        # Modelden yanıt iste
        with st.spinner("Yapay zekâ yanıt hazırlıyor..."):

            try:
                yanit = cevap_uret(
                    soru,
                    openai_api_key
                )

            except OpenAIError as hata:
                st.error(
                    f"API hatası: {type(hata).__name__}. "
                    "Anahtarınızı, model erişiminizi "
                    "ve API bakiyenizi kontrol edin."
                )
                st.stop()

        # Cevabı ekranda göster
        st.info(yanit)