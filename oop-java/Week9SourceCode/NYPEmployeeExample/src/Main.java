public class Main {
    public static void main(String[] args) {
      SalariedEmployee se = new SalariedEmployee("jan","ack",123213,500);
      HourlyEmployee he = new HourlyEmployee("mike", "tyson",123,10,45);
      CommisionEmployee ce = new CommisionEmployee("jacke","paul",34535,0.2f,10000);
      BasePlusCommisionEmployee bpce = new BasePlusCommisionEmployee("asdsad", "dfgdg", 6576,0.2f,10000,1000);

      Employee[] employees = new Employee[]{se, he, ce, bpce};

      for(Employee e : employees)
          if(e instanceof CommisionEmployee)  // is
              System.out.println(e + " - > earning: "+ e.earning());

    }
}