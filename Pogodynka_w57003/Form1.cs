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
                pictureBox1.Image = setIcon(outPut.weather[0].icon);
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
                //pogoda w jutrzejszym dniu
                label_day_forcast.Text = string.Format("{0}", forcast.list[5].dt_txt);
                label_conditionals_forcast.Text = string.Format("{0}", forcast.list[5].weather[0].main);
                label_temp_forcast.Text = string.Format("{0} \u00B0" + "C", forcast.list[5].main.temp);
                label_preesure_forcast.Text = string.Format("{0} hPa", forcast.list[5].main.pressure);
                label_wind_forcast.Text = string.Format("{0} km/h", forcast.list[5].wind.speed);
                pictureBox2.Image = setIcon(forcast.list[5].weather[0].icon);

                //pogoda w pojutrzejszym dniu
                label_temp_forcast2.Text = string.Format("{0} \u00B0" + "C", forcast.list[13].main.temp);
                label_conditionals_forcast2.Text = string.Format("{0}", forcast.list[13].weather[0].main);
                label_pressure_forcast2.Text = string.Format("{0} hPa", forcast.list[13].main.pressure);
                label_day_forcast2.Text = string.Format("{0}", forcast.list[13].dt_txt);
                label_wind_forcast2.Text = string.Format("{0} km/h", forcast.list[13].wind.speed);
                pictureBox4.Image = setIcon(forcast.list[5].weather[0].icon);

                //pogoda w popojutrzejszym dniu
                label_temp_forcast3.Text = string.Format("{0} \u00B0" + "C", forcast.list[21].main.temp);
                label_conditionals_forcast3.Text = string.Format("{0}", forcast.list[21].weather[0].main);
                label_pressure_forcast3.Text = string.Format("{0} hPa", forcast.list[21].main.pressure);
                label_day_forcast3.Text = string.Format("{0}", forcast.list[21].dt_txt);
                label_wind_forcast3.Text = string.Format("{0} km/h", forcast.list[21].wind.speed);
                pictureBox5.Image = setIcon(forcast.list[21].weather[0].icon);
            }

        }
       
        Image setIcon(string iconID)
        {

            string url = string.Format("http://openweathermap.org/img/w/{0}.png", iconID);
            var request = WebRequest.Create(url);
            using (var response = request.GetResponse())
            using (var weatherIcon = response.GetResponseStream())
            {
                Image weatherImg = Bitmap.FromStream(weatherIcon);
                return weatherImg;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text !="")
            {
                getWeather(textBox1.Text);
                getForcast(textBox1.Text);

            }
        }
    }
}
