using MyBank.Portal.Infraestrutura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank.Portal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var prefixos = new string[] {"http://localhost:5000/"};
            var webApplication = new WebApplication(prefixos);
            webApplication.Start();
        }
    }
}
