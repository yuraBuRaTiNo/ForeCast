using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using AngleSharp.Html.Parser;


namespace Forecast
{
    public class dbController
        {
        private readonly static string filePath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "CitiesForecast.db");

        public static void CreatDB()
        {
            var db = new SQLiteConnection(filePath);

        }
        
    }


    public partial class Form1 : Form
    {
        private SQLiteConnection con;

        public String CitiesForecast;
        private SQLiteConnection m_dbConn;
        private SQLiteCommand m_sqlCmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Parser()
        {
            var parser = new HtmlParser();
            var doc = parser.ParseDocument("https://www.yr.no/en/forecast/daily-table/2-2988507/France/%C3%8Ele-de-France/Paris/Paris");
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void BtnPogoda_Click(object sender, EventArgs e)
        {
            Parser();

            
        }
    }
}
