import java.util.Comparator;

class NameComparator implements Comparator<Engineer>{
    @Override
    public int compare(Engineer e1, Engineer e2) {
        return e1.name.compareTo(e2.name);
    }
}

class IdComparator implements Comparator<Engineer>{
    @Override
    public int compare(Engineer e1, Engineer e2) {
        return e1.id - e2.id;
//        if(e1.id > e2.id) return  1;
//        else if(e1.id < e2.id) return -1;
//        else return 0;
    }
}

class FieldComparator implements Comparator<Engineer>{
    @Override
    public int compare(Engineer e1, Engineer e2) {
        return e1.field.compareTo(e2.field);
    }
}