/* AI Career Guide - script.js */

document.addEventListener("DOMContentLoaded", function () {
  kariyerTestiniHazirla();
  iletisimFormunuHazirla();
});

/* KARIYER TESTI */

function kariyerTestiniHazirla() {
  const testForm = document.querySelector(".test-form");

  if (!testForm) {
    return;
  }

  const sonucKutusu = document.createElement("div");
  sonucKutusu.className = "sonuc-kutusu";
  sonucKutusu.innerHTML = `
    <h3>Değerlendirme Sonucu</h3>
    <p>Formu doldurduktan sonra sana yakın olabilecek yapay zeka alanı burada görünecek.</p>
  `;

  testForm.parentElement.appendChild(sonucKutusu);

  testForm.addEventListener("submit", function (event) {
    event.preventDefault();

    const coding = document.getElementById("coding").value;
    const data = document.getElementById("data").value;
    const contentType = document.getElementById("content-type").value;
    const interests = document.querySelectorAll(
      'input[name="interest"]:checked',
    );

    if (coding === "" || data === "" || contentType === "") {
      sonucKutusu.innerHTML = `
        <h3>Eksik Bilgi</h3>
        <p>Lütfen zorunlu seçim alanlarını doldur.</p>
      `;
      return;
    }

    let sonucBaslik = "";
    let sonucMetin = "";

    if (contentType.includes("Tablolar") || secildiMi(interests, "analysis")) {
      sonucBaslik = "Sana yakın alan: Data Scientist";
      sonucMetin =
        "Veri analizi, tablo yorumlama ve raporlama ilgini çekiyorsa Data Scientist alanı senin için iyi bir başlangıç olabilir.";
    } else if (
      contentType.includes("Metin") ||
      secildiMi(interests, "language")
    ) {
      sonucBaslik = "Sana yakın alan: NLP Engineer";
      sonucMetin =
        "Metin, konuşma, chatbot ve dil teknolojileri ilgini çekiyorsa NLP Engineer alanını inceleyebilirsin.";
    } else if (
      contentType.includes("Görüntü") ||
      secildiMi(interests, "visual")
    ) {
      sonucBaslik = "Sana yakın alan: Computer Vision Engineer";
      sonucMetin =
        "Görüntü ve video verileriyle çalışmak istiyorsan Computer Vision alanı sana uygun olabilir.";
    } else if (
      contentType.includes("Büyük dil") ||
      secildiMi(interests, "model")
    ) {
      sonucBaslik = "Sana yakın alan: Machine Learning Engineer";
      sonucMetin =
        "Model geliştirme, deneme yapma ve tahmin sistemleri ilgini çekiyorsa Machine Learning Engineer alanını değerlendirebilirsin.";
    } else if (
      contentType.includes("Sistem") ||
      secildiMi(interests, "deployment")
    ) {
      sonucBaslik = "Sana yakın alan: MLOps Engineer";
      sonucMetin =
        "Modelleri yayına alma, sistem kurma ve sürdürülebilir hale getirme ilgini çekiyorsa MLOps alanı sana yakın olabilir.";
    } else {
      sonucBaslik = "Sana yakın alan: AI Product Specialist";
      sonucMetin =
        "Analiz, planlama ve kullanıcı ihtiyacı tarafı ilgini çekiyorsa AI Product Specialist alanını inceleyebilirsin.";
    }

    sonucKutusu.innerHTML = `
      <h3>${sonucBaslik}</h3>
      <p>${sonucMetin}</p>
    `;
  });

  testForm.addEventListener("reset", function () {
    sonucKutusu.innerHTML = `
      <h3>Değerlendirme Sonucu</h3>
      <p>Formu doldurduktan sonra sana yakın olabilecek yapay zeka alanı burada görünecek.</p>
    `;
  });
}

function secildiMi(secimler, deger) {
  for (let i = 0; i < secimler.length; i++) {
    if (secimler[i].value === deger) {
      return true;
    }
  }

  return false;
}

/* ILETISIM FORMU */

function iletisimFormunuHazirla() {
  const iletisimForm = document.querySelector(".iletisim-form");

  if (!iletisimForm) {
    return;
  }

  const bilgiKutusu = document.createElement("div");
  bilgiKutusu.className = "sonuc-kutusu";
  bilgiKutusu.innerHTML = `
    <h3>Form Durumu</h3>
    <p>Form gönderildiğinde bilgilendirme mesajı burada görünecek.</p>
  `;

  iletisimForm.parentElement.appendChild(bilgiKutusu);

  iletisimForm.addEventListener("submit", function (event) {
    event.preventDefault();

    const fullname = document.getElementById("fullname").value.trim();
    const email = document.getElementById("email").value.trim();
    const topic = document.getElementById("topic").value;
    const message = document.getElementById("message").value.trim();
    const permission = document.getElementById("permission").checked;

    if (
      fullname === "" ||
      email === "" ||
      topic === "" ||
      message === "" ||
      permission === false
    ) {
      bilgiKutusu.innerHTML = `
        <h3>Eksik Bilgi</h3>
        <p>Lütfen tüm alanları doldur ve onay kutusunu işaretle.</p>
      `;
      return;
    }

    bilgiKutusu.innerHTML = `
      <h3>Mesaj Alındı</h3>
      <p>${fullname}, "${topic}" konulu mesajın proje formu tarafından başarıyla alındı.</p>
    `;

    iletisimForm.reset();
  });

  iletisimForm.addEventListener("reset", function () {
    bilgiKutusu.innerHTML = `
      <h3>Form Durumu</h3>
      <p>Form gönderildiğinde bilgilendirme mesajı burada görünecek.</p>
    `;
  });
}
