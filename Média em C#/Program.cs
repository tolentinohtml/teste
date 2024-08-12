using System.Threading.Tasks.Sources;

Console.WriteLine("Digite o valor da nota 1:");
int nota1 = int.Parse (Console.ReadLine());
Console.WriteLine("Digite o valor da nota 2:");
int nota2 = int.Parse (Console.ReadLine());
Console.WriteLine("Digite o valor da nota 3:");
int nota3 = int.Parse (Console.ReadLine());
Console.WriteLine("Digite o valor da nota 4:");
int nota4 = int.Parse (Console.ReadLine());
float media =(2*nota1 + 2*nota2 + 3*nota3 +3*nota4)/10f;
media= (float)Math.Round(media);
Console.WriteLine("A sua média é " + media +". ");
if(media>=60){
    Console.WriteLine("Você está aprovado, parabéns!");
    return;
}
  else if(media<20){
    Console.WriteLine("Você está reprovado!");
    return;

}
 else {
    Console.WriteLine("Você está de recuperação!");
    float previsao = 120 - media;
    Console.WriteLine($"Você precisa tirar {previsao} para passar de ano.");
}

Console.WriteLine("Digite sua nota da prova final:");
int provafinal= int.Parse(Console.ReadLine());
float mediafinal=(media + provafinal)/2f;
mediafinal= (float)Math.Round(mediafinal);

Console.WriteLine("Média final é igual a: " + mediafinal);
if(mediafinal>=60){
    Console.WriteLine("Você está aprovado, parabéns");
}
 else if (mediafinal<60){
    Console.WriteLine("Você está reprovado.");
}

                        