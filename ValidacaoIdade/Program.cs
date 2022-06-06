/*Console.WriteLine("Digite a sua idade: ");
int idade1 = int.Parse(Console.ReadLine());

if (idade1 >= 18)
    Console.WriteLine("Pode tirar carteira");
else
    Console.WriteLine("Não pode tirar carteira");
*/

/*Console.WriteLine("Digite sua idade: ");
for (int idade = int.Parse(Console.ReadLine()); idade < 18; idade++){
    Console.WriteLine($"Idade: {idade}, Não pode tirar carta");
}

Console.WriteLine("Agora você pode tirar sua carta, já tem mais de 18 anos");
*/

//Operadores Ternários
//Sintaxe: testeLogico ? valor se verdadeiro : valor false

int a = 10;
int b = 40;

var resultado = (a == b ? "Sim": "Não");

Console.WriteLine(resultado);
