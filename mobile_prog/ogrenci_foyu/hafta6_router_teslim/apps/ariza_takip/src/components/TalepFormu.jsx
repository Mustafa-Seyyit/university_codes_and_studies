import { ScrollView, StyleSheet, Switch, Text, View } from 'react-native';
import Ionicons from '@expo/vector-icons/Ionicons';
import { kategoriler, oncelikler, oncelikRenkleri } from '../utils/talep';
import { Buton, FormAlani, renkler, Secenek, ui } from './Ortak';

export default function TalepFormu({ form, hatalar, onAlanDegistir, onKaydet, onTemizle }) {
  const karakterSayisi = form.aciklama.trim().length;
  return (
    <ScrollView
      style={ui.flex} contentContainerStyle={styles.icerik}
      keyboardShouldPersistTaps="handled" keyboardDismissMode="on-drag"
    >
      <View style={styles.giris}>
        <Text style={styles.ustEtiket}>YENİ TALEP</Text>
        <Text accessibilityRole="header" style={ui.baslik}>Sorunu birlikte çözelim.</Text>
        <Text style={ui.altMetin}>Arızayı açıklayın, talebinizi oluşturun ve durumunu takip edin.</Text>
        <Text style={styles.zorunlu}>* işaretli alanlar zorunludur.</Text>
      </View>

      <View style={ui.kart}>
        <View style={ui.satir}>
          <Ionicons name="person-outline" size={19} color={renkler.mavi} />
          <Text style={ui.bolumBaslik}>Kullanıcı bilgileri</Text>
        </View>
        <FormAlani etiket="Ad Soyad" placeholder="Adınız ve soyadınız" value={form.adSoyad}
          autoCapitalize="words" autoComplete="name" hata={hatalar.adSoyad}
          onChangeText={(deger) => onAlanDegistir('adSoyad', deger)} />
        <FormAlani etiket="Birim" placeholder="Örn. Öğrenci İşleri" value={form.birim} hata={hatalar.birim}
          onChangeText={(deger) => onAlanDegistir('birim', deger)} />
      </View>

      <View style={ui.kart}>
        <View style={ui.satir}>
          <Ionicons name="construct-outline" size={19} color={renkler.mavi} />
          <Text style={ui.bolumBaslik}>Arıza bilgileri</Text>
        </View>
        <FormAlani etiket="Arıza Başlığı" placeholder="Örn. Bilgisayar açılmıyor" value={form.baslik} hata={hatalar.baslik}
          onChangeText={(deger) => onAlanDegistir('baslik', deger)} />
        <FormAlani etiket="Arıza Açıklaması" placeholder="Sorun ne zaman başladı? Neler denediniz?"
          value={form.aciklama} multiline hata={hatalar.aciklama}
          onChangeText={(deger) => onAlanDegistir('aciklama', deger)} />
        <View style={styles.sayacSatir}>
          <Text style={styles.ipucu}>En az 10 karakter</Text>
          <Text style={[styles.sayac, { color: karakterSayisi < 10 ? '#B63743' : '#19734E' }]}>{karakterSayisi} karakter</Text>
        </View>
        <Text style={ui.etiket}>Arıza Kategorisi <Text style={ui.yildiz}>*</Text></Text>
        <View accessibilityRole="radiogroup" accessibilityLabel="Arıza Kategorisi" style={ui.sarilanSatir}>
          {kategoriler.map((item) => (
            <Secenek key={item.ad} metin={item.ad} simge={item.ikon} secili={form.kategori === item.ad}
              onPress={() => onAlanDegistir('kategori', item.ad)} />
          ))}
        </View>
        {!!hatalar.kategori && <Text accessibilityRole="alert" style={ui.hata}>{hatalar.kategori}</Text>}
        {form.kategori === 'Diğer' && (
          <FormAlani etiket="Diğer Arıza Türü" placeholder="Örn. Projeksiyon" value={form.digerKategori}
            hata={hatalar.digerKategori} onChangeText={(deger) => onAlanDegistir('digerKategori', deger)} />
        )}
      </View>

      <View style={ui.kart}>
        <View style={ui.satir}>
          <Ionicons name="options-outline" size={19} color={renkler.mavi} />
          <Text style={ui.bolumBaslik}>Öncelik ve müdahale</Text>
        </View>
        <View accessibilityRole="radiogroup" accessibilityLabel="Öncelik Seviyesi" style={ui.sarilanSatir}>
          {oncelikler.map((item) => (
            <Secenek key={item} metin={item} etiket={`${item} öncelik`} secili={form.oncelik === item}
              renk={oncelikRenkleri[item].koyu} onPress={() => onAlanDegistir('oncelik', item)} />
          ))}
        </View>
        <View style={styles.acil}>
          <View style={ui.flex}>
            <Text style={ui.etiket}>Acil müdahale</Text>
            <Text style={styles.acilAciklama}>Göndermeden önce onayınız alınır.</Text>
          </View>
          <Switch accessibilityLabel="Acil Müdahale Talebi" value={form.acil}
            onValueChange={(deger) => onAlanDegistir('acil', deger)}
            trackColor={{ false: '#CCD6E3', true: '#8BAEF4' }} thumbColor={form.acil ? renkler.mavi : '#F8FAFC'} />
        </View>
      </View>

      <Buton metin="Talebi Kaydet" simge="add-circle-outline" onPress={onKaydet} />
      <Buton metin="Formu Temizle" simge="refresh-outline" ikincil onPress={onTemizle} />
      <Text style={styles.altBilgi}>Bilgi İşlem · Teknik Destek</Text>
    </ScrollView>
  );
}

const styles = StyleSheet.create({
  icerik: { paddingHorizontal: 20, paddingTop: 22, paddingBottom: 30, gap: 16 },
  giris: { gap: 9, marginBottom: 4 },
  ustEtiket: { color: renkler.mavi, fontSize: 10, fontWeight: '700', letterSpacing: 1.7 },
  zorunlu: { color: renkler.ikincil, fontSize: 11, marginTop: 4 },
  sayacSatir: { flexDirection: 'row', flexWrap: 'wrap', justifyContent: 'space-between', gap: 8, marginTop: -7 },
  ipucu: { fontSize: 11, color: renkler.ikincil },
  sayac: { fontSize: 11, fontWeight: '600' },
  acil: { flexDirection: 'row', alignItems: 'center', gap: 12, borderTopWidth: 1, borderTopColor: renkler.cizgi, paddingTop: 16 },
  acilAciklama: { fontSize: 12, lineHeight: 19, marginTop: 5, color: renkler.ikincil },
  altBilgi: { textAlign: 'center', fontSize: 11, color: renkler.ikincil, marginTop: 4 },
});
