import abstract_pack.Employee;
import abstract_pack.FullTimeEmployee;
import abstract_pack.PartTimeEmployee;
import interface_pack.*;

public class Main {
    public static void main(String[] args) {
        Employee fte = new FullTimeEmployee("full time emp", 10);
        Employee pte = new PartTimeEmployee("part time emp",10,5);


        //interface_pack.Employee fte2 = new interface_pack.FullTimeEmployee("full time emp2", 10);
    }
}