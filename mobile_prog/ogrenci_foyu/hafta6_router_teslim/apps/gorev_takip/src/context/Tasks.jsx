import { createContext, useContext, useState } from 'react';
/** @type {import('react').Context<any>} */
const Context = createContext(null);
export const useTasks = () => useContext(Context);
export function TasksProvider({ children }) {
 const [tasks, setTasks] = useState([{ id: 'g1', title: 'Mobil programlama ödevini tamamla', done: false }, { id: 'g2', title: 'Ders notlarını düzenle', done: false }, { id: 'g3', title: 'Haftalık programı hazırla', done: true }]);
 return <Context.Provider value={{ tasks, toggle: id => setTasks(ts => ts.map(t => t.id === id ? { ...t, done: !t.done } : t)) }}>{children}</Context.Provider>;
}
