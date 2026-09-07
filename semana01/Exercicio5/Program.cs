using System;

class Program
{
    static void Main(string[] args)
    {

        ExibirBoasVindas();

        String nomeUsuario = PerguntarNomeUsuario();
        int numeroFavorito = PerguntarNumeroFavorito();
        int numeroElevadoAoQuadrado = ElevarAoQuadrado(numeroFavorito);

        ExibirResultado(nomeUsuario, numeroElevadoAoQuadrado);
    }

    static void ExibirBoasVindas()
        {
            Console.WriteLine("Bem-vindo ao Programa!");
        }
    static String PerguntarNomeUsuario()
        {
            Console.WriteLine("Por favor. insira seu nome: ");
            String nomeUsuario = Console.ReadLine();

            return nomeUsuario;
        }
    static int PerguntarNumeroFavorito ()
        {
            Console.WriteLine("Por favor. insira seu número favorito: ");
            int numeroFavorito = int.Parse(Console.ReadLine());

            return numeroFavorito;
        }
    static int ElevarAoQuadrado (int numero)
        {
            int quadrado = numero * numero;

            return quadrado;
        }
     static void ExibirResultado (String nome, int quadrado)
        {
            Console.WriteLine($"Irmão {nome}, o quadrado do seu número é: {quadrado}");    
        }
    


}