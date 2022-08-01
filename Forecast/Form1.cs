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
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using AngleSharp.Dom;
using AngleSharp.Html;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Net;
using System.Text.RegularExpressions;
using System.Net.Http;


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

        public static string HtmlPack(string linkSite)
        {
            HtmlWeb doc = new HtmlWeb();

            HtmlDocument htmlSnipper = doc.Load(linkSite);

            return htmlSnipper.ParsedText;


            
        }



        public class dbController
        {
            private readonly static string filePath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "CitiesForecast.db");

            public static void CreatDB()
            {
                var db = new SQLiteConnection(filePath);

            }

        }


        private void Parser()
        {
            var parser = new HtmlParser();
            var doc = parser.ParseDocument("•	http://www.yr.no/place/france/%c3%8Ele-de-France/Paris/forecast.xml");


        }

        

        private async Task Form1_LoadAsync(object sender, EventArgs e)
        {



            //using (var client = new HttpClient())
            //{
            //    var code = await
            //    client.GetStringAsync("https://www.yr.no/en/forecast/daily-table/1-2760700/Norway/Oslo/Oslo");


            //    var doc = new HtmlDocument();
            //    doc.LoadHtml(code);
            //    //td[@class='TableText']//font
            //    var q =
            //        doc.DocumentNode.SelectNodes(".//div[@class = 'now-hero__next-hour-content']").Last();

            //    RtbxPogoda.Text +=(q.InnerText);
            //}
        }

        private void BtnPogoda_Click(object sender, EventArgs e)
        {

            WebRequest req;
            req = WebRequest.Create(@"https://www.yr.no/en/forecast/daily-table/2-524901/Russia/Moscow/Moscow");

            using (var response = req.GetResponse())
            {
                using (var stream = response.GetResponseStream())

                using (var reader = new StreamReader(stream))
                {
                    string data = reader.ReadToEnd();
                    string town = new Regex(@"<div class=""overlay - panel__backdrop""></div>").Match(data).Groups["town"].Value;
                    string temp = new Regex(@"<span class=""temperature temperature-warm"">").Match(data).Groups["temp"].Value;
                    string weter = new Regex(@"<abbr class=wind_unit>" ).Match(data).Value;
                    RtbxPogoda.Text += (  "\nТемпература воздуха: " + temp + "\nВетер" + weter + "\nГород" + town);
                }
            }
        }

        private void RtbxPogoda_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void CmbChekCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbChekCity.Text == "Москва")
                RtbxPogoda.Text += "Погода в Москве: ";

            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            

        }
    }
}
