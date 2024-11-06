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


// metodo Convert
string valorEmTexto = "100";

int numeroConvertido = Convert.ToInt32(valorEmTexto);
Console.WriteLine(numeroConvertido.GetType());


// metodo To String, usado para converter qualquer tipo em string

int numero = 123;
Console.WriteLine(numero.GetType());

string numeroComoString = numero.ToString();
Console.WriteLine(numeroComoString.GetType());

// Personalizacao de Formatacao Data e Hora

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

string dataFormatada = dataAtual.ToString("dd/MM/yyyy");
Console.WriteLine(dataFormatada);

string dataHoraFormat = dataAtual.ToString("hh:mm:ss");
Console.WriteLine(dataHoraFormat);


// To String com $

double preco = 29.99;
Console.WriteLine($"O preco eh: {preco.ToString("C2")}");

 
// Culturalizacao de variaveis

decimal valor = 1234.56m;
string valorUS = valor.ToString("C", new System.Globalization.CultureInfo ("en-US"));
Console.WriteLine(valorUS);

string valorBR = valor.ToString("C", new System.Globalization.CultureInfo ("pt-BR"));
Console.WriteLine(valorBR);


//


