using System;

class Program
{
    static void Main(string[] args)
    {
       
        
        // Solicita ao usuário que insira o número mágico e o palpite
         Random geradorAleatorio = new Random();
        int numeroMagico = geradorAleatorio.Next(1,101);

     
        int palpite = 0;

        while (palpite != numeroMagico)
        {
            Console.Write("Qual é o seu palpite? ");
            palpite = int.Parse(Console.ReadLine());

            // condição para verificar se o palpite é maior, menor ou igual ao número mágico
            if(palpite < numeroMagico)
            {
                Console.WriteLine("Mais alto");
            }
            else if(palpite > numeroMagico)
            {
                Console.WriteLine("Mais baixo");
            }
            else
            {
                Console.WriteLine("Você adivinhou!");
            } 

            }
            
        }
    }