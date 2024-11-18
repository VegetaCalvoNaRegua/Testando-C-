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
