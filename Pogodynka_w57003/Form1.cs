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

/// <summary>
/// Głowna funkcjonalność progamu
/// </summary>
namespace Pogodynka_w57003
{

    public partial class panel_glony : Form
    {
        /// <summary>
        /// Klucz API pobrane z witryny openweather.org
        /// </summary>
        const string APPID = "5018a726f091f2f233b3af11f9e207c8";

        /// <summary>
        /// Domyślne miasto wczytywane przy starcie programu
        /// </summary>
        public panel_glony()
        {
            InitializeComponent();
            getWeather("Rzeszow");
            getForcast("Rzeszow");
           
        }
       
        /// <summary>
        /// Funkcjonalność pobrania danych z API dla pogody aktualnej
        /// </summary>
        /// <param name="city"></param>
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
                label_preesure.Text = string.Format("{0} hPa", outPut.main.pressure);
                label9.Text = string.Format("{0}", outPut.weather[0].description);
                pictureBox1.Image = setIcon(outPut.weather[0].icon);
                
                 
            }


        }
        /// <summary>
        /// Funkcjonalność pobrania danych z API dla prognozy pogody
        /// </summary>
        /// <param name="city"></param>
        void getForcast(string city)
        {
            int day = 23;
            string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?q={0}&units=metric&cnt={1}&APPID={2}", city, day, APPID);
            using (WebClient web = new WebClient())
            {

                var json = web.DownloadString(url);
                var Object = JsonConvert.DeserializeObject<weatherForcast>(json);

                weatherForcast forcast = Object;
                ///pogoda w jutrzejszym dniu
                label_day_forcast.Text = string.Format("{0}", forcast.list[5].dt_txt);
                label_conditionals_forcast.Text = string.Format("{0}", forcast.list[5].weather[0].main);
                label_temp_forcast.Text = string.Format("{0} \u00B0" + "C", forcast.list[5].main.temp);
                preesure_forecast.Text = string.Format("{0} hPa", forcast.list[5].main.pressure);
                label_wind_forcast.Text = string.Format("{0} km/h", forcast.list[5].wind.speed);
                pictureBox2.Image = setIcon(forcast.list[5].weather[0].icon);

                ///pogoda w pojutrzejszym dniu
                label_temp_forcast2.Text = string.Format("{0} \u00B0" + "C", forcast.list[13].main.temp);
                label_conditionals_forcast2.Text = string.Format("{0}", forcast.list[13].weather[0].main);
                label_pressure_forcast2.Text = string.Format("{0} hPa", forcast.list[13].main.pressure);
                label_day_forcast2.Text = string.Format("{0}", forcast.list[13].dt_txt);
                label_wind_forcast2.Text = string.Format("{0} km/h", forcast.list[13].wind.speed);
                pictureBox4.Image = setIcon(forcast.list[13].weather[0].icon);

                ///pogoda w popojutrzejszym dniu
                
                label_temp_forcast3.Text = string.Format("{0} \u00B0" + "C", forcast.list[21].main.temp);
                label_conditionals_forcast3.Text = string.Format("{0}", forcast.list[21].weather[0].main);
                label_pressure_forcast3.Text = string.Format("{0} hPa", forcast.list[21].main.pressure);
                label_day_forcast3.Text = string.Format("{0}", forcast.list[21].dt_txt);
                label_wind_forcast3.Text = string.Format("{0} km/h", forcast.list[21].wind.speed);
                pictureBox5.Image = setIcon(forcast.list[21].weather[0].icon);
            }

        }

        /// <summary>
        /// Klasa pobierająca obrazek przedstawiający stan nieba
        /// </summary>
        /// <param name="iconID"></param>
        /// <returns></returns>
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


   

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            panel_wyszukiwarka.Visible = false;
            if (panel_dock.Width == 236 & panel_dock.Height == 637)
            {
                panel_dock.Width = 50;
                panel_dock.Height = 637;
                strona_glowna.Visible = false;
                Zamknij.Visible = false;

                Mapy_experta.Visible = false;
                Wyszukiwarka.Visible = false;
            }
        }

     /// <summary>
     /// Klasa chowająca kontrolki w docku
     /// </summary>
        void schowajelementydocka()
        {
            strona_glowna.Visible = false;
            Zamknij.Visible = false;
            Mapy_experta.Visible = false;
            Wyszukiwarka.Visible = false;
        }

        /// <summary>
        /// Klasa Pokazjuąca kontrolki w docku
        /// </summary>
        void pokazelementydocka()
        {
            Wyszukiwarka.Visible = true;
            strona_glowna.Visible = true;
            Zamknij.Visible = true;
            Mapy_experta.Visible = true;
        }

        /// <summary>
        /// Funkcjonalnośc przyciska menu wysuwający i chowający banner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (panel_dock.Width == 236 & panel_dock.Height == 637)
            {
                panel_dock.Width = 50;
                panel_dock.Height = 637;
                schowajelementydocka();
            }
            else
            {
                panel_dock.Width = 236;
                panel_dock.Height = 637;
                pokazelementydocka();
            }
        }

        /// <summary>
        /// Funckjonalnośc kontrolki Strona głowna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void strona_glowna_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel_wyszukiwarka.Visible = false;
            panel_mapyexperta.Visible = false;
            schowajelementydocka();
            panel_dock.Width = 50;
            panel_dock.Height = 637;
        }
        /// <summary>
        /// Funckjonalnośc kontrolki Mapy eksperta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mapy_experta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            schowajelementydocka();
            panel_mapyexperta.Visible = true;
            panel_dock.Width = 50;
            panel_dock.Height = 637;
            panel_wyszukiwarka.Visible = false;
        }
        /// <summary>
        /// Funckjonalnośc kontrolki wyszukiwarka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Wyszukiwarka_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel_wyszukiwarka.Visible = true;
            panel_mapyexperta.Visible = false;

            
        }

        /// <summary>
        /// Funkcjonalnoś przyciska zamknij
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Zamknij_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Na pewno chcesz wyjść?", "Zamykanie"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {

            }
        }


        /// <summary>
        /// Funckjonalnośc kontrolki estofex w panelu mapy eksperta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void estofex_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string estofex = "http://www.estofex.org/forecasts/tempmap/.png";
            WebRequest request = WebRequest.Create(estofex);
            using (var response = request.GetResponse())
            {
                using (var str = response.GetResponseStream())
                    pictureUrl.Image = Bitmap.FromStream(str);
            }
            hidecityum();
        }

        /// <summary>
        /// Funckjonalnośc kontrolki mapy um w panelu mapy eksperta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void um_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showcityum();

        }
       

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Funkcja pkazująca mista po wybraniu kontrolki Model UM
        /// </summary>
        void showcityum()
        {
            bialystok.Visible = true;
            bydgoszcz.Visible = true;
            kielce.Visible = true;
            gdansk.Visible = true;
            gorzow_wklp.Visible = true;
            katowice.Visible = true;
            kielce.Visible = true;
            kroakow.Visible = true;
            lublin.Visible = true;
            lodz.Visible = true;
            opole.Visible = true;
            poznan.Visible = true;
            rzeszow.Visible = true;
            szczecin.Visible = true;
            torun.Visible = true;
            warszawa.Visible = true;
            wroclaw.Visible = true;
            zielona_gora.Visible = true;
            kiellce.Visible = true;
            legenda.Visible = true;
            naglowek.Visible = true;
        }

        /// <summary>
        /// Funkcja ukeywająca mista po wybraniu kontrolki Model UM
        /// </summary>
        void hidecityum()
        {
            bialystok.Visible = false;
            bydgoszcz.Visible = false;
            kielce.Visible = false;
            gdansk.Visible = false;
            gorzow_wklp.Visible = false;
            katowice.Visible = false;
            kielce.Visible = false;
            kroakow.Visible = false;
            lublin.Visible = false;
            lodz.Visible = false;
            opole.Visible = false;
            poznan.Visible = false;
            rzeszow.Visible = false;
            szczecin.Visible = false;
            torun.Visible = false;
            warszawa.Visible = false;
            wroclaw.Visible = false;
            zielona_gora.Visible = false;
            kiellce.Visible = false;
            legenda.Visible = false;
            naglowek.Visible = false;
        }

        /// <summary>
        /// Funkcja implmentująca szerokośc i długośc geograficzną okreslonego miasta
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
         void setModelm(int row, int col)
        {
            string city = string.Format
           ("http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&fdate=2018061706&row={0}&col={1}&lang=pl",
                row,col);
            WebRequest request = WebRequest.Create(city);
            using (var response = request.GetResponse())
            {
                using (var str = response.GetResponseStream())
                    pictureUrl.Image = Bitmap.FromStream(str);
            }
        }

        /// <summary>
        /// metody przypisujące wspólrzędne po kliknięciu na miasta
        
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bliaystok_Click_1(object sender, EventArgs e)
        {
            setModelm(379, 285);
            naglowek.Text = "Białystok";
        }

        private void bydgoszcz_Click_1(object sender, EventArgs e)
        {
            naglowek.Text = "Bydgoszcz";
            setModelm(381,199);
        }

        private void gdansk_Click_1(object sender, EventArgs e)
        {
            setModelm(346, 210);
            naglowek.Text = "Gdańsk";
        }

        private void gorzow_wlkp_Click_1(object sender, EventArgs e)
        {
            setModelm(390, 152);
            naglowek.Text = "Gorzów Wielkopolski";
        }

        private void katowice_Click_1(object sender, EventArgs e)
        {
            setModelm(461, 215);
            naglowek.Text = "Katowice";
        }

        private void kielce_Click_1(object sender, EventArgs e)
        {
            setModelm(443, 244);
            naglowek.Text = "Kielce";
        }

        private void krakow_Click_1(object sender, EventArgs e)
        {
            setModelm(443, 215);
            naglowek.Text = "Kraków";
        }

        private void lublin_Click_1(object sender, EventArgs e)
        {
            setModelm(432, 277);
            naglowek.Text = "Lublin";
        }

        private void lodz_Click_1(object sender, EventArgs e)
        {
            setModelm(418, 223);
            naglowek.Text = "Łódź";
        }

        private void panel_mapyexperta_Paint(object sender, PaintEventArgs e)
        {
            
        }
        
        private void opole_Click_1(object sender, EventArgs e)
               {
            naglowek.Text = "Opole";
            setModelm(449,196);
               }

               private void poznan_Click_1(object sender, EventArgs e)
               {
            naglowek.Text = "Poznań";
            setModelm(400, 180);
        }

               private void rzeszow_Click_1(object sender, EventArgs e)
               {
            naglowek.Text = "Rzeszów";
            setModelm(465, 269);
        }

               private void szczecin_Click_1(object sender, EventArgs e)
               {
            naglowek.Text = "Szczecin";
            setModelm(370, 142);
        }

             

               private void torun_Click_1(object sender, EventArgs e)
               {
                 
            setModelm(383, 209);
            naglowek.Text = "Toruń";
        }

               private void warszawa_Click_1(object sender, EventArgs e)
               {
            naglowek.Text = "Warszawa";
            setModelm(406, 250);
        }

               private void wroclaw_Click_1(object sender, EventArgs e)
               {
            naglowek.Text = "Wrocław";
            setModelm(436, 181);
        }


               private void zielona_gora_Click_1(object sender, EventArgs e)
               {
            naglowek.Text = "Zielona Góra";
            setModelm(412, 155);

        }
        ///</summary>
        
        /// <summary>
        /// funkcjonalnośc kontrolk legenda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Legenda_Click_1(object sender, EventArgs e)
               {
                   string city = "http://www.meteo.pl/um/metco/leg_um_pl_cbase_256.png";
                   WebRequest request = WebRequest.Create(city);
                   using (var response = request.GetResponse())
                   {

                       using (var str = response.GetResponseStream())
                           pictureUrl.Image = Bitmap.FromStream(str);
                   }
            naglowek.Text = "Legenda";
        }

        /// <summary>
        /// Funkcjonalnosc przycisku "Wyszukaj" ,oraz metody pobierające tekst z pola tekstowego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_search_Click_1(object sender, EventArgs e)
        {
            panel_wyszukiwarka.Visible = false;
            if (textBox1.Text != "")
            {
                getWeather(textBox1.Text);
                getForcast(textBox1.Text);
                panel_wyszukiwarka.Visible = false;
                panel_mapyexperta.Visible = false;
                panel_dock.Width = 50;
                panel_dock.Height = 637;
                schowajelementydocka();
            }
        }

        /// <summary>
        /// Funckjonalnośc kontrolki Mapa burzowa w panelu mapy eksperta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mapa_burzowa_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Lowcyburz = "http://burza.umcs.lublin.pl/lm/blitzortung.php?map=3&bo_t=25487321";
            WebRequest request = WebRequest.Create(Lowcyburz);
            using (var response = request.GetResponse())
            {
                using (var str = response.GetResponseStream())
                    pictureUrl.Image = Bitmap.FromStream(str);
            }
            hidecityum();
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }



        private void pictureUrl_Click(object sender, EventArgs e)
        {

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

    }
}
