import { useState } from 'react';
import { FlatList, Text, TextInput, View, Pressable } from 'react-native';
import { days, filterCourses } from '../data/courses';
import CourseCard from '../components/CourseCard';
import { Frame, Heading, Button, s } from '../components/UI';
export default function Courses() {
 const [day, setDay] = useState('Tümü'); const [query, setQuery] = useState(''); const data = filterCourses(day, query);
 return <Frame><FlatList contentContainerStyle={s.content} data={data} keyExtractor={c => c.id} keyboardShouldPersistTaps="handled"
 ListHeaderComponent={<View style={{ gap: 15 }}><Heading eyebrow="2026–2027 / GÜZ DÖNEMİ" title="Haftanı planla." description="Derslerin, sınıfların ve öğretim elemanların bir arada." /><TextInput accessibilityLabel="Ders ara" placeholder="Ders adına göre ara…" value={query} onChangeText={setQuery} style={s.input} />
 <View style={[s.row, { justifyContent: 'flex-start' }]}>{days.map(d => <Pressable key={d} accessibilityRole="button" accessibilityLabel={`Gün: ${d}`} accessibilityState={{ selected: d === day }} onPress={() => setDay(d)} style={{ minHeight: 44, justifyContent: 'center' }}><Text style={[s.tag, day === d && { color: '#FFF', backgroundColor: '#12675F' }]}>{d}</Text></Pressable>)}</View><Text style={s.body}>{data.length} ders</Text></View>}
 renderItem={({ item }) => <CourseCard course={item} />}
 ListEmptyComponent={<View style={s.card}><Text style={s.cardTitle}>Ders bulunamadı</Text><Text style={s.body}>Bu gün veya arama için kayıt yok.</Text><Button title="Filtreleri temizle" onPress={() => { setDay('Tümü'); setQuery(''); }} /></View>} /></Frame>;
}
