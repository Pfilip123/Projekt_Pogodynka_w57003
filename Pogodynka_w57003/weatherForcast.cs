﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Klasa dla prognozy pogody
/// </summary>
namespace Pogodynka_w57003
{
    class weatherForcast
    {
        public city city { get; set; }
        public List<list> list { get; set; }
    }
    public class main
    {
        public double temp { get; set; }
        public double pressure { get; set; }
        public double humidity { get; set; }
        

    }
    public class weather
    {
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }

    }
    public class wind
    {
        public double speed { get; set; }
    }
    public class city
    {
        public string name { get; set; }
    }
    public class list
    {
        public string dt_txt { get; set; }
        public wind wind { get; set; }
        public main main { get; set; }
        public List<weather> weather { get; set; }

    }
}
