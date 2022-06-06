Console.WriteLine("Adicione a média do aluno");
double media = double.Parse(Console.ReadLine());

if (media < 5)
    Console.WriteLine("O aluno foi reprovado.");
else if (media > 6 || media < 7)
    Console.WriteLine("O aluno está em recuperação");
else
    Console.WriteLine("O aluno foi aprovado");

//Utilizando ternário

var resultadoAluno = (media >= 8 ? "Aprovado" : "Reprovado");

Console.WriteLine($"A situação do aluno foi que o aluno foi: {resultadoAluno}");