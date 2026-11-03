import { KeyboardAvoidingView, Platform } from 'react-native';
import TalepFormu from '../components/TalepFormu';
import { Bildirim } from '../components/Ortak';
import { Frame } from '../components/UI';
import { useTickets } from '../context/TicketContext';
export default function NewTicket() {
 const t = useTickets();
 return <Frame><Bildirim mesaj={t.bildirim} onKapat={() => t.setBildirim('')} /><KeyboardAvoidingView style={{ flex: 1 }} behavior={Platform.OS === 'ios' ? 'padding' : undefined}>
 <TalepFormu form={t.form} hatalar={t.hatalar} onAlanDegistir={t.alanDegistir} onKaydet={t.kaydetIstegi} onTemizle={t.temizle} /></KeyboardAvoidingView></Frame>;
}
