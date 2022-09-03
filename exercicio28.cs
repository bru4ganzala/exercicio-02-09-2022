/*28 - Crie um algoritmo que leia a idade de 10 pessoas, mostrando no final
- A média de idade do grupo
- Quantas pessoas tem mais de 18 anos
- Quantas pessoas tem menos de 5 anos
- Qual foi a maior idade lida*/

using System;
class Programa{

     public static void Main( string[] args){

        int idade = 0;
        int mais = 0;
        int menos = 0;
        int maioridade = 0;
        double media = 0;
        int totalIdade =0 ;

        for(int i = 1; i <= 10 ; i++){
            Console.WriteLine("digite sua idade  :");
            idade = int.Parse(Console.ReadLine());

            totalIdade = totalIdade + idade;
            


            if(idade>=18){
               mais++;
            }if(idade <=5){
               menos++;
            }if(maioridade < idade){
               maioridade = idade;
            }
        }
        media = totalIdade / 10.0;

        Console.WriteLine("A média de idade do grupo:"+ media);
         Console.WriteLine("Quantas pessoas tem mais de 18 anos:"+mais);
         Console.WriteLine("Quantas pessoas tem menos de 5 anos:"+menos);
         Console.WriteLine("Qual foi a maior idade lida:"+maioridade);
     }
}