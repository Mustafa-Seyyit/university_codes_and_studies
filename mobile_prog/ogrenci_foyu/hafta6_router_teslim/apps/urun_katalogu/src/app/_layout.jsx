import { Stack } from 'expo-router';
import { StatusBar } from 'expo-status-bar';
export default function Layout() { return <><StatusBar style="dark" /><Stack screenOptions={{ headerTintColor: '#172C3B', headerShadowVisible: false }}><Stack.Screen name="index" options={{ title: 'Mini Ürün Kataloğu' }} /><Stack.Screen name="urun/[id]" options={{ title: 'Detay' }} /></Stack></>; }
