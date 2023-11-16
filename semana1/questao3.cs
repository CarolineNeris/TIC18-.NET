/*Conversão de Tipos de Dados: Conversão de double para int em C#:
Para converter um double em um int em C#, você pode usar o tipo de cast. Se a parte fracionária não puder ser convertida, a parte decimal será truncada (perdida).
*/

double numeroDouble = 15.78;
int numeroInteiro = (int)numeroDouble; // Conversão usando cast

Console.WriteLine(numeroInteiro); // Saída: 15 (parte fracionária é truncada)
