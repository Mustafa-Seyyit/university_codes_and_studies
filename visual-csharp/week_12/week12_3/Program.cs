using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week12_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //KÜME İŞLEMLERİ
            /*
             * Except,  // Fark
             * Union,  // Birleşim
             * Concat,  // Uç uca ekleme
             * Intersect,  // Kesişim
             * Distinct // Tekrarlayan verileri bulur
             */

            /********************** Except ************************/
            /*
            * Matematikte küme işlemlerindeki FARK operatörüyle aynı işlemi yapar.
            * Except() metodu,  ilk koleksiyonda olup ikinci koleksiyonda olmayan kayıtların listelenmesini sağlar.. 
            */

            string[] dayList1 = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            string[] dayList2 = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma" };
            var resultDayList1 = dayList1.Except(dayList2); //dayList1'de olup dayList2'de olmayan kayıtlar resultDayList1 nesnesine aktarılır.
            Console.WriteLine("********************** Except ************************");
            foreach (var day in resultDayList1)
                Console.WriteLine(day);

            /********************** Union ************************/
            /*
            * Matematikte küme işlemlerindeki BİRLEŞME operatörüyle aynı işlemi yapar. Bir kümede bir elemandan birden fazla sayıda bulunamaz
            * Union() metodu ile bu koleksiyonlar birleştirilir ve tekrarlayan değerler yeni oluşan koleksiyonda bulunmaz.. 
            * NOT: Union metodu birleştirme sonucunda elde edilen yapıda tekrarlayan veriler silinir.
            */
            Console.WriteLine("********************** Union ************************");
            var resultDayList2 = dayList1.Union(dayList2);
            foreach (var day in resultDayList2)
                Console.WriteLine(day);


            /********************** Concatenation - Sonuna Ekleme ************************/
            /*
            *  Birinci koleksiyonun elemanlarından sonra ikinci koleksiyonun elemanları listelenecek şekilde yeni bir koleksiyon oluşur.
            *  NOT: Union'dan farklı olarak yinelenenleri silmez!
            */
            Console.WriteLine("********************** Concatenation ************************");
            var resultDayList3 = dayList1.Concat(dayList2);
            foreach (var day in resultDayList3)
                Console.WriteLine(day);


            /********************** Intersect() ************************/
            /*
            * Intersect anahtar sözcüğü küme işlemlerindeki kesişim operatörü gibi çalışır.
            * Intersect anahtar sözcüğü iki koleksiyonda bulunan tekrarlayan kayıtların listelenmesini sağlar.
            * Intersect anahtar sözcüğü ile iki koleksiyonda bulunan ve tekrarlayan kayıt var ise sadece tekrarlayan kayıtları yeni bir koleksiyon olarak döner.
            * Aşağıdaki örnekte bulunan koleksiyonlarda Intersect anahtar sözcüğü ile tekrarlayan değerlerin listesini verir.
            */
            Console.WriteLine("********************** Intersect ************************");
            var resultDayList4 = dayList1.Intersect(dayList2);
            foreach (var day in resultDayList4)
                Console.WriteLine(day);


            /********************** Distinct() ************************/

            /*
              * Distinct() anahtar sözcüğü koleksiyon içerisinde bulunan tekrarlayan kayıtların gösterilmesini engeller.
              * Koleksiyonda bulunan verilerin tekrarlayan kayıtların tekrarlanmamasını sağlar.
              * Koleksiyonda bulunan günlerde tekrarlayan günler mevcut ve aşağıdaki örnekte tekrarlayan kayıtların ekrana yazılması engellenir.
           */

            string[] dayList3 = { "Pazartesi", "Pazartesi", "Salı", "Salı", "Çarşamba", "Çarşamba", "Perşembe", "Perşembe", "Cuma", "Cuma", "Cumartesi", "Cumartesi", "Pazar", "Pazar" };

            var resultDayList5 = dayList3.Distinct();
            Console.WriteLine("********************** Distinct ************************");

            foreach (var item in resultDayList5)
                Console.WriteLine(item);


            //NOT : Sınıflarda bunu yapabilmemiz için 2 nesnenin birbirine eşit olup olmadığını belirleyen yapının sınıfta belirtilmesi gerekiyor. Bunun için de o sınıfa IEquatable interface'inin implemente edilmesi gerekiyor. IEquatable interface implemente edildiğinde basitçe Equals adında bir metodun tanımlanması gerekiyor o sınıfta bizdeki örnekteyse Person sınıfında. Equals metounda karşısına gelecek Person objesiyle şu anki Person objesi hangi kurala göre eşit sayılacak veya farklı sayılacak bunu belirliyoruz. Bizim örnekte firstName'ler eşit olursa ve geri kalan tüm değerler farklı olsa bile o 2 person objesi aynı sayılır. 

            List<Person> personList1 = new List<Person>();
            personList1.Add(new Person { id = 1, firstName = "Ahmet", lastName = "Yılmaz", age = 49 });
            personList1.Add(new Person { id = 2, firstName = "Hülya", lastName = "Kaya", age = 34 });
            personList1.Add(new Person { id = 3, firstName = "Fatma", lastName = "Yıldırım", age = 25 });
            personList1.Add(new Person { id = 4, firstName = "Ece", lastName = "Yıldız", age = 21 });
            personList1.Add(new Student { id = 5, firstName = "Gökhan", lastName = "Demir", age = 41, department = "Computer Engineering", studentID = 100 });
            personList1.Add(new Officer { id = 6, firstName = "Oğuz", lastName = "Çelik", age = 23, salary = 30000 });
            
            List<Person> personList2 = new List<Person>();
            personList2.Add(new Person { id = 1, firstName = "Ahmet", lastName = "Yılmaz", age = 49 });
            personList2.Add(new Officer { id = 7, firstName = "Alper", lastName = "Doğan", age = 25, salary = 4500 });
            personList2.Add(new Person { id = 8, firstName = "Ahmet", lastName = "Yılmaz2", age = 51 });
            personList2.Add(new Person { id = 9, firstName = "Ece", lastName = "Yıldız2", age = 34 });
            personList2.Add(new Student { id = 10, firstName = "Gökhan", lastName = "Demir2", age = 19, department = "Computer Engineering", studentID = 101 });
            personList2.Add(new Student { id = 11, firstName = "Eren", lastName = "Efe", age = 19, department = "Computer Engineering", studentID = 102 });
            personList2.Add(new Student { id = 12, firstName = "Eren", lastName = "Gökdeniz", age = 25, department = "Industrial Engineering", studentID = 103 });

            Console.WriteLine("********************** Except ************************");
            var resultPersonList1 = personList1.Except(personList2); 
            foreach (var person in resultPersonList1)
                person.showInfo();

            Console.WriteLine("********************** Union ************************");
            var resultPersonList2 = personList1.Union(personList2);
            foreach (var person in resultPersonList2)
                person.showInfo();

            Console.WriteLine("********************** Concat ************************");
            var resultPersonList3 = personList1.Concat(personList2);
            foreach (var person in resultPersonList3)
                person.showInfo();

            Console.WriteLine("********************** Intersect ************************");
            var resultPersonList4 = personList1.Intersect(personList2);
            foreach (var person in resultPersonList4)
                person.showInfo();

            Console.WriteLine("********************** Distinct ************************");
            var resultPersonList5 = personList1.Distinct();
            foreach (var person in resultPersonList5)
                person.showInfo();


            Console.Read();
        }
    }

    public class Person : IEquatable<Person>
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }

        //Not: showInfo'yu virtual olarak tanımlamamızın sebebi Student ve Officer classlarında bu metodun override edilmesini (ezilmesini) sağlamaktır.
        public virtual void showInfo()
        {
            Console.WriteLine($"ID : {id}\nFirst Name : {firstName}\nLast Name: {lastName}\nAge:  {age} ");
            Console.WriteLine("--------------------------------------------------------------------------");
        }

        //Dikkat!: Alttaki Equal Metodu IEquatable interface'inden geliyor ve ihtiyaç halinde 2 Person nesnesinin eşitlik durumunu kontrol ediyor. Sadece çağrıldığında çalışır.
        public bool Equals(Person p1)
        {
            if (p1 is null)
                return false;

            return this.firstName == p1.firstName;
        }

        //Alttaki Equals Metodu ise Object classından gelen ve 2 nesnenin eşitlik durumunun kontrol edildiği asıl metottur. Bu metot çalıştığında yapmasını istediğimiz şey kendisine gönderilen obj adındaki parametreyi Person nesnesi haline getirip üstteki Equals metoduna yollaması. Bu sayede üstteki Equals metodunun oluşturacağı değer nihai değer olacaktır.
        public override bool Equals(object obj) => Equals(obj as Person);
        public override int GetHashCode() => (firstName).GetHashCode();


    }
    public class Student : Person
    {
        public string department { get; set; }
        public int studentID { get; set; }
        public override void showInfo()
        {
            Console.WriteLine($"ID : {id}\nFirst Name : {firstName}\nLast Name: {lastName}\nAge:  {age}\nStudentId: {studentID}\nDepartment: {department}");
            Console.WriteLine("--------------------------------------------------------------------------");
        }

    }

    public class Officer : Person
    {
        public int salary { get; set; }
        public override void showInfo()
        {
            Console.WriteLine($"ID : {id}\nFirst Name : {firstName}\nLast Name: {lastName}\nAge:  {age}\nSalary: {salary}");
            Console.WriteLine("--------------------------------------------------------------------------");
        }
    }
}
