import { Stack } from 'expo-router';
import { StatusBar } from 'expo-status-bar';
import { TicketProvider } from '../context/TicketContext';
export default function Layout() {
 return <TicketProvider><StatusBar style="dark" /><Stack screenOptions={{ headerTintColor: '#172C3B', headerShadowVisible: false, contentStyle: { backgroundColor: '#F4F7F6' } }}>
  <Stack.Screen name="index" options={{ title: 'Kampüs Destek' }} />
  <Stack.Screen name="arizalar" options={{ title: 'Arıza Listesi' }} />
  <Stack.Screen name="ariza/[id]" options={{ title: 'Arıza Detayı' }} />
  <Stack.Screen name="yeni-ariza" options={{ title: 'Yeni Arıza' }} />
  <Stack.Screen name="onceki-ekran" options={{ title: 'Önceki Hafta' }} />
 </Stack></TicketProvider>;
}
