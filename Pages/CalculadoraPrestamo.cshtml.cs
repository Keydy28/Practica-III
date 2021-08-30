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
        public double CapitalPrestamo { get; set; }
        public double CantidadCuotaPrestamo { get; set; }
        public double PorcentajePrestamo { get; set; }
        public double CuotaMensual { get; set; }
        public double InteresMensual { get; set; }
        public double InteresAnual { get; set; }
        public List<ListaCuotas> AmortizacionPrest=new List<ListaCuotas>();
        public void OnGet()

        {
            
        }

        public void OnPost()
        {
            InteresAnual = double.Parse(Request.Form["Interes"]);
            CantidadCuotaPrestamo = double.Parse(Request.Form["CantidadCuota"]);
            CapitalPrestamo = double.Parse(Request.Form["Capital"]);
            CalcularPrestamo();

        }
        public void CalcularPrestamo()

        {
            
            InteresMensual = CapitalPrestamo * InteresAnual / 100;

            CuotaMensual =(InteresMensual + CapitalPrestamo) /CantidadCuotaPrestamo;
            
            AmortizacionPrest = new List<ListaCuotas>();

            for (int i = 1; i <=CantidadCuotaPrestamo; i++)
            {
                if(i != 1)
                {
                    CapitalPrestamo = CapitalPrestamo - CuotaMensual;
                }
                if (CapitalPrestamo<0)
                {
                    CuotaMensual=0;
                }
                AmortizacionPrest.Add(new ListaCuotas()
                {
                    NumeroCuota = i,
                    MontoCuota = CuotaMensual,
                    CapitalPrestamo = CapitalPrestamo,
                    InteresPrestamo = InteresAnual
                });

            }
                
        }

    }

    public class ListaCuotas
    {
        public int NumeroCuota { get; set; }
        public double MontoCuota { get; set; }
        public double CapitalPrestamo { get; set; }
        public double InteresPrestamo { get; set; }
        public double CapitalTotal { get; set; }
        public double CapitalRest { get; set; }       

    }
    
}
