using System;
using System.Globalization;

namespace atividade01 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escolha o programa que deseja vislumbrar: \n");
            Console.WriteLine("1 - CalcularDescontoINSS");
            Console.WriteLine("2 - DetalharData");

            int escolha = int.Parse(Console.ReadLine());

            switch(escolha){
              case 1: 
               CalcularDescontoINSS(); 
               break;

               case 2:

                DetalharData(); break;

                default:
                Console.WriteLine("Escolha inexistente"); break;

            }
        }

        public static void CalcularDescontoINSS()
        {
            Console.WriteLine("Digite o seu salário: ");
            double salario = double.Parse(Console.ReadLine());

            if (salario <= 1212)
            {
                double reajuste = 7.5 * salario / 100;
                double newSalario = salario - reajuste;
                Console.WriteLine("");
                Console.WriteLine($"Seu reajuste é de 7.5%, ou {reajuste:c2} reais");
                Console.WriteLine($"Seu novo salário é {newSalario:c2}");
                Console.WriteLine("");
                Console.ReadKey();
            }
            else
            {
                if (salario >= 1212.01 && salario <= 2427.35)
                {
                    double reajuste = 9 * salario / 100;
                    double newSalario = salario - reajuste;
                    Console.WriteLine("");
                    Console.WriteLine($"Seu reajuste é de 9%, ou {reajuste:c2} reais");
                    Console.WriteLine($"Seu novo salário é {newSalario:c2}");
                    Console.WriteLine("");
                    Console.ReadKey();
                }
                else
                {
                    if (salario >= 2427.36 && salario <= 3641.03)
                    {
                        double reajuste = 12 * salario / 100;
                        double newSalario = salario - reajuste;
                        Console.WriteLine("");
                        Console.WriteLine($"Seu reajuste é de 12%, ou {reajuste:c2} reais");
                        Console.WriteLine($"Seu novo salario é {newSalario:c2}");
                        Console.WriteLine("");
                        Console.ReadKey();
                    }
                    else
                    {
                        double reajuste = 14 * salario / 100;
                        double newSalario = salario - reajuste;
                        Console.WriteLine("");
                        Console.WriteLine($"Seu reajuste é de 14%, ou {reajuste:c2} reais");
                        Console.WriteLine($"Seu novo salário é {newSalario:c2}");
                        Console.WriteLine("");
                        Console.ReadKey();
                    }
                }
            }
        }

        public static void DetalharData()
        {
            Console.WriteLine("Digite uma data: ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            if (data.DayOfWeek == DayOfWeek.Sunday)
            {
                string frase = string.Format("Hoje é {0:dddd}, dia {0:dd} de {0:MMMM}, e são exatamente {1:HH:mm:ss}", data, DateTime.Now);
                Console.WriteLine(frase.ToUpper());
            }
            else
            {
                string frase = string.Format("Hoje é {0:dddd}, dia {0:dd} de {0:MMMM}", data, DateTime.Now);
                Console.WriteLine(frase.ToUpper());
            }

        }
    }
}