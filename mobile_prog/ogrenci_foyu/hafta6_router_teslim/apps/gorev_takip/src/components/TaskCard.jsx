import { Text, View } from 'react-native';
import { Button, s } from './UI';
export default function TaskCard({ task, onToggle }) { return <View style={s.card}><Text style={s.cardTitle}>{task.title}</Text><Text style={s.body}>{task.done ? 'Tamamlandı' : 'Yapılacak'}</Text><Button title={task.done ? 'Yeniden aç' : 'Tamamla'} onPress={() => onToggle(task.id)} secondary /></View>; }
