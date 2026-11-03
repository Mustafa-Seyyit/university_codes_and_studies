import { Stack } from 'expo-router';
import { TasksProvider } from '../context/Tasks';
export default function Layout() { return <TasksProvider><Stack><Stack.Screen name="(tabs)" options={{ headerShown: false }} /></Stack></TasksProvider>; }
