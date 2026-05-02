using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

           Açılımı "Language Integrated Query" olan LINQ,Microsoft tarafından geliştirilen ve
           C# 3.0 ile kullanıma sunulan farklı veri kaynaklarından sorgulama yapılbilmesini sağlayan olanak sağlayan bir söz dizimidir.
           LINQ, koleksiyonlar, ADO.Net DataSet, XML , SQL Server, Entity Framework ve diğer veritabanları gibi farklı veri kaynağı türlerinden veri almak için oluşturulmuş bir sorgu söz dizimidir.


           LINQ’da iki farklı söz dizimi mevcuttur.
                 -> Query Syntax-> from ile başlar. where, select gibi ifadelerle devam edebilir.
                 -> Method Syntax (Metot söz dizimi)
           */
            int[] numbers =new int[] {30,21,15,24,1,5,17,3,2,10,23};

            //Amacımız 10'dan büyük olan sayılarıları bulup ekranda göstermek olsun.
            //1-Normalde bunu foreach/for döngüsü içinde teker teker tüm elemanları kontrol ederek yapabiliriz.
            foreach(int n1 in numbers)
            {
                if(n1>10)
                    Console.WriteLine(n1);
            }

            //2-Bu sefer LINQ kullanarak yapalım. Fakat iki farklı şekilde yapabiliriz. İlk olarak QUERY(SORGU) söz dizimiyle kodlayabiliriz.
            var subNumbers1 = from number in numbers
                              where number > 10
                              select number;
            showAllVariables(subNumbers1); //showAllVariables metodu hazır bir metod değil. Biz en altta static olarak tanımladık. Amacı birçok veriyi barındıran yapıların içindeki tüm elemanları göstermektir.

            //3-Aynı işlemi LINQ ile METHOD söz dizimiyle yapalım.
            var subNumbers2 = numbers.Where(x => x > 10);
            showAllVariables(subNumbers2);

            //Görüldüğü üzere 3 adımda da gösterilen değerler hep aynı oldu.
            Console.Read();
        }

        //showAllVariables metodunun amacı primitive tipteki (int,string,boolean vs.)verileri barındıran bir veri kümesinden gelen elemanları alt alta listeleyecek şekilde ekranda göstermektir.
        public static void showAllVariables<T>(IEnumerable<T> values)
        {
            Console.WriteLine("-------------------------------------");
            foreach(var value in values)
                Console.WriteLine(value);
            Console.WriteLine("-------------------------------------");

        }

    }
}
