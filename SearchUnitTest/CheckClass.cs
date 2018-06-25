using Pogodynka_w57003;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace pogodynka.Test
{
    [TestClass]
    public class CheckClass
    {    
        [TestMethod]
        public void IsNull()
        {  
           var c = new Pogodynka_w57003.city();
            string result;
            result = c.name;
            Assert.AreEqual(null,result);

            var t = new Pogodynka_w57003.wind();
            double result2;
            result2 = t.speed;
            Assert.AreEqual(0, result2);
        }
    }
}




