import { Pressable, StyleSheet, Text, View } from 'react-native';
import Ionicons from '@expo/vector-icons/Ionicons';
import { kategoriler, oncelikRenkleri } from '../utils/talep';
import { renkler, ui } from './Ortak';
import StatusBadge from './StatusBadge';
export default function TicketCard({ talep, onDetay, onSilmeIstegi }) {
  const simge = kategoriler.find((item) => item.ad === talep.kategori)?.ikon || 'construct-outline';
  return (
    <View style={styles.talepKarti} testID={`talep-${talep.id}`}>
      <Pressable
        accessibilityRole="button"
        accessibilityLabel={`${talep.baslik} ayrıntılarını aç`}
        accessibilityHint={`${talep.kategori}, ${talep.durum}. Silme onayı için uzun basın.`}
        onPress={() => onDetay(talep.id)}
        onLongPress={() => onSilmeIstegi(talep.id)}
        delayLongPress={600}
        style={({ pressed }) => [styles.kartGovde, pressed && ui.basili]}
      >
        <View style={styles.kartUst}>
          <View style={styles.kategoriSimge}><Ionicons name={simge} size={21} color={renkler.mavi} /></View>
          <Text style={styles.numara}>{talep.id}</Text>
          {talep.acil && <Ionicons name="flash" size={17} color="#B45309" accessibilityLabel="Acil talep" />}
        </View>
        <Text style={styles.talepBaslik}>{talep.baslik}</Text>
        <Text numberOfLines={2} style={ui.altMetin}>{talep.aciklama}</Text>
        <View style={ui.sarilanSatir}>
          <Text style={styles.kategori}>{talep.kategori} · {talep.birim}</Text>
          <View style={[styles.oncelik, { backgroundColor: oncelikRenkleri[talep.oncelik].acik }]}>
            <Text style={[styles.oncelikMetin, { color: oncelikRenkleri[talep.oncelik].koyu }]}>{talep.oncelik}</Text>
          </View>
        </View>
      </Pressable>
      <View style={styles.kartAlt}>
        <StatusBadge durum={talep.durum} />
        <View style={ui.satir}>
          <Text style={styles.detayIpucu}>Detay için dokunun</Text>
          <Pressable
            accessibilityRole="button" accessibilityLabel={`${talep.baslik} talebini sil`}
            onPress={() => onSilmeIstegi(talep.id)} style={ui.ikonButon}
          >
            <Ionicons name="trash-outline" size={18} color="#9A4D57" />
          </Pressable>
        </View>
      </View>
    </View>
  );
}

const styles = StyleSheet.create({
  icerik: { paddingHorizontal: 20, paddingTop: 22, paddingBottom: 30 },
  listeBasligi: { gap: 15, paddingBottom: 17 },
  baslikSatiri: { flexDirection: 'row', flexWrap: 'wrap', justifyContent: 'space-between', alignItems: 'center', gap: 8 },
  toplam: { color: renkler.ikincil, fontSize: 12, fontWeight: '600', backgroundColor: '#E6ECF5', borderRadius: 8, paddingVertical: 7, paddingHorizontal: 10 },
  ozetler: { flexDirection: 'row', flexWrap: 'wrap', gap: 9, marginTop: 3 },
  ozet: { flex: 1, minWidth: 78, padding: 12, borderWidth: 1, borderColor: renkler.cizgi, borderRadius: 14, backgroundColor: renkler.kart, gap: 5 },
  ozetSayi: { fontSize: 26, fontWeight: '700', fontVariant: ['tabular-nums'] },
  ozetEtiket: { fontSize: 11, color: renkler.ikincil },
  aramaKutusu: { flexDirection: 'row', alignItems: 'center', paddingLeft: 13, paddingRight: 3, gap: 8, borderWidth: 1, borderColor: renkler.cizgi, backgroundColor: '#FFFFFF', borderRadius: 12 },
  aramaGiris: { flex: 1, minWidth: 0, minHeight: 48, paddingVertical: 12, color: renkler.metin, fontSize: 14 },
  sonucSatiri: { flexDirection: 'row', flexWrap: 'wrap', justifyContent: 'space-between', alignItems: 'center', gap: 8 },
  sonuc: { color: renkler.ikincil, fontSize: 11 },
  uzunBasIpucu: { color: renkler.ikincil, fontSize: 10 },
  talepKarti: { borderWidth: 1, borderColor: renkler.cizgi, borderRadius: 17, backgroundColor: '#FFFFFF', overflow: 'hidden' },
  kartGovde: { padding: 17, gap: 10 },
  kartUst: { flexDirection: 'row', alignItems: 'center', gap: 10 },
  kategoriSimge: { padding: 9, borderRadius: 10, backgroundColor: '#EDF2FF' },
  numara: { flex: 1, color: renkler.ikincil, fontSize: 11, fontWeight: '500' },
  talepBaslik: { color: renkler.metin, fontSize: 17, lineHeight: 24, fontWeight: '700' },
  kategori: { flexGrow: 1, flexShrink: 1, color: renkler.ikincil, fontSize: 12, lineHeight: 19 },
  oncelik: { borderRadius: 6, paddingVertical: 4, paddingHorizontal: 8 },
  oncelikMetin: { fontSize: 11, fontWeight: '600' },
  kartAlt: { flexDirection: 'row', flexWrap: 'wrap', alignItems: 'center', justifyContent: 'space-between', paddingLeft: 17, paddingRight: 7, paddingVertical: 5, gap: 6, borderTopWidth: 1, borderTopColor: '#EDF1F7' },
  detayIpucu: { color: renkler.ikincil, fontSize: 11 },
  kartAraligi: { height: 12 },
  bosAlan: { alignItems: 'center', paddingVertical: 30, paddingHorizontal: 18, borderRadius: 17, borderWidth: 1, borderColor: renkler.cizgi, backgroundColor: '#FFFFFF', gap: 14 },
  bosSimge: { padding: 17, borderRadius: 18, backgroundColor: '#EDF2FF' },
  bosMetin: { textAlign: 'center', color: renkler.ikincil, fontSize: 13, lineHeight: 21 },
  altBilgi: { textAlign: 'center', fontSize: 11, color: renkler.ikincil, paddingTop: 24 },
});
