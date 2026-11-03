import { useTasks } from '../../context/Tasks';
import { Page, Heading, Field } from '../../components/UI';
export default function Profile() { const { tasks } = useTasks(); return <Page><Heading eyebrow="KİŞİSEL ALAN" title="Öğrenci profili" description="Örnek profil · Mobil Programlama" /><Field label="Toplam görev" value={String(tasks.length)} /><Field label="Tamamlanan" value={String(tasks.filter(t => t.done).length)} /><Field label="Bekleyen" value={String(tasks.filter(t => !t.done).length)} /></Page>; }
