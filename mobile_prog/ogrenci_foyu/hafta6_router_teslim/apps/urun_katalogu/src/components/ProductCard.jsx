import { Pressable, Text, View } from 'react-native';
import { router } from 'expo-router';
import { formatPrice } from '../data/products';
import StockBadge from './StockBadge';
import { s } from './UI';
export default function ProductCard({ product }) {
 return <Pressable accessibilityRole="button" accessibilityLabel={`${product.name} detayını aç`} onPress={() => router.push(`/urun/${product.id}`)} style={({ pressed }) => [s.card, pressed && { opacity: 0.7 }]}>
 <View style={s.row}><Text style={{ fontSize: 32, color: '#12675F' }}>{product.symbol}</Text><Text style={s.tag}>{product.category}</Text></View>
 <Text style={s.cardTitle}>{product.name}</Text><View style={s.row}><Text style={s.price}>{formatPrice(product.price)}</Text><StockBadge stock={product.stock} /></View><Text style={s.body}>{product.stock} adet · Ürünü incele →</Text>
 </Pressable>;
}
