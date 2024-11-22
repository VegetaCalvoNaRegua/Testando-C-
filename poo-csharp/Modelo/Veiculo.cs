namespace poo-csharp.Modelo
{

  public class Veiculo
  {

    //atributos
    private string marca;
    private string modelo;
    private int ano;    
    protected double velocidadeAtual;

  
   // construtor
   public Veiculo(string marca, string modelo, int ano, double velocidadeAtual)
    {
   
     this.marca = marca (get; set;);
     this.modelo = modelo (get; set;);
     this.ano = ano (get; set;);
     this.velocidadeAtual = velocidadeAtual (get; set;);

    }

   //METODOS ACELERAR E FREAR

   public void Acelerar()
   {

      Console.WriteLine($"{marca} {modelo} {ano} esta acelerando!");
   }

   public void Frear()
   {

      Console.WriteLine($"{marca} {modelo} {ano} esta freando!");
   }
  
  }
}