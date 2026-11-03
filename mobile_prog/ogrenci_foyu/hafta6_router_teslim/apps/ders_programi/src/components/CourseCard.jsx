import { Pressable, Text, View } from 'react-native';
import { router } from 'expo-router';
import { s } from './UI';
export default function CourseCard({ course }) { return <Pressable accessibilityRole="button" accessibilityLabel={`${course.name} detayını aç`} onPress={() => router.push(`/ders/${course.id}`)} style={({ pressed }) => [s.card, pressed && { opacity: 0.7 }]}>
 <View style={s.row}><Text style={s.tag}>{course.day} · {course.time}</Text><Text style={s.body}>{course.code}</Text></View><Text style={s.cardTitle}>{course.name}</Text><Text style={s.body}>{course.room} · {course.duration}</Text><Text style={s.body}>{course.instructor}</Text>
 </Pressable>; }
