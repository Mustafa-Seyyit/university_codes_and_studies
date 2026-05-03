import java.io.Serializable;
import java.util.Comparator;

public class Engineer implements Comparable<Engineer>, Serializable {
    String name;
    int id;

    String field;


    public Engineer(String name, int id, String field) {
        this.name = name;
        this.id = id;
        this.field = field;
    }

    @Override
    public String toString() {
        return String.format("name: %s id: %d field: %s",name,id,field);
    }


    @Override
    public boolean equals(Object other) {
        Engineer otherEngineer = (Engineer) other;
        if(this == otherEngineer)  return true;
        if(otherEngineer == null || this.getClass() != otherEngineer.getClass()) return  false;
        else return
                this.name.equals(otherEngineer.name) &&
                this.id == otherEngineer.id &&
                this.field.equals(otherEngineer.field);
    }

    @Override
    public int compareTo(Engineer other) {
      return this.name.compareTo(other.name);
    }


//    @Override
//    public int compareTo(Engineer other) {
//        if (this.id > other.id) return 1;
//        else if(this.id == other.id) return  0;
//        else return -1;
//    }
}
