using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacecExerciciosListaDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe sua data de nascimento: ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                int idade = DateTime.Today.Year - data.Year;

                if (data.DayOfYear < DateTime.Today.DayOfYear)
                    idade = idade - 1;

                Console.WriteLine($"Sua idade é: {idade}");

                Console.WriteLine("Sua idade é de:" +
                    $"{DateTime.Today.Year - data.Year}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
