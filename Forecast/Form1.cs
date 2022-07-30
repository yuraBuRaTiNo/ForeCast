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

namespace Forecast
{
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

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SQLiteConnection("DataSourse=CitiesForecast.db; Version=3");
                con.Open();
            }
            catch { }
            

        }
    }
}
