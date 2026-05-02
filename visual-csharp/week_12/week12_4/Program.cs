using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week12_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Linq ile Koleksiyonlarda bir koşula bağlı olarak veri var mı kontrolü All, Any, Contains metotları ile yapılır ve bool olarak geriye döner.
             * Kayıt var ise True, yok ise False döner.
             * 
             * Any() -> Liste içerisinde birtane bile var mı? Listedeki en az bir eleman bile o koşula uyuyorsa True hiçbir eleman uymuyorsa False döner. 
             * All() -> Liste içerisinde tümünde var mı? Listedeki tüm elemanlar o koşula uyuyorsa True en az bir tanesi bile uymuyorsa False döner.
             * Contains() -> Koleksiyon, parametre olarak gönderilen değeri içeriyor mu?
             * 
             */


            /********************** Any() ************************/

            /*
             * Any() anahtar sözcüğü koleksiyonda bulunan verilerin olup olmadığını kontrol eder.
             * System.Linq namespace kütüphanesinde bulunur.
             * Any() anahtar sözcüğü ile yazılan lambda sorgusunda koşul ifadeleri yazılabilir. Geriye dönen değerler true yada false dir.
             */
            int[] numbers = { 10, 15, 20, 25, 30, 35, 40 };
            var result1 = numbers.Any(); //Listede herhangi bir eleman varsa sonuç true döner yani length değeri en az 1 ise true döner
            Console.WriteLine(result1);
            var resul2 = numbers.Any(n1 => n1 > 35); // Eğer dizideki bir eleman bile belirtilen koşulu sağlıyorsa yani 35'ten büyükse true değerini döner. Geri kalan değerler'in 35'ten küçük olması veya koşulu sağlamaması önemli değildir. Bir tane elemanın koşulu sağlaması True dönmesi için yeterlidir..
            Console.WriteLine(resul2);

            var result3 = numbers.Any(n1 => n1 == 25); // En az bir tane bile 25 elemanı varsa true döner
            Console.WriteLine(result3);

            var result4= numbers.Any(n1 => n1 == 16 || n1 == 55); // Eğer 16 veya 55 değerlerinden biri varsa True döner
            Console.WriteLine(result4);


            /********************** Contains() ************************/

            /*
             * Contains() anahtar sözcüğü koleksiyonda bulunan verilerin, belirlenen koşula göre olup olmadığını kontrol eder.
             * System.Linq namespace kütüphanesinde bulunur.
             * Dönen değer tipi boolean'dır(true, false). 
             */
            bool result5 = numbers.Contains(15); //Eğer dizide 15 değeri geçiyorsa True geçmiyorsa False döner
            //bool result5 = numbers.Any(n1 => n1 == 15); // yukardaki contains metoduyla any metodu aynı çıktıyı üretir.
            Console.WriteLine(result5);

            /********************** All() ************************/

            /*All() anahtar sözcüğü ile koleksiyonda bulunan tüm veriler içerisinde belirlenen koşullara uyup uymadığını gönder.
             * Geriye dönen değer true ise tüm kayıtlar belirtilen koşula uyuyor anlamına gelir.
             * Eğer dönen değer false ise en az bir kayıt belirtilen koşula uymuyor anlamına gelir.
             
             */
            string[] languages = {  "French", "English", "Russian", "Chinese" };
            bool result6 = languages.All(l => l.Contains("n")); // languages dizisindeki tüm elemanlar n harfini içeriyor mu ?
            bool result7 = languages.All(l => l == "English"); // languages dizisindeki tüm elemanlar English değeri mi?
            bool result8 = languages.All(l => l.EndsWith("se")); // languages dizisindeki tüm elemanlar "se" değeriyle mi bitiyor?
            bool result9 = languages.All(l => l.Length > 5); // dizideki tüm elemanların karakter sayısı 5'ten büyük mü?

            Console.WriteLine(result6);
            Console.WriteLine(result7);
            Console.WriteLine(result8);


            List<string> programming = new List<string> { "C#", "ASP.NET", "PHP" };
            List<Person> personList1 = new List<Person>();
            personList1.Add(new Person { id = 1, firstName = "Ahmet", lastName = "Yılmaz", age = 49 });
            personList1.Add(new Person { id = 2, firstName = "Hülya", lastName = "Kaya", age = 34 });
            personList1.Add(new Person { id = 3, firstName = "Fatma", lastName = "Yıldırım", age = 25 });
            personList1.Add(new Person { id = 4, firstName = "Ece", lastName = "Yıldız", age = 21 });
            personList1.Add(new Student { programmingLanguage = new List<string>() { "C#", "Java", "PHP","Python" }, id = 5, firstName = "Gökhan", lastName = "Demir", age = 41, department = "Computer Engineering", studentID = 100 });
            personList1.Add(new Officer { id = 6, firstName = "Oğuz", lastName = "Çelik", age = 23, salary = 30000 });
            personList1.Add(new Officer { id = 7, firstName = "Alper", lastName = "Doğan", age = 25, salary = 4500 });
            personList1.Add(new Person { id = 8, firstName = "Ahmet", lastName = "Yılmaz2", age = 51 });
            personList1.Add(new Person { id = 9, firstName = "Ece", lastName = "Yıldız2", age = 34 });
            personList1.Add(new Student { programmingLanguage = new List<string>() { "C#", "Java", "PHP" }, id = 10, firstName = "Gökhan", lastName = "Demir2", age = 19, department = "Computer Engineering", studentID = 101 });
            personList1.Add(new Student {programmingLanguage = new List<string>() { "C#", "Go", "Visual Basic" }, id = 11, firstName = "Eren", lastName = "Efe", age = 19, department = "Computer Engineering", studentID = 102});
            
            
            bool result = personList1.All(p1 => p1.age > 18); //Listedeki herkesin yaşı 18'den büyük mü? Eğer herkesin yaşı 18 'den büyükse True, en az bir tane bile 18 'den küçük varsa FALSE döner.

            result = personList1.All(p1 => p1.firstName.StartsWith("F")); //Listedeki tüm kişilerin ismi F ile mi başlıyor?
            result = personList1.Any(p1 => p1.age < 18); // Listede hiç yaşı 18'den küçük olan bir değer var mı? En az bir tane bile varsa True hiç yoksa false döner

            //bölümü Computer Engineering olan hiç öğrenci var mı?
            result = personList1.OfType<Student>().Any(s1 => s1.department == "Computer Engineering");
            //tüm student nesnelerinin bölümü Computer Engineering mi?
            result = personList1.OfType<Student>().All(s1 => s1.department == "Computer Enginnering");

            //Maaşı 5500'den fazla Officer nesnesi var mı hiç?
            result = personList1.OfType<Officer>().Any(o1 => o1.salary > 5500);


            //contains metoduna dikkat etmek gerekiyor. Normalde contains metodu sayısal verileri tutan bir dizide aldığı değeri kontrol eder. Eğer listede veya dizide en az bir kere geçiyorsa true döner. Örneğin 25 değeri listede geçiyorsa true döner. Fakat person sınıfı için durum biraz farklı. Person sınıfında 2 person sınıfından türetilmiş nesnenin birbirine eşit olma şartı firstName değerlerini aynı olmasıdır. Bunu Person sınıfında yazdığımız Equals metodunda belirttik. Orada return ifadesinde sadece firstName değerini kontrol ettik. Eğer firstName'leri aynı geri kalan tüm değerler farklı bile olsa yazılımsal olarak bizim koda göre bu 2 obje birbirinin aynısıdır. Bu yüzden contains metoduna gönderilecek olan parametrede aslında sadece önemli olan şey firstName olacak. Yani contains metoduna göndereceğim person objesinin firstName'i eğer listedeki herhangi bir objenin firstName'i ile aynıysa True döner değilse False döner;
            result = personList1.Contains(new Person { id = 12, firstName = "Gökhan", lastName = "Çelimsiz", age = 44});


            /********************** Select() ************************/

            /*Select() anahtar sözcüğü ile koleksiyonda bulunan elementler kullanılarak yeni bir koleksiyon oluşturulur. */

            //numbers = { 10, 15, 20, 25, 30, 35, 40 };//üstte tanımlanmış zaten 
            var selectResult1 = numbers.Select(n1 => n1 * 2); // numbers dizisindeki her bir elemanı 2 ile çarpıp yeni listeye atar.
            Console.WriteLine("********************** Select() ************************");
            foreach (var s1 in selectResult1)
                Console.WriteLine(s1);

            //yukardaki işlemin aynısını farklı şekilde yapabiliriz.
            var selectResult2 = from n1 in numbers select (n1 * 2);

            string[] countries = { "Turkey", "China", "Germany", "England", "USA" };
            //SelectMany Countries ve numbers dizisindeki elemanlar arasında çaprazlama yapar. Örneğin Turkey'e karşılık numbers dizisindeki her bir sayı için ayrı bir kayıt oluşur. Turkey 10, Turkey 15, Turkey 20 gibi.
            var selectResult3 = countries.SelectMany(c1 => numbers, (c1, n1) => new { country = c1, number = n1 });
            foreach (var s1 in selectResult3)
                Console.WriteLine($"Country : {s1.country} Number: {s1.number}");


            //Student sınıfında boş da olsa programmingLanguage adında ayrı bir list var. Onun üstünden sorgu yazmak istersek;
            //Örneğin tüm öğrencilerin sahip olduğu programmingLanguage listesindeki elemanları alıp tek bir liste haline getirelim.
            //Metod Söz dizimiyle.
            List<string> allProgrammingLanguageInfo = personList1.OfType<Student>()
                                            .SelectMany(std => std.programmingLanguage)
                                            .ToList();

            foreach (var s1 in allProgrammingLanguageInfo)
                Console.WriteLine(s1);

            //Aynı işlemi  sorgu söz dizimiyle yapalım
            IEnumerable<string> allProgrammingLanguageInfo2 = from std in personList1.OfType<Student>()
                                                              from program in std.programmingLanguage
                                                              select program;

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

        public bool Equals(Person p1)
        {
            if (p1 is null)
                return false;

            return this.firstName == p1.firstName;
        }

        public override bool Equals(object obj) => Equals(obj as Person);
        public override int GetHashCode() => (firstName).GetHashCode();


    }
    public class Student : Person
    {
        public string department { get; set; }
        public int studentID { get; set; }
        public List<string> programmingLanguage { get; set; }
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
