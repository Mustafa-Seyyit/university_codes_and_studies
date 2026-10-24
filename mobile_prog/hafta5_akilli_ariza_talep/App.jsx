import { useRef, useState } from 'react';
import { Keyboard, KeyboardAvoidingView, Platform, Pressable, StyleSheet, Text, View } from 'react-native';
import { SafeAreaProvider, SafeAreaView } from 'react-native-safe-area-context';
import { StatusBar } from 'expo-status-bar';
import Ionicons from '@expo/vector-icons/Ionicons';
import TalepFormu from './src/components/TalepFormu';
import TalepListesi from './src/components/TalepListesi';
import TalepPenceresi from './src/components/TalepPenceresi';
import { Bildirim, renkler, ui } from './src/components/Ortak';
import {
  bosFormOlustur, formuDogrula, sonrakiKayitZamani, talebiEkle, talebiHazirla,
  talebiSil, talebinDurumunuDegistir, talepleriFiltrele, talepleriSay,
} from './src/utils/talep';

function AkilliArizaTalep() {
  const [form, setForm] = useState(bosFormOlustur);
  const [talepler, setTalepler] = useState([]);
  const [gorunum, setGorunum] = useState('form');
  const [hatalar, setHatalar] = useState({});
  const [pencere, setPencere] = useState(null);
  const [bildirim, setBildirim] = useState('');
  const [arama, setArama] = useState('');
  const [durumFiltresi, setDurumFiltresi] = useState('Tümü');
  const sonKayitZamani = useRef(0);
  const kayitKilidi = useRef(false);

  // Ayrıntılar kopyalanmaz; seçilen id her render'da güncel listeden bulunur.
  const seciliTalep = talepler.find((talep) => talep.id === pencere?.id);
  const gorunenTalepler = talepleriFiltrele(talepler, arama, durumFiltresi);
  const sayilar = talepleriSay(talepler);

  function alanDegistir(alan, deger) {
    setForm((onceki) => ({ ...onceki, [alan]: deger }));
    setHatalar((onceki) => ({
      ...onceki, [alan]: undefined,
      ...(alan === 'kategori' ? { digerKategori: undefined } : {}),
    }));
    kayitKilidi.current = false;
  }

  function formuSifirla() {
    setForm(bosFormOlustur());
    setHatalar({});
    Keyboard.dismiss();
  }

  function filtreleriTemizle() {
    setArama('');
    setDurumFiltresi('Tümü');
  }

  function gorunumDegistir(yeniGorunum) {
    Keyboard.dismiss();
    setBildirim('');
    setGorunum(yeniGorunum);
  }

  function talebiKaydet(dogrulanmisForm) {
    // Hızlı çift dokunma veya çift onay aynı taslağı iki defa eklemez.
    if (kayitKilidi.current) return;
    kayitKilidi.current = true;
    const zaman = sonrakiKayitZamani(Date.now(), sonKayitZamani.current);
    sonKayitZamani.current = zaman;
    const yeniTalep = talebiHazirla(dogrulanmisForm, zaman);
    setTalepler((onceki) => talebiEkle(onceki, yeniTalep));
    formuSifirla();
    filtreleriTemizle();
    setPencere(null);
    setGorunum('liste');
    setBildirim(`Talep kaydedildi. ${yeniTalep.baslik} artık listenizde.`);
  }

  function kaydetIstegi() {
    Keyboard.dismiss();
    const sonuc = formuDogrula(form);
    setHatalar(sonuc.hatalar);
    if (sonuc.uyari) {
      setPencere({ tur: 'hata', ...sonuc.uyari });
      return;
    }
    if (form.acil) {
      setPencere({ tur: 'acil', form: { ...form } });
      return;
    }
    talebiKaydet(form);
  }

  function detayAc(id) {
    Keyboard.dismiss();
    setBildirim('');
    setPencere({ tur: 'detay', id });
  }

  function silmeIstegi(id, detaydan = false) {
    Keyboard.dismiss();
    setBildirim('');
    // Burada kayıt silinmez; yalnızca onay penceresi açılır.
    setPencere({ tur: 'sil', id, detaydan });
  }

  function pencereyiKapat() {
    // Detaydan açılmış silme onayında vazgeçmek ayrıntılara geri döndürür.
    setPencere((onceki) => onceki?.tur === 'sil' && onceki.detaydan
      ? { tur: 'detay', id: onceki.id }
      : null);
  }

  function silmeyiOnayla() {
    if (pencere?.tur !== 'sil' || !seciliTalep) return;
    const silinenBaslik = seciliTalep.baslik;
    setTalepler((onceki) => talebiSil(onceki, pencere.id));
    setPencere(null);
    setBildirim(`“${silinenBaslik}” talebi silindi.`);
  }

  function durumDegistir(id, yeniDurum) {
    const talep = talepler.find((item) => item.id === id);
    if (!talep || talep.durum === yeniDurum) return;
    setTalepler((onceki) => talebinDurumunuDegistir(onceki, id, yeniDurum));
    setBildirim(`Talep durumu “${yeniDurum}” olarak güncellendi.`);
  }

  return (
    <SafeAreaView style={styles.ekran}>
      <StatusBar style="dark" />
      <View style={styles.sayfa}>
        <View style={styles.ustAlan}>
          <View style={styles.marka}>
            <View style={styles.logo}><Ionicons name="headset-outline" size={23} color="#FFFFFF" /></View>
            <View style={ui.flex}>
              <Text style={styles.markaUst}>BİLGİ İŞLEM · TEKNİK DESTEK</Text>
              <Text style={styles.markaBaslik}>Akıllı Arıza Talep Yönetimi</Text>
            </View>
          </View>
          <View accessibilityRole="radiogroup" accessibilityLabel="Çalışma alanı" style={styles.gorunumler}>
            {[
              { id: 'form', metin: 'Yeni talep', simge: 'add-circle-outline' },
              { id: 'liste', metin: `Taleplerim (${talepler.length})`, simge: 'file-tray-full-outline' },
            ].map((item) => (
              <Pressable key={item.id} accessibilityRole="radio" accessibilityLabel={item.id === 'form' ? 'Yeni talep görünümü' : 'Taleplerim görünümü'}
                aria-checked={gorunum === item.id} onPress={() => gorunumDegistir(item.id)}
                style={({ pressed }) => [styles.gorunum, gorunum === item.id && styles.seciliGorunum, pressed && ui.basili]}>
                <Ionicons name={item.simge} size={18} color={gorunum === item.id ? renkler.mavi : renkler.ikincil} />
                <Text style={[styles.gorunumMetin, gorunum === item.id && styles.seciliGorunumMetin]}>{item.metin}</Text>
              </Pressable>
            ))}
          </View>
          {!!bildirim && !pencere && <Bildirim mesaj={bildirim} onKapat={() => setBildirim('')} />}
        </View>

        <KeyboardAvoidingView style={ui.flex} behavior={Platform.OS === 'ios' ? 'padding' : undefined}>
          {gorunum === 'form' ? (
            <TalepFormu form={form} hatalar={hatalar} onAlanDegistir={alanDegistir} onKaydet={kaydetIstegi}
              onTemizle={() => {
                formuSifirla();
                kayitKilidi.current = false;
                setBildirim('Form temizlendi. Kayıtlı talepleriniz korunuyor.');
              }} />
          ) : (
            <TalepListesi talepler={gorunenTalepler} sayilar={sayilar} arama={arama} durumFiltresi={durumFiltresi}
              onArama={setArama} onFiltre={setDurumFiltresi} onFiltreleriTemizle={filtreleriTemizle}
              onDetay={detayAc} onSilmeIstegi={silmeIstegi} onYeniTalep={() => gorunumDegistir('form')} />
          )}
        </KeyboardAvoidingView>
      </View>
      <TalepPenceresi pencere={pencere} talep={seciliTalep} bildirim={bildirim}
        onBildirimiKapat={() => setBildirim('')} onKapat={pencereyiKapat} onSilmeIstegi={silmeIstegi}
        onSil={silmeyiOnayla} onDurumDegistir={durumDegistir}
        onAcilOnay={() => { if (pencere?.tur === 'acil') talebiKaydet(pencere.form); }} />
    </SafeAreaView>
  );
}

export default function App() {
  return <SafeAreaProvider><AkilliArizaTalep /></SafeAreaProvider>;
}

const styles = StyleSheet.create({
  ekran: { flex: 1, backgroundColor: renkler.zemin },
  sayfa: { flex: 1, width: '100%', maxWidth: 760, alignSelf: 'center' },
  ustAlan: { paddingHorizontal: 20, paddingTop: 16, paddingBottom: 14, gap: 15, borderBottomWidth: 1, borderBottomColor: renkler.cizgi },
  marka: { flexDirection: 'row', alignItems: 'center', gap: 11 },
  logo: { width: 43, height: 43, alignItems: 'center', justifyContent: 'center', borderRadius: 13, backgroundColor: renkler.lacivert },
  markaUst: { color: renkler.ikincil, fontSize: 9, fontWeight: '700', letterSpacing: 0.9 },
  markaBaslik: { color: renkler.metin, fontSize: 16, lineHeight: 22, fontWeight: '700', marginTop: 4 },
  gorunumler: { flexDirection: 'row', gap: 5, padding: 4, borderRadius: 13, backgroundColor: '#E7EDF6' },
  gorunum: { flex: 1, minHeight: 44, flexDirection: 'row', justifyContent: 'center', alignItems: 'center', gap: 7, paddingHorizontal: 8, paddingVertical: 11, borderRadius: 9 },
  seciliGorunum: { backgroundColor: '#FFFFFF' },
  gorunumMetin: { fontSize: 13, fontWeight: '600', color: renkler.ikincil, flexShrink: 1 },
  seciliGorunumMetin: { color: renkler.mavi },
});
