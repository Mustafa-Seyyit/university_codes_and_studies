import { FlatList, Text } from 'react-native';
import { useTasks } from '../../context/Tasks';
import TaskCard from '../../components/TaskCard';
import { Frame, Heading, s } from '../../components/UI';
export default function Tasks() { const { tasks, toggle } = useTasks(); return <Frame><FlatList contentContainerStyle={s.content} data={tasks.filter(t => t.done === true)} keyExtractor={t => t.id} ListHeaderComponent={<Heading eyebrow="ADIM ADIM / GÖREV TAKİBİ" title="Tamamlananlar" />} renderItem={({ item }) => <TaskCard task={item} onToggle={toggle} />} ListEmptyComponent={<Text style={s.body}>Bu listede görev yok.</Text>} /></Frame>; }
