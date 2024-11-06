double nota1 = 6.5;
double nota2 = 5.9;
double nota3 = 8.1;

double media = (nota1 + nota2 + nota3) / 3;
if (media >= 7)
{
  Console.WriteLine($"Media {media:F2} aluno aprovado!");
}
else
{
  Console.WriteLine($"Media {media:F2}; aluno em recuperacao!");
}



double nota11 = 3.9;
double nota22 = 6.1;
double nota33 = 4.9;
double mediaNota = (nota11 + nota22 + nota33) / 3;
if (mediaNota >= 7)
{
  Console.WriteLine($"Media {mediaNota:F2}: aprovado!");
}
else if (mediaNota >= 5 && mediaNota < 7)
{
  Console.WriteLine($"Media {mediaNota:F2}: recuperacao!");
}
else 
{
  Console.WriteLine($"Media {mediaNota:F2}: reprovado!");
}

