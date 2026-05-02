using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Konular
            //1-TypeOF
            //2-OrderBy- ThenBy
            //3-Reverse
            //4-IEnumerable - IQueryable
            //5-Except, Union, Concat, Intersect, Distinct


            List<Person> personList = new List<Person>();
            personList.Add(new Person{id=1,firstName="Ahmet",lastName="Yılmaz",age=49 });
            personList.Add(new Person{id=2,firstName="Hülya",lastName="Kaya",age=34 });
            personList.Add(new Person{id=3,firstName="Fatma",lastName= "Yıldırım", age=25 });
            personList.Add(new Person{id=4,firstName= "Ece", lastName= "Yıldız", age=21 });
            personList.Add(new Student{id=5,firstName="Gökhan",lastName= "Demir", age=41,department="Computer Engineering", studentID=100});
            personList.Add(new Officer{id=6,firstName="Oğuz",lastName= "Çelik", age=23,salary=30000 });
            personList.Add(new Officer{id=7,firstName= "Alper", lastName= "Doğan", age= 25, salary =4500 });

            //yaşı 25'ten büyük olan elemanları bulalım. 
            var subPersons1 = from p1 in personList
                              where p1.age > 25
                              select p1;
            //veya 2. yöntem
            var subPersons2 = personList.Where(p1 => p1.age > 25);

            foreach (var temp in subPersons1)
                temp.showInfo();


            /*  OfType KULLANIMI
            /*
              * OfType() anahtar sözcüğü özel tipler ile dolu olan koleksiyondaki verilerin belirtilen tipte listelenmesi sağlar.
              * OfType anahtar sözcüğü ile dizi içerisinde bulunan object değerlerden sadece belirtilen tipteki değerleri alıp yeni koleksiyonda oluşturur.
              * Dizide bulunan string, int ve Decimal türündeki verilerden sadece int türündeki verilerin yeni bir koleksiyon olarak verilmesi örneği aşağıdaki gibidir.
            */

            object[] myValues = { "Ahmet", "Selin", false, 1, 20, 10.3 };

            var onlyIntValues = myValues.OfType<int>(); //hangi tipten verileri filtrelemek istiyorsak OfType<filtreTip> şeklinde kullanabiliriz.
            showAllVariables(onlyIntValues);


            //personList listesinde hem Person, hem Student hem de Officer sınıfından türetilmiş nesneler bulunmaktadır. Örneğin sadece Student nesnelerini alalım.
            //1. Yöntem
            var onlyStudents1 = personList.OfType<Student>();
            //2. Yöntem
            var onlyStudents2 = from person in personList.OfType<Student>()
                                select person;

            foreach (var temp in onlyStudents1)
                temp.showInfo();


            //*********** SIRALAMA - OrderBy() ******************************************
            //Kişileri yaşlarına göre küçükten büyüğe (ascending) sıralayalım. Eğer kişilerin yaşları aynıysa firstName değerlerine göre Z'den A'ya (descending) sıralayalım
            var orderedList1 = from p1 in personList
                               orderby p1.age ascending,
                               p1.firstName descending 
                               select p1;
            //orderby'dan sonra eğer bir değer için ascending değeri kullanılacaksa bunu ekstradan belirtmesek de olur. Çünkü varsayılan sıralama tipi zaten ascending şeklindedir. Bu yüzden yukardaki kod satırında p1.age ascending, yerine p1.age, yazmamız aynı sonucu verir. Aşağıda olduğu gibi..
            //var orderedList1 = from p1 in personList orderby p1.age, p1.firstName descending select p1;
            Console.WriteLine("********************** Ordered By Age and FirstName ************************");
            foreach (var temp in orderedList1)
                temp.showInfo();

            //Mesela firstName değerinin karakter sayısı açısından uzunluğuna  göre küçükten büyüğe doğru sıralayalım. Eğer aynı sayıda karakter içeriyorlarsa kendi içlerinde yaşlarını küçükten büyüğe sıralayalım.
            Console.WriteLine("********************** Ordered By FirstName Length and Age ************************");
            var orderedList2 = personList
                .OrderBy(p1 => p1.firstName.Length)//Önce firstName'deki karakter sayısına göre sırala
                .ThenBy(p2=>p2.age); //Uygulanacak ikinci sıralama için thenBy kullanılabilir. Eğer karakter sayıları aynıysa age değerine göre küçükten büyüğe sırala

            //OrderBy ve ThenBy'a gönderilen p1,p2 gibi değişkenlerin/nesnelerin isimlendirmesinin özel bir anlamı yoktur. Her ikisi de p1 olabilirken farklı isimlere de sahip olabilirler. Birbirlerinden ayrı çalıştıkları için aralarında bir bağlantı bulunmamaktadır.

            foreach (var temp in orderedList2)
                temp.showInfo();

            //1-Hem OrderBy hem de ThenBy metodları belirtilen ifadeye göre ascending yani küçükten büyüğe veya A-Z'ye sıralar.
            //2-Fakat eğer büyükten küçüğe veya Z-A'ya sıralamak istersek bu metodların OrderByDescending ve ThenByDescending versiyonlarını kullanabiliriz.
            //3-Örneğin yukarda yapılanın tam tersi mantıkla firstName karakter sayısına göre Büyükten Küçüğe, eğer aynılarsa Age değerine göre Büyükten Küçüğe sıralayalım
            var orderedList3 = personList
                                        .OrderByDescending(p1 => p1.firstName.Length)
                                        .ThenByDescending(p1 => p1.age);
            foreach(var temp in orderedList3)
                    temp.showInfo();


            //personList içindeki Officer nesnelerini  salary(maaş) değerine göre küçükten büyüğe doğru sıralayalım
            var orderedList4 = personList
                .OfType<Officer>() // Önce tüm listeden sadece Officer tipteki verileri çekiyoruz.
                .OrderBy(o1 => o1.salary); // Sonra salary değerine göre küçükten büyüğe sıralıyoruz.
            Console.WriteLine("********************** Ordered By Salary ************************");
            foreach (var temp in orderedList4)
                temp.showInfo();


            //*********** REVERSE() ******************************************

            //REVERSE : Herhangi bir LINQ sorgusu sonucu dönecek olan değerin ters döndürülmesini sağlar.
            //Örneğin aşağıdki listede  kişileri id değerlerine göre küçükten büyüğe getirir.
            var orderedList5 = from p1 in personList
                               orderby p1.id select p1;
            
            //Eğer döndürülecek olan değeri parantez içine alıp tümü için Reverse metodunu çağıracak olursak kayıtlar tersten sıralanıp döndürülür. Yani ID değeri en büyük olan başa geçer, en küçük olan da sona geçer
            var orderedList6 = (from p1 in personList
                                orderby p1.id
                                select p1)
                                .Reverse();

            //Method Yöntemi
            var orderedList7 = personList.OrderBy(p1 => p1.id).Reverse();
            Console.WriteLine("********************** With Reverse ************************");
            foreach (var temp in orderedList6)
                temp.showInfo();



            //**************  4-IEnumerable - IQueryable *****************************
            /*
           * IEnumerable - IQueryable : Aslında yaptıkları şey şimdiye kadar oluşturduğumuz sorgulardan görünüşte çok farklı şeyler yapmazlar. 
           * İlk bakışta bize aynı gibi görünseler de IEnumerable ve IQueryable arasında büyük farklar vardır.
           * IEnumerable ve IQueryable arasındaki en büyük fark IEnumerable tipinin datayı önce belleğe atıp ardından koşulları bellekteki dataya uygulamasıdır.
           * IQueryable tipinde ise sorgular direkt olarak VERİTABANINDA yapılır.
           * Yani IEnumerable ile tüm kayıtları bir kere belleğe atarız. IQueryable'da ise yalnızca istediğimiz kayıtları veritabanından çekip işlem yaparız.
           * Bir veritabanı veya uzak veri kaynakları üzerinde işlem yapacaksak IQueryable en iyi çözümdür.
           * IEnumerable hafızadaki koleksiyonlar için idealdir.
            *IQueryable hafıza dışındaki (veritabanı, servis vs.) koleksiyonlar için idealdir.
            *IQueryable fazladan CreateQuery ve Execute yöntemlerine sahiptir. Bu şekilde doğrudan özel sorguları yazıp çalıştırabiliriz. IEnumerable bunu desteklemez
            **IQueryable ve IEnumerable'nin her ikisi de ertelenmiş çalıştırma (Deffered Execution) kullanır. Ancak IQueryable  ertelenmiş çalıştırma işlemine benzer bir işlem olan tembel yükleme (Lazy Loading) kullanır. Yani veritabanından kayıtları siz  kullanmaya başlayana kadar çağırmaz veya getirmez. Bu da sayfalama gibi bir çok işlemde çok faydalıdır.
            * Veritabanı üzerinde işlem yapıldığında aralarındaki fark daha net anlaşılır.
             */
            List<int> myNumbers = new List<int>() { 10, 15, 20, 25, 30, 40, 45, 50 };
            IEnumerable<int> query1 = from num in myNumbers where num > 10 select num;

            IQueryable<int> query2 = from num in myNumbers.AsQueryable() where num > 10 select num;


            Console.Read();
        }



        public static void showAllVariables<T>(IEnumerable<T> values)
        {
            Console.WriteLine("-------------------------------------");
            foreach (var value in values)
                Console.WriteLine(value);
            Console.WriteLine("-------------------------------------");

        }
    }


    public class Person
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

    }
    public class Student: Person
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
