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


        public void OnGet()
        {
        }
        public void Transacion(string Banco, int MontoRetiro)
        {
            if (Banco == "ABC" && MontoRetiro > 10000)
            {

            }
            else if (Banco != "ABC" && MontoRetiro > 2000)
            {

            }

            int Monto_Res = MontoRetiro;
            if((Billete_1000 > 0 && (Monto_Res / 1000) > 0))
            {
                if (Billete_1000 < (Monto_Res / 1000))
                {
                    Monto_Res = Billete_1000 * 1000;
                    Billete_1000 = 0;
                } else
                {
                    Monto_Res = (Monto_Res / 1000) * 1000;
                    Billete_1000 = Billete_1000 - (Monto_Res / 1000);
                }
            }
        }

    }
}
