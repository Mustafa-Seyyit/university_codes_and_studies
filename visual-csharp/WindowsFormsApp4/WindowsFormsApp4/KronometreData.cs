

namespace WindowsFormsApp4
{
    public class KronometreData
    {
        public int salise;
        public int saniye;
        public int dakika;
        public int saat;


        public KronometreData()
        {
            salise = 0;
            saniye = 0;
            dakika = 0;
            saat = 0;
        }


        public override string ToString()
        {
            return string.Format("{0:00}",saat)+":"+dakika+":"+saniye+":"+salise;
        }

    }
}
