using ExemploFundamentos.Common.Models;

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 10;
arrayInteiros[1] = 20;
arrayInteiros[2] = 30;

for(int contador = 0; contador < arrayInteiros.Length; contador++){
    Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
}