//CONCATENACAO

string nome1 = "Thomas";
string saudacao1 = "Ola," + nome1 + "!Bem vindo.";
Console.WriteLine (saudacao1);


//INTERPOLACAO
string nome = "Thomas";
string saudacao =$"Ola,{nome}! Bem vindo.";
Console.WriteLine(saudacao);


//OPERADOR GetType()

int numero11 = 1;
Console.WriteLine(numero11.GetType());


//typeof() usada para obter o tipo de uma CLASSE ou ESTRUTURA em tempo de criacao

Console.WriteLine(typeof(int));


// Metodo Parse

string valorTexto="100";
Console.WriteLine("A variavel valorTexto eh do tipo:" + valorTexto.GetType());

int numero22 = int.Parse(valorTexto);
Console.WriteLine(numero22);
Console.WriteLine ("A variavel do Parse eh do tipo:" +numero22.GetType());
