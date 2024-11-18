// escreva um codigo que some todos os elementos do array

using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

int [] Array = new int[5] {2, 4, 6, 8, 10};
int somaArray = 0;
for (int i = 0; i < Array.Length; i++){
    somaArray += Array[i];
}

Console.WriteLine(somaArray);


//Exercicio resolvido pelo professor

// int[] numeros = {1, 2, 3, 4, 5};
// int soma = 0;
// foreach ( int numero in numeros){
//     soma += numero;
// }

// // escreva um codigo para contar quantas vezes determinada string aparece listada

// List<string> nome  = new List<string> {"Jeane", "Anderson", "Jeane", "Ryan", "Jeane"};





// Exercicio 3

List<int> listadenumeros = new List<int> {1,2,3,4,2,3,1,2,4};
HashSet<int> conjunto = new HashSet<int>(listadenumeros);

Console.WriteLine("Lista sem duplicatas:");
foreach (int numero in conjunto){

    Console.WriteLine(numero);
}



//Exercicio 5

List<int> listadenumerosvazia = new List<int>();
 for (int i = 1; i <=5; i++){

    listadenumerosvazia.Add(i);
 }

Console.WriteLine("Elementos na lista:");
foreach (int )









