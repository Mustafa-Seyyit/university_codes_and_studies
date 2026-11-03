export const products = [
 { id: 'p1', name: 'Kablosuz Fare', price: 450, category: 'Aksesuar', stock: 8, description: 'Bluetooth bağlantılı ergonomik fare. Sessiz tuşları ve kompakt tasarımıyla günlük çalışmalara eşlik eder.', symbol: '↗' },
 { id: 'p2', name: 'Mekanik Klavye', price: 1800, category: 'Aksesuar', stock: 0, description: 'Mekanik tuşlu klavye. Türkçe Q dizilim ve ayarlanabilir aydınlatma ile rahat yazım deneyimi.', symbol: '⌨' },
 { id: 'p3', name: 'USB-C Çoklayıcı', price: 950, category: 'Bağlantı', stock: 12, description: 'HDMI, USB-A ve USB-C girişlerini tek bir gövdede birleştiren taşınabilir çoklayıcı.', symbol: '⊞' },
 { id: 'p4', name: 'Kablosuz Kulaklık', price: 2400, category: 'Ses', stock: 5, description: 'Yumuşak kulak yastıkları ve dahili mikrofonuyla dersler ve çevrim içi toplantılar için kulaklık.', symbol: '♫' },
 { id: 'p5', name: 'Taşınabilir SSD', price: 3200, category: 'Depolama', stock: 3, description: '1 TB kapasiteli taşınabilir SSD. Proje dosyalarını yanınızda taşımak için hafif metal gövde.', symbol: '▤' },
];
export const formatPrice = price => new Intl.NumberFormat('tr-TR', { style: 'currency', currency: 'TRY', maximumFractionDigits: 0 }).format(price);
export const stockLabel = stock => stock === 0 ? 'Stokta yok' : 'Stokta';
