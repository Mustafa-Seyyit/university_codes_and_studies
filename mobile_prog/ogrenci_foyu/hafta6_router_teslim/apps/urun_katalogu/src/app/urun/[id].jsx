import { Text, View } from 'react-native';
import { useLocalSearchParams } from 'expo-router';
import { products, formatPrice } from '../../data/products';
import StockBadge from '../../components/StockBadge';
import { Page, Heading, Field, Back, Missing, s } from '../../components/UI';
export default function ProductDetail() {
 const { id } = useLocalSearchParams(); const product = products.find(p => p.id === id);
 if (!product) return <Missing type="Ürün" id={id} />;
 return <Page><Heading eyebrow={`ÜRÜN / ${product.id.toUpperCase()}`} title={product.name} />
 <View style={[s.card, { minHeight: 140, justifyContent: 'center', alignItems: 'center', backgroundColor: '#E4EEEB' }]}><Text style={{ fontSize: 64, color: '#12675F' }}>{product.symbol}</Text><Text style={s.tag}>{product.category}</Text></View>
 <View style={s.row}><Text style={s.price}>{formatPrice(product.price)}</Text><StockBadge stock={product.stock} /></View>
 <Field label="Ürün hakkında" value={product.description} /><Field label="Stok miktarı" value={`${product.stock} adet`} /><Field label="Kategori" value={product.category} /><Back /></Page>;
}
