public class Main {
    public static void main(String[] args) {
       HourlyEmployee he = new HourlyEmployee("john", "wick", 32434,10,100);
       SalariedEmployee se = new SalariedEmployee("john","tyson",454534,500);
       CommisionEmployee ce = new CommisionEmployee("charly","poor",324343,0.2f,10000);
       BasePlusCommisionEmployee bpce = new BasePlusCommisionEmployee("alex","musk",34553,0.2f,10000,1000);


       Employee[] employees = new Employee[]{he, ce, se, bpce};

       for(Employee e: employees)
           if(e instanceof SalariedEmployee)
           System.out.println(e +" ---> " +e.earning());

    }
}