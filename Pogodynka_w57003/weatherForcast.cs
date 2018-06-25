using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Klasa dla prognozy pogody
/// </summary>
namespace Pogodynka_w57003
{
    /// <summary>
    /// klasa dla prognozy pogody
    /// </summary>
    class weatherForcast
    {
        public city city  { get; set; }
        public List<list> list { get; set; }
    }
    /// <summary>
    /// klasa odpowiedzialna za pobranie informacji o temperaturze, ciśnieniu, oraz wilgotności powietrza
    /// </summary>
    public class main
    {
        public double temp { get; set; }
        public double pressure { get; set; }
        public double humidity { get; set; }   
    }
    /// <summary>
    /// klasa odpowiedzialna za pobranie informacji o stanie nieba, intensywności zajwiska, oraz ikony
    /// </summary>
    public class weather
    {
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    /// <summary>
    /// klasa odpowiedzialna za pobranie informacji o sile wiatru
    /// </summary>
    public class wind
    {
        public double speed { get; set; }
    }

    /// <summary>
    /// klasa odpowiedzialna za pobranie informacji o nazwie miejscowości
    /// </summary>
    public class city
    {
        public string name { get; set; }
    }
    /// <summary>
    /// klasa definiująca zmienne do poszczeglnych typów danych
    /// </summary>
    public class list
    {
        public string dt_txt { get; set; }
        public wind wind { get; set; }
        public main main { get; set; }
        public List<weather> weather { get; set; }
    }
}
