import streamlit as st

# Tarayıcı sekmesinin başlığı
st.set_page_config(
    page_title="Google Giriş Sistemi",
    page_icon="🔐"
)

# Giriş ekranını oluşturan fonksiyon
def login_screen():
    st.header("Bu uygulama özeldir.")
    st.subheader("Lütfen Google hesabınızla giriş yapın.")

    st.button(
        "Google ile giriş yap",
        on_click=st.login
    )


# Kullanıcının giriş durumunu kontrol et
if not st.user.is_logged_in:

    # Kullanıcı giriş yapmamışsa
    login_screen()

else:

    # Kullanıcı giriş yapmışsa
    st.header(f"Hoş geldin, {st.user.name}!")

    st.success("Giriş başarılı!")

    # Çıkış butonu
    st.button(
        "Çıkış yap",
        on_click=st.logout
    )