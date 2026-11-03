import { Text } from 'react-native';
import { stockLabel } from '../data/products';
export default function StockBadge({ stock }) { return <Text style={{ color: stock === 0 ? '#A3383A' : '#12675F', backgroundColor: stock === 0 ? '#FCEBEB' : '#E4EEEB', paddingHorizontal: 10, paddingVertical: 7, borderRadius: 8, fontWeight: '600', fontSize: 12 }}>{stockLabel(stock)}</Text>; }
