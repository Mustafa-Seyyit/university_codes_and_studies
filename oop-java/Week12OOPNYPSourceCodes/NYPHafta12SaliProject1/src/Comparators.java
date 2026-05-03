import java.util.Comparator;

class NameComparator implements Comparator<Teacher>{
    @Override
    public int compare(Teacher t1, Teacher t2) {
        return t1.name.compareTo(t2.name);
    }
}


class IDComparator implements Comparator<Teacher>{
    @Override
    public int compare(Teacher t1, Teacher t2) {
        return t1.id - t2.id;
    }
}

class WageComparator implements Comparator<Teacher>{
    @Override
    public int compare(Teacher t1, Teacher t2) {
        if(t1.wage > t2.wage) return 1;
        else if(t1.wage < t2.wage) return  -1;
        else  return  0;
    }
}

class BranchComparator implements Comparator<Teacher>{
    @Override
    public int compare(Teacher t1, Teacher t2) {
        return t1.branch.name().compareTo(t2.branch.name());
    }
}