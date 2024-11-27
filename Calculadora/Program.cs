using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Resultado
{
    internal class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operacao deseja fazer?");
            Console.WriteLine("1 - Adicao");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Multiplicacao");
            Console.WriteLine("4 - Divisao");

            Console.ReadLine();

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero para a operacao a ser realizada:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero para a operacao a ser realizada:");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operacao)
            {
                case 1:
                {
                    resultado = Adicao(num1, num2);
                    break;
                }

                case 2:
                {
                    resultado = Subtracao(num1, num2);
                    break;
                }

                case 3:
                {
                    resultado = Multiplicacao(num1, num2);
                    break;
                }

                case 4:
                {
                    resultado = Divisao(num1, num2);
                    break;
                }

                default:
                Console.WriteLine("Numero invalido, digite outro valor:");
                break;
            }
          
          Console.WriteLine($"O resultado da operacao eh:{resultado}");

        } 
    
    public static int Adicao(int num1, int num2)
     {
        int resultado = num1 + num2;
        return resultado;    

     }

     public static int Subtracao(int num1, int num2)
     {
        int resultado = num1 - num2;
        return resultado;    

     }

     public static int Multiplicacao(int num1, int num2)
     {
        int resultado = num1 * num2;
        return resultado;    

     }

     public static int Divisao(int num1, int num2)
     {
        if (num2 == 0)
        {
            Console.WriteLine("Erro, divisao pro 0 nao permitida");
            return 0;
        }
        int resultado = num1 / num2;
        return resultado; 


     }
    
    }


}
