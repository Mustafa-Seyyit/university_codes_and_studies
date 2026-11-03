import { View } from 'react-native';
import { useLocalSearchParams } from 'expo-router';
import { courses } from '../../data/courses';
import { Page, Heading, Field, Back, Missing, s } from '../../components/UI';
export default function CourseDetail() {
 const { id } = useLocalSearchParams(); const course = courses.find(c => c.id === id);
 if (!course) return <Missing type="Ders" id={id} />;
 return <Page><Heading eyebrow={`DERS / ${course.code}`} title={course.name} /><View style={s.card}>
 <Field label="Ders ID" value={course.id} /><Field label="Ders adı" value={course.name} /><Field label="Gün" value={course.day} /><Field label="Saat" value={course.time} /><Field label="Sınıf" value={course.room} /><Field label="Öğretim elemanı" value={course.instructor} /><Field label="Süre" value={course.duration} /></View><Back /></Page>;
}
