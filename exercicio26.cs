/*26 - Crie um programa que leia 6 números inteiros e no final mostre quantos são pares e
quantos são ímpares.*/

using System;
class Programa{

     public static void Main( string[] args){

        int numero;
        int par = 0;
        int impar = 0;

        for(int i = 0; i <= 6 ; i++){
            Console.WriteLine("porfavor digite um numero :");
            numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0 ){
                par++;

            } else { 
                impar++;
             }
             
        }
         Console.WriteLine("impar:"+impar);
         Console.WriteLine("par:"+par);
        
     }
}
