///
///
///
///
///
///
///
///
///


//Exemplos 03: Conjunto (Set)
//Conjunto Set os elementos dispostos nao se repetem, nao permite insercao de elementos repetidos.

HashSet<int> conjunto = new HashSet<int> {1,2,3};
conjunto.Add(4);
conjunto.Add(2);

Console.WriteLine("Elementos do Conjunto");
foreach(int elemento in conjunto){

    Console.WriteLine(elemento);
}


// Exemplo 3.1

HashSet<string> frutas = new HashSet<string> {"Maca", "Abacaxi", "Laranja"};
frutas.Add("Uva");
frutas.Add("Maca");

Console.WriteLine("Frutas no conjunto:");
foreach (string fruta in frutas)
{
    Console.WriteLine (fruta);
}

Console.WriteLine("\nVerificacao de Existencia:");
Console.WriteLine(frutas.Contains("Banana") ? "Banana estah no conjunto" : "Banana nao estah no conjunto");


//Exemplo 3.2: Remocao de elementos

frutas.Remove("Laranja");
Console.WriteLine ("\nApos remover Laranja:");
foreach (string fruta in frutas){
    Console.WriteLine(fruta);
}

//Exemplo 3.3