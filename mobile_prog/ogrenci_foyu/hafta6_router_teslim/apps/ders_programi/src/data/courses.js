// Öğretim elemanı adları örnek veridir.
export const courses = [
 { id: 'd1', name: 'Mobil Programlama', day: 'Salı', time: '09.00', room: 'Lab 2', instructor: 'Öğr. Gör. Deniz Yılmaz', code: 'BPR 201', duration: '3 ders saati' },
 { id: 'd2', name: 'JavaScript', day: 'Çarşamba', time: '13.00', room: 'Lab 1', instructor: 'Öğr. Gör. Ece Kaya', code: 'BPR 203', duration: '2 ders saati' },
 { id: 'd3', name: 'Web Tasarımı', day: 'Perşembe', time: '10.00', room: 'Derslik 3', instructor: 'Öğr. Gör. Can Demir', code: 'BPR 205', duration: '2 ders saati' },
 { id: 'd4', name: 'Veritabanı', day: 'Cuma', time: '11.00', room: 'Lab 4', instructor: 'Öğr. Gör. Selin Aksoy', code: 'BPR 207', duration: '3 ders saati' },
];
export const days = ['Tümü', 'Pazartesi', 'Salı', 'Çarşamba', 'Perşembe', 'Cuma'];
export function filterCourses(day, query) { return courses.filter(c => (day === 'Tümü' || c.day === day) && c.name.toLocaleLowerCase('tr-TR').includes(query.trim().toLocaleLowerCase('tr-TR'))); }
