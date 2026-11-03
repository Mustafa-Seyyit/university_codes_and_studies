import { FlatList } from 'react-native';
import { products } from '../data/products';
import ProductCard from '../components/ProductCard';
import { Frame, Heading, s } from '../components/UI';
export default function Products() { return <Frame><FlatList contentContainerStyle={s.content} data={products} keyExtractor={p => p.id}
 ListHeaderComponent={<Heading eyebrow="TEKNOLOJİ / KOLEKSİYON 01" title="Çalışma alanına iyi gelir." description="Günlük hayatı kolaylaştıran 5 teknoloji ürünü. İhtiyacınız olanı keşfedin." />}
 renderItem={({ item }) => <ProductCard product={item} />} /></Frame>; }
