import { Text, View } from 'react-native';
import { durumRenkleri } from '../utils/talep';
export default function StatusBadge({ durum }) {
  const renk = durumRenkleri[durum] || { koyu: '#475569', acik: '#F1F5F9' };
  return <View style={{ backgroundColor: renk.acik, borderRadius: 8, paddingHorizontal: 10, paddingVertical: 7 }}>
    <Text style={{ color: renk.koyu, fontSize: 12, fontWeight: '700' }}>{durum}</Text>
  </View>;
}
