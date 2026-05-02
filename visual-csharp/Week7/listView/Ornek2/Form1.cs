using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            //using ifadesi basitçe şu şekilde çalışır: using ile bir nesne/değişken tanımlandığında sadece o using blok kapsamında erişilebilir.
            //using blok bittiğinde o nesne otomatik hafızadam silinir. Bu sayede de kod güvenliği sağlanmış olur.
            //---------------
            //Aşağıdaki kodda OpenFileDialog nesnesi açıyoruz. Filter kısmına hangi türden dosyaların görüntülenmesini gerektiğini belirtiyoruz.
            //*.* diyerek adı ve uzantısı fark etmeksizin tüm dosyaların görüntülenmesini istediğimizi belirtiyoruz.
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All files|*.*", ValidateNames = true, Multiselect = true })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                    foreach (string f in ofd.FileNames)
                    {
                        //f değerinde ilgili dosyanın dizin adresini verir.(path)
                        FileInfo fi = new FileInfo(f);//dosyanın adı uzantısı gibi daha detaylı bilgiler almak için ilgili dosyanın path'ini FileInfo
                        //türünden bir nesne oluşturmak içinparametre olarak yolluyoruz.
                        ListViewItem item = new ListViewItem(fi.Name);
                        item.SubItems.Add(fi.FullName);
                        //item'ı ListView'e ekleme
                        listView1.Items.Add(item);
                    }
            }
            //using blok bittikten sonra ofd nesnesi otomatik olarak bellekden silineceği için artık erişilemez.
        }
    }
}
