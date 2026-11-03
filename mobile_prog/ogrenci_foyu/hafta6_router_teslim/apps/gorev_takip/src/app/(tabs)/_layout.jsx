import { Tabs } from 'expo-router';
import Ionicons from '@expo/vector-icons/Ionicons';
export default function Layout() { return <Tabs screenOptions={{ tabBarActiveTintColor: '#12675F', headerTintColor: '#172C3B', tabBarStyle: { minHeight: 65 } }}>
 <Tabs.Screen name="index" options={{ title: 'Görevler', tabBarIcon: ({ color, size }) => <Ionicons name="list-outline" color={color} size={size} /> }} />
 <Tabs.Screen name="tamamlananlar" options={{ title: 'Tamamlananlar', tabBarIcon: ({ color, size }) => <Ionicons name="checkmark-circle-outline" color={color} size={size} /> }} />
 <Tabs.Screen name="profil" options={{ title: 'Profil', tabBarIcon: ({ color, size }) => <Ionicons name="person-outline" color={color} size={size} /> }} />
 </Tabs>; }
