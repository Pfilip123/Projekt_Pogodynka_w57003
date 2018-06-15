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
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&APPID={1}&units=metric&cnt=6", city, APPID);
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<WeatherInfo.Root>(json);

                WeatherInfo.Root outPut = result;

                label_city.Text = string.Format("{0}", outPut.name);
                label_country.Text = string.Format("{0}", outPut.sys.country);
                label_temp.Text = string.Format("{0} \u00B0" + "C", outPut.main.temp);
                label_speed.Text = string.Format("{0} km/h", outPut.wind.speed);
                label_preesure.Text = string.Format("{0}", outPut.main.pressure);
            }


        }

        void getForcast(string city)
        {
            int day =23;
            string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?q={0}&units=metric&cnt={1}&APPID={2}", city, day, APPID);
            using (WebClient web = new WebClient())
            {

                var json = web.DownloadString(url);
                var Object = JsonConvert.DeserializeObject<weatherForcast>(json);

                weatherForcast forcast = Object;
                label_day_forcast.Text = string.Format("{0}", forcast.list[6].dt_txt);
                label_conditionals_forcast.Text = string.Format("{0}", forcast.list[6].weather[0].main);
                label_temp_forcast.Text = string.Format("{0} \u00B0" + "C", forcast.list[6].main.temp);
                label_preesure_forcast.Text = string.Format("{0}", forcast.list[6].main.pressure);
                label_wind_forcast.Text = string.Format("{0} km/h", forcast.list[6].wind.speed);

                label_temp_forcast2.Text = string.Format("{0} \u00B0" + "C", forcast.list[14].main.temp);
                label_conditionals_forcast2.Text = string.Format("{0}", forcast.list[14].weather[0].main);
                label_pressure_forcast2.Text = string.Format("{0}", forcast.list[14].main.pressure);
                label_day_forcast2.Text = string.Format("{0}", forcast.list[14].dt_txt);
                label_wind_forcast2.Text = string.Format("{0} km/h", forcast.list[14].wind.speed);

                label_temp_forcast3.Text = string.Format("{0} \u00B0" + "C", forcast.list[22].main.temp);
                label_conditionals_forcast3.Text = string.Format("{0}", forcast.list[22].weather[0].main);
                label_pressure_forcast3.Text = string.Format("{0}", forcast.list[22].main.pressure);
                label_day_forcast3.Text = string.Format("{0}", forcast.list[22].dt_txt);
                label_wind_forcast3.Text = string.Format("{0} km/h", forcast.list[22].wind.speed);

            }

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
