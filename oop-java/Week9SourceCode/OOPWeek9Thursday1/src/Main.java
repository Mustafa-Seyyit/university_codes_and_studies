public class Main {
    public static void main(String[] args) {

        SalariedEmployee se = new SalariedEmployee("john", "wick",123,10000);
        HourlyEmployee he = new HourlyEmployee("Mike","tyson",456,10,50);
        CommisionEmployee ce = new CommisionEmployee("logan","powel",234324,0.2f,20000);
        BasePlusCommisionEmployee bpce = new BasePlusCommisionEmployee("elon","musk",4565,0.4f,10000, 1000);

        Employee[] employees = {se, he,ce,bpce};


        for(Employee e: employees)
            if(e instanceof CommisionEmployee)
                System.out.println(e.earning() + " ---> " + e);

    }
}