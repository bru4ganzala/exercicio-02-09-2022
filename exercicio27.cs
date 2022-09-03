/*27 - Crie um programa que leia o preço e 8 produtos. No final, mostre na tela qual foi o
maior e qual foi o menor preço digitado.*/

using System;
class Programa{

     public static void Main( string[] args){

        int produto = 0;
        int menorpodruto = 0;
        int maioripodruto = 0;

         for(int i = 1; i <= 8 ; i++){
            Console.WriteLine("digite seu produto  :");
            produto = int.Parse(Console.ReadLine());

        if(maioripodruto < produto ){
               maioripodruto = produto;
        }if(menorpodruto > produto ){
               menorpodruto = produto;
        }
         }
         Console.WriteLine("Qual foi o maior produto:"+maioripodruto);
         Console.WriteLine("Qual foi o menor produto:"+menorpodruto);
     }
}
