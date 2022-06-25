using Microsoft.VisualStudio.TestTools.UnitTesting;
using ttc.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttc.classes.Tests
{
    [TestClass()]
    public class controledaoTests
    {
        [TestMethod()]
        public void verificarPontoTest()
        {
            string coidigo = "22033";
            
            Controlelogin login = new Controlelogin();
            login.acessarponto(coidigo);

            if (login.pont)
            {
                System.Console.WriteLine("A");
            }
            else
            {
                System.Console.WriteLine("B");
            }
            Assert.Fail();
        }
    }
}