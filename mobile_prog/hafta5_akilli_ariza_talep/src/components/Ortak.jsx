import { useState } from 'react';
import { Pressable, StyleSheet, Text, TextInput, View } from 'react-native';
import Ionicons from '@expo/vector-icons/Ionicons';
import { durumRenkleri } from '../utils/talep';

export const renkler = {
  zemin: '#F3F6FA', kart: '#FFFFFF', metin: '#172B46', ikincil: '#617187',
  mavi: '#2459CC', lacivert: '#183D70', cizgi: '#E1E8F0',
};

export function Buton({ metin, simge, onPress, ikincil = false, tehlikeli = false, etiket }) {
  return (
    <Pressable
      accessibilityRole="button" accessibilityLabel={etiket || metin} onPress={onPress}
      style={({ pressed }) => [
        ui.buton, ikincil && ui.ikincilButon,
        tehlikeli && ui.tehlikeliButon, pressed && ui.basili,
      ]}
    >
      {simge && <Ionicons name={simge} size={18} color={ikincil ? renkler.mavi : '#FFFFFF'} />}
      <Text style={[ui.butonMetin, ikincil && ui.ikincilMetin]}>{metin}</Text>
    </Pressable>
  );
}

export function FormAlani({ etiket, hata, ...props }) {
  const [odakta, setOdakta] = useState(false);
  return (
    <View style={ui.alan}>
      <Text style={ui.etiket}>{etiket} <Text style={ui.yildiz}>*</Text></Text>
      <TextInput
        {...props} accessibilityLabel={etiket} accessibilityHint={hata || 'Zorunlu alan'}
        placeholderTextColor="#8795A6" selectionColor={renkler.mavi}
        onFocus={() => setOdakta(true)} onBlur={() => setOdakta(false)}
        style={[ui.giris, props.multiline && ui.uzunGiris, odakta && ui.odak, hata && ui.hatali]}
      />
      {!!hata && <Text accessibilityRole="alert" style={ui.hata}>{hata}</Text>}
    </View>
  );
}

export function Secenek({ metin, etiket, secili, onPress, simge, renk }) {
  return (
    <Pressable
      accessibilityRole="radio" accessibilityLabel={etiket || metin} aria-checked={secili}
      onPress={onPress}
      style={({ pressed }) => [
        ui.secenek, secili && { backgroundColor: renk || renkler.mavi, borderColor: renk || renkler.mavi },
        pressed && ui.basili,
      ]}
    >
      {simge && <Ionicons name={simge} size={17} color={secili ? '#FFFFFF' : renkler.ikincil} />}
      <Text style={[ui.secenekMetin, secili && ui.seciliMetin]}>{metin}</Text>
    </Pressable>
  );
}

export function DurumRozeti({ durum }) {
  const renk = durumRenkleri[durum];
  return (
    <View style={[ui.rozet, { backgroundColor: renk.acik }]}>
      <View style={[ui.nokta, { backgroundColor: renk.koyu }]} />
      <Text style={[ui.rozetMetin, { color: renk.koyu }]}>{durum}</Text>
    </View>
  );
}

export function Bildirim({ mesaj, onKapat }) {
  if (!mesaj) return null;
  return (
    <View style={ui.bildirim}>
      <Ionicons name="checkmark-circle-outline" size={20} color="#19734E" />
      <Text accessibilityLiveRegion="polite" style={ui.bildirimMetin}>{mesaj}</Text>
      <Pressable accessibilityRole="button" accessibilityLabel="Bildirimi kapat" onPress={onKapat} style={ui.ikonButon}>
        <Ionicons name="close" size={19} color="#19734E" />
      </Pressable>
    </View>
  );
}

export const ui = StyleSheet.create({
  flex: { flex: 1 },
  satir: { flexDirection: 'row', alignItems: 'center', gap: 8 },
  sarilanSatir: { flexDirection: 'row', flexWrap: 'wrap', alignItems: 'center', gap: 8 },
  kart: { padding: 18, borderRadius: 18, borderWidth: 1, borderColor: renkler.cizgi, backgroundColor: renkler.kart, gap: 16 },
  baslik: { fontSize: 27, lineHeight: 34, fontWeight: '800', letterSpacing: -0.6, color: renkler.metin },
  altMetin: { fontSize: 13, lineHeight: 21, color: renkler.ikincil },
  bolumBaslik: { fontSize: 16, fontWeight: '700', color: renkler.metin },
  etiket: { fontSize: 13, fontWeight: '600', color: renkler.metin },
  alan: { gap: 8 },
  yildiz: { color: renkler.mavi },
  giris: { minHeight: 48, paddingHorizontal: 13, paddingVertical: 12, borderRadius: 11, borderWidth: 1, borderColor: '#DCE4EE', backgroundColor: '#F8FAFC', color: renkler.metin, fontSize: 15 },
  uzunGiris: { minHeight: 108, textAlignVertical: 'top', lineHeight: 22 },
  odak: { borderColor: renkler.mavi, backgroundColor: '#FFFFFF' },
  hatali: { borderColor: '#B63743' },
  hata: { fontSize: 12, lineHeight: 18, color: '#B63743' },
  secenek: { minHeight: 44, flexDirection: 'row', alignItems: 'center', justifyContent: 'center', gap: 6, paddingHorizontal: 11, paddingVertical: 10, borderWidth: 1, borderColor: '#E1E8F0', borderRadius: 10, backgroundColor: '#F6F8FB' },
  secenekMetin: { color: renkler.ikincil, fontSize: 12, fontWeight: '600' },
  seciliMetin: { color: '#FFFFFF' },
  buton: { minHeight: 48, paddingHorizontal: 16, paddingVertical: 13, flexDirection: 'row', justifyContent: 'center', alignItems: 'center', gap: 8, backgroundColor: renkler.mavi, borderRadius: 12 },
  butonMetin: { fontSize: 14, fontWeight: '700', color: '#FFFFFF', flexShrink: 1 },
  ikincilButon: { backgroundColor: '#EBF1FF' },
  ikincilMetin: { color: renkler.mavi },
  tehlikeliButon: { backgroundColor: '#B63743' },
  ikonButon: { width: 44, height: 44, alignItems: 'center', justifyContent: 'center', borderRadius: 10 },
  basili: { opacity: 0.65 },
  rozet: { alignSelf: 'flex-start', flexDirection: 'row', alignItems: 'center', gap: 6, borderRadius: 7, paddingHorizontal: 9, paddingVertical: 6 },
  nokta: { width: 6, height: 6, borderRadius: 3 },
  rozetMetin: { fontSize: 12, fontWeight: '600' },
  bildirim: { flexDirection: 'row', alignItems: 'center', gap: 8, paddingLeft: 12, backgroundColor: '#EAF7EF', borderRadius: 12, borderWidth: 1, borderColor: '#BDE3CD' },
  bildirimMetin: { flex: 1, color: '#19734E', fontSize: 12, lineHeight: 18, paddingVertical: 10 },
});
