using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Pogodynka_w57003
{
    public partial class Form1 : Form
    {
        const string APPID = "5018a726f091f2f233b3af11f9e207c8";
        string cityName = "Rzeszow";
        

        public Form1()
        {
            InitializeComponent();
            getWeather("Hel");
            getForcast("Hel");
        }

        void getWeather(string city)
        {
            
            
        }
        
        void getForcast(string city)
        {
           

        }
        DateTime getDate(double millisecound)
        {

            DateTime day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(millisecound).ToLocalTime();

            return day;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
