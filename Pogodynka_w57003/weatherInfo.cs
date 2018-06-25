using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pogodynka_w57003
{
    /// <summary>
    /// Klasa dla pogody aktualnej
    /// </summary>
    class WeatherInfo
    {
        /// <summary>
        /// klasa odpowiedzialna za pozycję geograficzną miejscowości
        /// </summary>
        public class coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }

        /// <summary>
        /// klasa odpowiedzialalna za pobranie ID miejscowości, wyświetlaniu stanu ogólnego
        /// pogody, oraz ikony
        /// </summary>
        public class weather
        {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }
        /// <summary>
        /// klasa odpowiedzialalna za pobraine informacji o temepraturze, ciśnieniu, oraz wilgotności
        /// </summary>
        public class main
        {
            public double temp { get; set; }
            public double pressure { get; set; }
            public double humidity { get; set; }
           
        }
        /// <summary>
        /// klasa odpowiedzialalna za pobraine informacji o sile wiatru
        /// </summary>
        public class wind
        {
            public double speed { get; set; }
        }
        /// <summary>
        /// klasa odpowiedzialalna za pobraine informacji o inicjałów Panśtwa do którego należy miejscowość
        /// </summary>
        public class sys
        {
            public string country { get; set; }
        }
        /// <summary>
        /// klasa definiująca zmienne do poszczeglnych typów danych
        /// </summary>
        public class Root
        {
            public string name { get; set; }
            public sys sys { get; set; }
            public double dt { get; set; }
            public wind wind { get; set; }
            public main main { get; set; }
            public List<weather> weather { get; set; }
            public coord coordinate { get; set; }         
        }
    }
}
