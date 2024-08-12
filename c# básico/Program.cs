/*void Escreva(string msg){
    Console.WriteLine(msg);
}
void Idade(string nome, int idade){
    Escreva($"{nome} tem {idade} anos");
}
Idade("TOLENTINO",16);
void CalcularIdade(string nome, int ano){
    int idade = 2024 - ano;
    Idade(nome, idade);
   
}
CalcularIdade("Tolentino", 2009);
*/
void soma(float a,  float b){
    float resultado = a + b;
    Console.WriteLine($"{a} + {b} = {resultado} !") ;
}
//soma(10,8);
void multiplicacao(float a,  float b){
    float resultado = a * b;
    Console.WriteLine($"{a} * {b} = {resultado} !") ;
}
void divisao(float a,  float b){
    float resultado = a / b;
    Console.WriteLine($"{a} / {b} = {resultado} !") ;
    if(b==0){
        Console.WriteLine("Erro de divisão por zero");
        return;
    }
}
void subtraçao(float a,  float b){
    float resultado = a - b;
    Console.WriteLine($"{a} - {b} = {resultado} !") ;
}    
float a;
float b;
void digitar(){
    Console.WriteLine("Digite o Valor de A:");
    a = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o Valor de B:");
    b = float.Parse(Console.ReadLine());
}

                             
//menu
Console.WriteLine("--Calculadora--");
Console.WriteLine("|1- Soma      |");
Console.WriteLine("|2- Subtração    |");
Console.WriteLine("|3- Multiplicação     |");
Console.WriteLine("|3- Divisão     |");
Console.WriteLine("|5-Sair   |" );
Console.WriteLine("-----------------");

int opcao= int.Parse(Console.ReadLine());
if(opcao==1){
    Console.WriteLine("Soma");
    digitar();
    soma(a,b);
}
else if(opcao==2){
  Console.WriteLine("Subtração");
    digitar();
    subtraçao(a,b);
}
else if(opcao==23){
  Console.WriteLine("Multiplicação");
    digitar();
    multiplicacao(a,b);
}
else if(opcao==4){
  Console.WriteLine("Divisão");
    digitar();
    divisao(a,b);
}
else if(opcao==5){
    Console.WriteLine("Saindo...");
}
else{
    Console.WriteLine("Opção inválida.");
}