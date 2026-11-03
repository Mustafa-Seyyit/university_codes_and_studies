import { Text, View } from 'react-native';
import { router } from 'expo-router';
import { useTickets } from '../context/TicketContext';
import { Page, Heading, Button, s } from '../components/UI';
import StatusBadge from '../components/StatusBadge';
export default function Home() {
 const { talepler } = useTickets();
 return <Page><Heading eyebrow="KAMPÜS / TEKNİK DESTEK" title="Her sorun, bir çözüme." description="Arıza bildirimlerinizi oluşturun, ilerlemeyi tek bir yerden takip edin." />
 <View style={s.card}><Text style={s.price}>{talepler.length} kayıtlı arıza</Text><Text style={s.body}>Güncel durum özeti</Text>{['Bekliyor', 'İşlemde', 'Çözüldü'].map(d => <View key={d} style={s.row}><StatusBadge durum={d} /><Text style={s.cardTitle}>{talepler.filter(t => t.durum === d).length}</Text></View>)}</View>
 <Button title="Arıza Listesi" onPress={() => router.push('/arizalar')} /><Button title="Yeni Arıza" secondary onPress={() => router.push('/yeni-ariza')} />
 <Text style={s.body}>Örnek kayıtlar ile başlayın. Eklenen kayıtlar uygulama açıkken korunur.</Text>
 <Button title="Önceki haftanın ekranları" secondary onPress={() => router.push('/onceki-ekran')} /></Page>;
}
