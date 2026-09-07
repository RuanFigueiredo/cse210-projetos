using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
         List<int> listaNumeros = new List<int>();

        Console.WriteLine("Insira uma lista de números  e digite 0 quando terminar");

        int numero= int.Parse(Console.ReadLine());


        while(numero  != 0)
        {
          
            listaNumeros.Add(numero);

            numero = int.Parse(Console.ReadLine());
                
        }

        int soma = 0;
        int maiorNumero = listaNumeros[0];

        foreach (int numeroLista in listaNumeros)
        {
            soma = soma + numeroLista;
            if (maiorNumero < numeroLista)
            {
                maiorNumero = numeroLista;
            }

        }

        double media = (double)soma / listaNumeros.Count;
        Console.WriteLine("A soma é: " + soma);
        Console.WriteLine("A média é: " + media);
        Console.WriteLine("O maior número é: " + maiorNumero);



    }
}