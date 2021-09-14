using System;

namespace FGTS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadLine();
            double salário;
            decimal fgts;

            Console.WriteLine("Bem vindo ao cálculo de IMC! /n");
            Console.Write("Salário(R$)...");
            salário=Convert.ToDouble(Console.ReadLine());
            
            fgts=Convert.ToDecimal(salário *0.08);
            Console.WriteLine($"/n FGTS: {fgts.ToString("c")}");






            

        }
    }
}
