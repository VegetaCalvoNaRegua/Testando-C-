// OPERADORES ARITMETICOS

double resultado = 12 + 8 + 12 /3;
Console.WriteLine(resultado);

double resultado2 = (12 + 8 + 12) /3;
Console.WriteLine(resultado2);

double resultado3 = 2*2;
Console.WriteLine(resultado3);


// OPERADORES DE COMPARACAO: utilizados para comparar dois valores, resultando em valores de true e false ao final da operacao

// temos == para retornar caso ambas variaveis sao iguais
   var a = 2;
   var b = 2;
   Console.WriteLine(a==b);
// < ou >, para comparar menor ou maior
// != retorn true caso os operadores sejam diferentes        



// OPERADORES LOGICOS: utilizados para combinar expressoes booleanas e avaliar a logica entre elas.

// AND Logico && (E) retorna true somente se ambas forem verdadeiras.
 bool c = true;
 bool d = false;
Console.WriteLine(c&&d);

// OR Logico || (OU) retorna true se pelo menos 1 das expressoes seja verdadeira.
 bool e = true;
 bool f = false;
 Console.WriteLine(e||f);

// NOT Logico !(!a) inverte o valor logico da expressao.
 bool g = true;
 Console.WriteLine(!g);

 // XOR Logico ^ retorna true somente de uma das expressoes for true ou false. Se ambas forem iguais, retorna false
 bool h = false;
 bool i = true;
 Console.WriteLine(h^i);

 //OPERADORES LOGICOS tem MENOR precedencia que OPERADORES ARITMETICOS.
 //exemplos de precedencia logica

 bool aa = true;
 bool bb = false;
 bool cc = false;
 bool resultadoo = !aa||(bb && cc);
 Console.WriteLine(resultadoo);

 bool a1 = false;
 bool b1 = false;
 bool c1 = false;
 bool resultado1 = !a1||b1&&c1;
 Console.WriteLine(resultado1);

