import { Pressable, ScrollView, StyleSheet, Text, View } from 'react-native';
import { SafeAreaView } from 'react-native-safe-area-context';
import { router } from 'expo-router';
export const colors = { ink: '#172C3B', muted: '#536B7B', accent: '#12675F', bg: '#F4F7F6', line: '#DCE5E2' };
export function Frame({ children }) { return <SafeAreaView edges={['bottom', 'left', 'right']} style={s.frame}><View style={s.width}>{children}</View></SafeAreaView>; }
export function Page({ children }) { return <Frame><ScrollView contentContainerStyle={s.content}>{children}</ScrollView></Frame>; }
export function Heading({ eyebrow, title, description = '' }) { return <View style={{ gap: 9, paddingBottom: 8 }}><Text style={s.eyebrow}>{eyebrow}</Text><Text accessibilityRole="header" style={s.title}>{title}</Text>{!!description && <Text style={s.body}>{description}</Text>}</View>; }
export function Button({ title, onPress, secondary = false }) { return <Pressable accessibilityRole="button" accessibilityLabel={title} onPress={onPress} style={({ pressed }) => [s.button, secondary && { backgroundColor: '#E4EEEB' }, pressed && { opacity: 0.7 }]}><Text style={[s.buttonText, secondary && { color: colors.accent }]}>{title}</Text></Pressable>; }
export function Back({ href = '/' }) { return <Button title="Listeye geri dön" secondary onPress={() => { if (router.canGoBack()) router.back(); else router.replace(href); }} />; }
export function Missing({ type, id, href = '/' }) { return <Page><Heading eyebrow="KAYIT BULUNAMADI" title={`${type} bulunamadı`} description={`“${id || 'boş'}” kimliğine ait kayıt yok. Listeye dönerek başka bir kayıt seçebilirsiniz.`} /><Back href={href} /></Page>; }
export function Field({ label, value }) { return <View style={s.field}><Text style={s.label}>{label}</Text><Text selectable style={s.value}>{value}</Text></View>; }
export const s = StyleSheet.create({
 frame: { flex: 1, backgroundColor: colors.bg }, width: { flex: 1, width: '100%', maxWidth: 760, alignSelf: 'center' },
 content: { padding: 22, gap: 18, paddingBottom: 36 }, eyebrow: { fontSize: 11, letterSpacing: 1.8, fontWeight: '700', color: colors.accent },
 title: { fontSize: 30, lineHeight: 37, fontWeight: '700', color: colors.ink }, body: { fontSize: 14, lineHeight: 22, color: colors.muted },
 card: { padding: 20, borderRadius: 18, borderWidth: 1, borderColor: colors.line, backgroundColor: '#FFFFFF', gap: 12, marginBottom: 14 },
 cardTitle: { fontSize: 19, lineHeight: 26, fontWeight: '700', color: colors.ink }, row: { flexDirection: 'row', alignItems: 'center', flexWrap: 'wrap', gap: 10, justifyContent: 'space-between' },
 price: { fontSize: 25, fontWeight: '700', color: colors.ink }, tag: { color: colors.accent, backgroundColor: '#E4EEEB', paddingHorizontal: 10, paddingVertical: 6, borderRadius: 7, fontSize: 12, fontWeight: '600' },
 button: { minHeight: 48, padding: 14, borderRadius: 12, backgroundColor: colors.accent, justifyContent: 'center', alignItems: 'center' }, buttonText: { color: '#FFFFFF', fontSize: 14, fontWeight: '700' },
 field: { gap: 5, paddingVertical: 12, borderBottomWidth: 1, borderBottomColor: colors.line }, label: { fontSize: 12, color: colors.muted }, value: { fontSize: 16, lineHeight: 25, color: colors.ink },
 input: { minHeight: 48, backgroundColor: '#FFF', borderWidth: 1, borderColor: colors.line, borderRadius: 12, padding: 13, fontSize: 14, color: colors.ink },
});
