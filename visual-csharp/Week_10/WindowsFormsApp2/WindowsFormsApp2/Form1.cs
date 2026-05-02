using MindFusion.Charting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Drawing;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            createDatabase();
            initializeChart();
            customizeChart();
        }
        static string dbName = "sales.db";
        static string tableNameSummerSales = "summer_sales";
        static Func<SQLiteConnection> getConnection = () => new SQLiteConnection($"Data Source = {dbName}");
        public void createDatabase()
        {
            if (!File.Exists(dbName))
            {
                SQLiteConnection.CreateFile(dbName);
                using (SQLiteConnection con = getConnection())
                {
                    con.Open();
                    SQLiteCommand cmd = con.CreateCommand();
                    cmd.CommandText = $"create table if not exists {tableNameSummerSales} (id integer primary key, year integer, amount decimal)";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Veritabanı Oluşturuldu");
                }
            }
        }


        public void initializeChart()
        {
            lineChart1.Series.Clear();
            using (SQLiteConnection con = getConnection())
            {

                con.Open();
                SQLiteCommand cmd = con.CreateCommand();
                cmd.CommandText = $"select * from {tableNameSummerSales} order by year";
                SQLiteDataReader dataReader = cmd.ExecuteReader();
                
                List<double> amountData = new List<double>();
                List<string> yearData = new List<string>();
                while (dataReader.Read())
                {
                    double amount = double.Parse(dataReader["amount"].ToString());
                    int year = int.Parse(dataReader["year"].ToString());
                    amountData.Add(amount);
                    yearData.Add(year.ToString());
                }

                SimpleSeries series1 = new SimpleSeries(amountData, yearData);
                series1.Title = "Summer Collection";
                lineChart1.Series.Add(series1);

                dataReader.Close();
                con.Close();
            }
        }
        
        
        public void customizeChart()
        {
            lineChart1.YAxis.Interval = 50;
            lineChart1.YAxis.MaxValue = 500;
            lineChart1.YAxis.MinValue = 0;
            lineChart1.YAxis.Title = "Amount";


            lineChart1.XAxis.Interval = 1;
            lineChart1.XAxis.MaxValue = 7;
            lineChart1.XAxis.MinValue = -1;
            lineChart1.XAxis.Title = "Year";

            lineChart1.ShowXCoordinates = false;
            lineChart1.ShowLegendTitle = false;

            lineChart1.Theme.DataLabelsFontSize = 12;
            
            
            lineChart1.Plot.SeriesStyle = new UniformSeriesStyle(
                new MindFusion.Drawing.SolidBrush(Color.Yellow),
                new MindFusion.Drawing.SolidBrush(Color.Green),
                3,
                System.Drawing.Drawing2D.DashStyle.Solid
                );

            //Grid
            lineChart1.GridType = GridType.Horizontal;
            lineChart1.Theme.GridLineColor = Color.FromArgb(200, 200, 200);
            lineChart1.Theme.GridColor1 = Color.FromArgb(245, 245, 245);
            lineChart1.Theme.GridColor2 = Color.FromArgb(250, 250, 250);
            lineChart1.Title = "Sales For Our Clothing Brand";
            lineChart1.TitleMargin = new Margins(0, 5, 0, 10);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FormAddSales formAddSales = new FormAddSales();
            formAddSales.AddNewSaleEvent += addNewSale;
            formAddSales.ShowDialog();
        }

        public void addNewSale(int year,double amount)
        {
            using (SQLiteConnection con = getConnection()) {
                con.Open();

                SQLiteCommand cmd = con.CreateCommand();
                cmd.CommandText = $"select * from {tableNameSummerSales} where year=@year";
                cmd.Parameters.AddWithValue("@year",year);
                SQLiteDataReader dataReader = cmd.ExecuteReader();
                SQLiteCommand cmd2 = con.CreateCommand();
                if (dataReader.HasRows) {
                    //UPDATE
                    dataReader.Read();
                    double amountData = double.Parse(dataReader["amount"].ToString());
                    double newAmountData = amountData + amount;

                    cmd2.CommandText = $"UPDATE {tableNameSummerSales} SET amount=@amount WHERE year=@year";
                    cmd2.Parameters.AddWithValue("@year",year);
                    cmd2.Parameters.AddWithValue("@amount",newAmountData);
                    cmd2.ExecuteNonQuery();
                }
                else
                {
                    //INSERT
                    
                    cmd2.CommandText = $"insert into {tableNameSummerSales}(year,amount) values(@year,@amount)";
                    cmd2.Parameters.AddWithValue("@year",year);
                    cmd2.Parameters.AddWithValue("@amount",amount);
                    cmd2.ExecuteNonQuery();

                }
                dataReader.Close();
                con.Close();
                initializeChart();
            }
        }
    }
}
