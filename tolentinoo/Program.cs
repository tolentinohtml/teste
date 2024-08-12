/*
string colega1= "Pedro raul";
string colega2 = "Yuri alberto";

Console.WriteLine($"Meus colegas de time são {colega1} e {colega2}");
*/

/*
string jogador1 = "Pedro raul";
string jogador2 = "Yuri alberto";

int gols1 = 3;
int gols2 = 6;

Console.WriteLine($"{jogador1} fez {gols2} no jogo e {jogador2} fez {gols1})");
*/
/*
int a = 10;
int b = 2;
int c;

c = a + b;
Console.WriteLine("Soma: " + c);
c = a - b;
Console.WriteLine("subtração: " + c);
c = a * b;
Console.WriteLine("multiplicação: " + c);
c = a / b;
Console.WriteLine("divisão: " + c);
*/

/*
Console.WriteLine("Digite seu nome:");
String nome = Console.ReadLine();
Console.WriteLine("olá,  " + nome + "!" + " Digite o valor de A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine(" Digite agora o valor de B: ");
var B = int.Parse(Console.ReadLine());

Console.WriteLine ("A soma entre A e B é igual a: " + (A + B) + " :)");
*/
using System.ComponentModel;

Console.WriteLine("Digite um número");
int número = int.Parse(Console.ReadLine());
bool par = ((número % 2) == 0 );
if(par){
    Console.WriteLine("Número par");
}
else{
     Console.WriteLine("Número ímpar");
}