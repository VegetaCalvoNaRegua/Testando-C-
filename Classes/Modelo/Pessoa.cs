using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classes.Modelo
{

  public class Veiculo
  {

    //atributos
    string marca;
    string modelo;
    int ano;    

  
   // construtor
   public Veiculo(string marca, string modelo, int ano)
    {
   
     this.marca = marca;
     this.modelo = modelo;
     this.ano = ano;

    }

   //METODOS ACELERAR E FREIAR

   public void Acelerar()
   {

      Console.WriteLine($"{marca} esta acelerando!");
   }

   public void Freiar()
   {

      Console.WriteLine($"{marca} esta freiando!");
   }
  
  }
}
