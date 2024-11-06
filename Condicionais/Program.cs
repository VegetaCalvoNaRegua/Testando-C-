double nota1 = 6.5;
double nota2 = 5.9;
double nota3 = 8.1;

double media = (nota1 + nota2 + nota3) / 3;
if (media >= 7)
{
  Console.WriteLine($"Media {media:F2}; aluno aprovado!");
}
else
{
  Console.WriteLine($"Media {media:F2}; aluno em recuperacao!");
}


