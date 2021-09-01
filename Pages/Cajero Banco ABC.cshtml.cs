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
            "ABC", "RESERVAS", "BHD",
        };
        public int Billete_1000 { get; set; }
        public int Billete_500 { get; set; }
        public int Billete_100 { get; set; }
        public int Resultado_Calculo_1000 { get; set; }
        public int Resultado_Calculo_500 { get; set; }
        public int Resultado_Calculo_100 { get; set; }
        public int Monto_Disponible { get; set; }
        public string Banco { get; set; }
        public int Monto { get; set; }
        public string Mensajeerror { get; set; }


        public void OnGet(int Monto)
           
        {
                            
            if (Monto >= 1000)
            {
                Billete_1000 = Monto / 1000;
                Monto = Monto - (Billete_1000 * 1000);
            }

            if (Monto >= 500)
            {
                Billete_500 = Monto / 500;
                Monto = Monto - (Billete_500 * 500);
              
            }

            if (Monto >= 100)
            {
                Billete_100 = Monto / 100;
            }

            Mensajeerror = "";

            if (Banco == "ABC" && Monto > 10000)
            {
                Mensajeerror = "Solo puede retirar 10000";

            }
            //return Mensajeerror;

            if (Banco == "BANRESERVAS" || Monto > 2000)
            {

                Mensajeerror = "Solo pueden retirar 2000";

            }
           // return Mensajeerror;



        }
       /* public string Mensaje( int Monto)

        {


            Mensajeerror = "";
            if (Banco == "ABC" && Monto > 10000)
            {
                Mensajeerror = "Solo puede retirar 10000";
              
            }
            return Mensajeerror;

            if (Banco == "ABC" || Monto <= 2000)
            {
                
                Mensajeerror = "Solo pueden retirar 2000";

            }
            return Mensajeerror;
        }*/
    }
}
