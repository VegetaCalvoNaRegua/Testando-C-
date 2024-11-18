// Exercicio 1: escreva um codigo que some todos os elementos do array

using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

int [] Array = new int[5] {2, 4, 6, 8, 10};
int somaArray = 0;
for (int i = 0; i < Array.Length; i++){
    somaArray += Array[i];
}

Console.WriteLine(somaArray);


//Exercicio 1 resolvido pelo professor

// int[] numeros = {1, 2, 3, 4, 5};
// int soma = 0;
// foreach ( int numero in numeros){
//     soma += numero;
// }

//Exercicio 2: escreva um codigo para contar quantas vezes determinada string aparece listada

 List<string> nome  = new List<string> {"Jeane", "Anderson", "Jeane", "Ryan", "Jeane"};
 int contador = 0;
 foreach (string pessoa in nome){

    if  (pessoa == "Jeane"){
        
        contador ++;
    }
 }
 Console.WriteLine($"Numero de vezes que o nome se repete:{contador}");





// Exercicio 3

List<int> listadenumeros = new List<int> {1,2,3,4,2,3,1,2,4};
HashSet<int> conjunto = new HashSet<int>(listadenumeros);

Console.WriteLine("Lista sem duplicatas:");
foreach (int numero in conjunto){

    Console.WriteLine(numero);
}

//Exercicio 4

HashSet<string> frutas = new HashSet<string> {"Maçã", "Banana", "Laranja"};
Console.WriteLine("Banana está no conjunto frutas?");
Console.WriteLine(frutas.Contains("Banana") ? "Sim, Banana está no conjunto frutas" : "Não, Banana não está no conjunto frutas");



//Exercicio 5

List<int> listadenumerosvazia = new List<int>();
 for (int i = 1; i <=5; i++){

    listadenumerosvazia.Add(i);
 }

Console.WriteLine("Elementos na lista:");
for (int i = 0; i < listadenumerosvazia.Count; i++ ){
    Console.WriteLine(listadenumerosvazia[i]);
}
