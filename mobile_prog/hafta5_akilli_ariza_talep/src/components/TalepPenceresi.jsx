import { Modal, Pressable, ScrollView, StyleSheet, Text, View } from 'react-native';
import { SafeAreaProvider, SafeAreaView } from 'react-native-safe-area-context';
import Ionicons from '@expo/vector-icons/Ionicons';
import { durumlar, durumRenkleri } from '../utils/talep';
import { Bildirim, Buton, DurumRozeti, renkler, Secenek, ui } from './Ortak';

function Bilgi({ etiket, deger }) {
  return (
    <View style={styles.bilgi}>
      <Text style={styles.bilgiEtiket}>{etiket}</Text>
      <Text selectable style={styles.bilgiDeger}>{deger}</Text>
    </View>
  );
}

export default function TalepPenceresi({
  pencere, talep, bildirim, onBildirimiKapat, onKapat,
  onSilmeIstegi, onSil, onAcilOnay, onDurumDegistir,
}) {
  if (!pencere) return null;
  const detay = pencere.tur === 'detay';
  const silme = pencere.tur === 'sil';
  const acil = pencere.tur === 'acil';
  const baslik = detay ? 'Talep ayrıntıları' : silme ? 'Talep silinsin mi?' : acil ? 'Acil talep onayı' : pencere.baslik;
  return (
    <Modal visible transparent animationType="fade" onRequestClose={onKapat} supportedOrientations={['portrait', 'landscape']}>
      <SafeAreaProvider>
        <SafeAreaView style={styles.guvenliAlan}>
          <View style={styles.arkaPlan}>
            <View role="dialog" accessibilityViewIsModal accessibilityLabel={baslik} style={styles.pencere}>
              <View style={styles.pencereUst}>
                <Text accessibilityRole="header" style={styles.pencereBaslik}>{baslik}</Text>
                <Pressable accessibilityRole="button" accessibilityLabel="Pencereyi kapat" onPress={onKapat} style={ui.ikonButon}>
                  <Ionicons name="close" size={22} color={renkler.ikincil} />
                </Pressable>
              </View>
              <ScrollView style={styles.kaydirma} contentContainerStyle={styles.icerik} keyboardShouldPersistTaps="handled">
                {detay && talep ? (
                  <>
                    <View style={styles.detayUst}>
                      <Text style={styles.numara}>{talep.id}</Text>
                      <DurumRozeti durum={talep.durum} />
                    </View>
                    <Text style={styles.talepBaslik}>{talep.baslik}</Text>
                    <Bilgi etiket="Açıklama" deger={talep.aciklama} />
                    <View style={styles.bilgiler}>
                      <Bilgi etiket="Kategori" deger={talep.kategori === 'Diğer' ? `Diğer · ${talep.digerKategori}` : talep.kategori} />
                      <Bilgi etiket="Talep sahibi" deger={talep.adSoyad} />
                      <Bilgi etiket="Birim" deger={talep.birim} />
                      <Bilgi etiket="Öncelik" deger={talep.oncelik} />
                      <Bilgi etiket="Acil müdahale" deger={talep.acil ? 'Evet' : 'Hayır'} />
                      <Bilgi etiket="Oluşturulma" deger={talep.tarih} />
                    </View>
                    <View style={styles.durumAlani}>
                      <Text style={ui.bolumBaslik}>Durumu güncelle</Text>
                      <Text style={ui.altMetin}>Talep için geçerli durumu seçin.</Text>
                      <View accessibilityRole="radiogroup" accessibilityLabel="Talep durumu" style={ui.sarilanSatir}>
                        {durumlar.map((durum) => (
                          <Secenek key={durum} metin={durum} etiket={`Talep durumu: ${durum}`}
                            renk={durumRenkleri[durum].koyu} secili={talep.durum === durum}
                            onPress={() => onDurumDegistir(talep.id, durum)} />
                        ))}
                      </View>
                    </View>
                    <Bildirim mesaj={bildirim} onKapat={onBildirimiKapat} />
                    <Buton metin="Talebi sil" simge="trash-outline" tehlikeli onPress={() => onSilmeIstegi(talep.id, true)} />
                  </>
                ) : silme ? (
                  <>
                    <View style={styles.uyariSimge}><Ionicons name="trash-outline" size={30} color="#B63743" /></View>
                    <Text style={styles.talepBaslik}>{talep?.baslik}</Text>
                    <Text style={ui.altMetin}>Yalnızca bu talep silinecek. Bu işlem geri alınamaz.</Text>
                    <View style={styles.onaylar}>
                      <View style={styles.onayButon}><Buton metin="Vazgeç" ikincil onPress={onKapat} /></View>
                      <View style={styles.onayButon}><Buton metin="Talebi sil" tehlikeli onPress={onSil} /></View>
                    </View>
                  </>
                ) : acil ? (
                  <>
                    <Ionicons name="flash-outline" size={34} color="#A46012" />
                    <Text style={ui.altMetin}>Bu arıza için acil müdahale istiyorsunuz. Talebinizi acil olarak kaydetmeyi onaylıyor musunuz?</Text>
                    <View style={styles.onaylar}>
                      <View style={styles.onayButon}><Buton metin="Vazgeç" ikincil onPress={onKapat} /></View>
                      <View style={styles.onayButon}><Buton metin="Onayla ve kaydet" onPress={onAcilOnay} /></View>
                    </View>
                  </>
                ) : (
                  <>
                    <Ionicons name="alert-circle-outline" size={34} color={renkler.mavi} />
                    <Text style={ui.altMetin}>{pencere.mesaj}</Text>
                    <Buton metin="Forma dön" onPress={onKapat} />
                  </>
                )}
              </ScrollView>
            </View>
          </View>
        </SafeAreaView>
      </SafeAreaProvider>
    </Modal>
  );
}

const styles = StyleSheet.create({
  guvenliAlan: { flex: 1, backgroundColor: 'rgba(15, 30, 53, 0.48)' },
  arkaPlan: { flex: 1, justifyContent: 'center', alignItems: 'center', padding: 20 },
  pencere: { width: '100%', maxWidth: 560, maxHeight: '100%', backgroundColor: '#FFFFFF', borderRadius: 21, overflow: 'hidden' },
  pencereUst: { flexDirection: 'row', alignItems: 'center', justifyContent: 'space-between', gap: 10, paddingLeft: 20, paddingRight: 8, paddingVertical: 10, borderBottomWidth: 1, borderBottomColor: renkler.cizgi },
  pencereBaslik: { flex: 1, fontSize: 18, fontWeight: '700', color: renkler.metin },
  kaydirma: { flexGrow: 0, flexShrink: 1 },
  icerik: { padding: 20, gap: 18 },
  detayUst: { flexDirection: 'row', flexWrap: 'wrap', alignItems: 'center', justifyContent: 'space-between', gap: 10 },
  numara: { color: renkler.ikincil, fontSize: 11 },
  talepBaslik: { color: renkler.metin, fontSize: 21, lineHeight: 29, fontWeight: '700' },
  bilgi: { gap: 5, flexShrink: 1 },
  bilgiEtiket: { color: renkler.ikincil, fontSize: 11 },
  bilgiDeger: { color: renkler.metin, fontSize: 14, lineHeight: 22 },
  bilgiler: { backgroundColor: '#F5F8FC', borderRadius: 13, padding: 15, gap: 13 },
  durumAlani: { gap: 10, paddingTop: 4 },
  uyariSimge: { alignSelf: 'flex-start', padding: 15, borderRadius: 16, backgroundColor: '#FFF0F1' },
  onaylar: { flexDirection: 'row', flexWrap: 'wrap', gap: 10, marginTop: 5 },
  onayButon: { flexGrow: 1, flexBasis: 120 },
});
