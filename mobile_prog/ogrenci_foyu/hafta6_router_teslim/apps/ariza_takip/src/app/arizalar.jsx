import { router } from 'expo-router';
import { View } from 'react-native';
import TalepListesi from '../components/TalepListesi';
import { Bildirim } from '../components/Ortak';
import { Frame, Button } from '../components/UI';
import { useTickets } from '../context/TicketContext';
import { talepleriFiltrele, talepleriSay } from '../utils/talep';
export default function TicketList() {
 const t = useTickets();
 return <Frame><View style={{ padding: 16, gap: 10 }}><Button title="Yeni Arıza" onPress={() => router.push('/yeni-ariza')} /><Bildirim mesaj={t.bildirim} onKapat={() => t.setBildirim('')} /></View>
 <TalepListesi talepler={talepleriFiltrele(t.talepler, t.arama, t.durumFiltresi)} sayilar={talepleriSay(t.talepler)} arama={t.arama} durumFiltresi={t.durumFiltresi}
 onArama={t.setArama} onFiltre={t.setDurumFiltresi} onFiltreleriTemizle={t.filtreleriTemizle}
 onDetay={id => router.push(`/ariza/${id}`)} onSilmeIstegi={t.silmeIstegi} onYeniTalep={() => router.push('/yeni-ariza')} /></Frame>;
}
