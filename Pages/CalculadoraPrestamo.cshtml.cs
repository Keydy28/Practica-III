using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Practica_III.Pages
{
    public class CalculadoraPrestamoModel : PageModel
    {
        public double MontoPrestamo { get; set; }
        public double CantidadCuotaPrestamo { get; set; }
        public double PorcentajePrestamo { get; set; }
        public void OnGet(double Monto,double CantidadCuota, double Porcentaje)
        {
            this.MontoPrestamo = Monto; CantidadCuotaPrestamo = CantidadCuota;PorcentajePrestamo = Porcentaje;
        }
    }
    //public double Tasa (double porcentaje)
       
   // {
        
    //}
}
