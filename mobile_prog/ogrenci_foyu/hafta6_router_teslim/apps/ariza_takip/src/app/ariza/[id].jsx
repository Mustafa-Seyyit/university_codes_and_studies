import { View, Text } from 'react-native';
import { useLocalSearchParams } from 'expo-router';
import { useTickets } from '../../context/TicketContext';
import { Page, Heading, Back, Missing, Field, Button, s } from '../../components/UI';
import StatusBadge from '../../components/StatusBadge';
import { Bildirim } from '../../components/Ortak';
import { durumlar } from '../../utils/talep';
export default function TicketDetail() {
 const { id } = useLocalSearchParams(); const t = useTickets(); const item = t.talepler.find(x => x.id === id);
 if (!item) return <Missing type="Arıza" id={id} href="/arizalar" />;
 return <Page><Heading eyebrow={`ARIZA / ${item.id}`} title={item.baslik} /><StatusBadge durum={item.durum} />
 <View style={s.card}><Field label="Konum / Birim" value={item.birim} /><Field label="Açıklama" value={item.aciklama} /><Field label="Talep sahibi" value={item.adSoyad} /><Field label="Kategori" value={item.kategori === 'Diğer' ? item.digerKategori : item.kategori} /><Field label="Öncelik" value={item.oncelik} /><Field label="Acil müdahale" value={item.acil ? 'Evet' : 'Hayır'} /><Field label="Oluşturulma" value={item.tarih} /></View>
 <Text style={s.cardTitle}>Durumu güncelle</Text>{durumlar.map(d => <Button key={d} title={`Durum: ${d}`} secondary={d !== item.durum} onPress={() => t.durumDegistir(item.id, d)} />)}
 <Bildirim mesaj={t.bildirim} onKapat={() => t.setBildirim('')} /><Button title="Talebi sil" secondary onPress={() => t.silmeIstegi(item.id)} /><Back href="/arizalar" /></Page>;
}
