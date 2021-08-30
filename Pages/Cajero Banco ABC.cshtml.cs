using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Practica_III.Pages
{
    public class Cajero_Banco_ABCModel : PageModel
    {
        public List<string> Bancos = new List<string>()
        {
            "ABC", "RESERVAS"
        };
        public int Billete_1000 { get; set; } = 9;
        public int Billete_500 { get; set; } = 19;
        public int Billete_100 { get; set; } = 99;
        public int Monto_Disponible { get; set; }
        public string Banco { get; set; }
        public int MontoRetiro { get; set; }
          
        
        public void OnGet()
        {

        }
        public void Transacion(string Banco, int MontoRetiro)
        {
            
            int Monto_Res = MontoRetiro;

            if (MontoRetiro > 1000)
            {
                Monto_Res = MontoRetiro / 1000;
                MontoRetiro = MontoRetiro-(Monto_Res * 1000) ;
            }

            if (MontoRetiro>500 && MontoRetiro < 1000)
            {
                Monto_Res = MontoRetiro / 500;
                MontoRetiro = MontoRetiro- (Monto_Res * 500);
            }
            if(MontoRetiro>100&& MontoRetiro < 500)
            {
                Monto_Res = MontoRetiro / 100;
                MontoRetiro = MontoRetiro - (Monto_Res * 100);
            }
            
        }

    }
}
