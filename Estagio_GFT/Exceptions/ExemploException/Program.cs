using System;
using ExemploException.Models;

namespace ExemploException 
{
    internal class Program
    {
        static void Main()
        {
            int a = 100, b =0;
            double resultado = 0;
            try
            {
                resultado = Dividir(a,b);
                System.Console.WriteLine("{0} dividido por {1} = {2}",a,b,resultado);
            }
            catch(DivideByZeroException ex) when(a < 0)
            {
                System.Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            finally
            {
                System.Console.WriteLine("Finalmente a divisão foi finalizada !");
            }
          
        }

        static double Dividir(int x, int y)
        {
            if(y == 0)
            {
                throw new MyClassException("Minha mensagem customizada de erro !");
            }

            return(x/y);
        }
    }
}