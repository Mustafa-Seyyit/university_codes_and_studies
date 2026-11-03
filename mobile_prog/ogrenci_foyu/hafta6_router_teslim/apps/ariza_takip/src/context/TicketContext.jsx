import { createContext, useContext, useRef, useState } from 'react';
import { Keyboard } from 'react-native';
import { router, usePathname } from 'expo-router';
import { tickets } from '../data/tickets';
import TalepPenceresi from '../components/TalepPenceresi';
import { bosFormOlustur, formuDogrula, sonrakiKayitZamani, talebiHazirla, talebiEkle, talebiSil, talebinDurumunuDegistir } from '../utils/talep';
/** @type {import('react').Context<any>} */
const TicketContext = createContext(null);
export const useTickets = () => useContext(TicketContext);
export function TicketProvider({ children }) {
  const [talepler, setTalepler] = useState(tickets);
  const [form, setForm] = useState(bosFormOlustur);
  const [hatalar, setHatalar] = useState({});
  const [pencere, setPencere] = useState(null);
  const [bildirim, setBildirim] = useState('');
  const [arama, setArama] = useState('');
  const [durumFiltresi, setDurumFiltresi] = useState('Tümü');
  const sonZaman = useRef(0);
  const kilit = useRef(false);
  const path = usePathname();
  const secili = talepler.find(t => t.id === pencere?.id);
  function alanDegistir(alan, deger) {
    setForm(f => ({ ...f, [alan]: deger }));
    setHatalar(h => ({ ...h, [alan]: undefined, ...(alan === 'kategori' ? { digerKategori: undefined } : {}) }));
    kilit.current = false;
  }
  function formuSifirla() { setForm(bosFormOlustur()); setHatalar({}); Keyboard.dismiss(); }
  function filtreleriTemizle() { setArama(''); setDurumFiltresi('Tümü'); }
  function talebiKaydet(taslak) {
    if (kilit.current) return;
    kilit.current = true;
    sonZaman.current = sonrakiKayitZamani(Date.now(), sonZaman.current);
    const yeni = talebiHazirla(taslak, sonZaman.current);
    setTalepler(t => talebiEkle(t, yeni));
    formuSifirla(); filtreleriTemizle(); setPencere(null);
    setBildirim(`Talep kaydedildi. ${yeni.baslik} artık listenizde.`);
    router.replace('/arizalar');
  }
  function kaydetIstegi() {
    Keyboard.dismiss();
    const sonuc = formuDogrula(form); setHatalar(sonuc.hatalar);
    if (sonuc.uyari) { setPencere({ tur: 'hata', ...sonuc.uyari }); return; }
    if (form.acil) { setPencere({ tur: 'acil', form: { ...form } }); return; }
    talebiKaydet(form);
  }
  function silmeIstegi(id) { setPencere({ tur: 'sil', id }); }
  function silmeyiOnayla() {
    if (pencere?.tur !== 'sil' || !secili) return;
    setTalepler(t => talebiSil(t, secili.id)); setPencere(null);
    setBildirim(`“${secili.baslik}” talebi silindi.`);
    if (path.startsWith('/ariza/')) router.replace('/arizalar');
  }
  function durumDegistir(id, durum) {
    setTalepler(t => talebinDurumunuDegistir(t, id, durum));
    setBildirim(`Talep durumu “${durum}” olarak güncellendi.`);
  }
  return <TicketContext.Provider value={{ talepler, form, hatalar, bildirim, setBildirim, arama, setArama, durumFiltresi, setDurumFiltresi,
    alanDegistir, kaydetIstegi, filtreleriTemizle, silmeIstegi, durumDegistir,
    temizle: () => { formuSifirla(); kilit.current = false; setBildirim('Form temizlendi. Kayıtlı talepleriniz korunuyor.'); } }}>
    {children}
    <TalepPenceresi pencere={pencere} talep={secili} bildirim={bildirim} onBildirimiKapat={() => setBildirim('')}
      onKapat={() => setPencere(null)} onSilmeIstegi={silmeIstegi} onSil={silmeyiOnayla}
      onDurumDegistir={durumDegistir} onAcilOnay={() => { if (pencere?.tur === 'acil') talebiKaydet(pencere.form); }} />
  </TicketContext.Provider>;
}
