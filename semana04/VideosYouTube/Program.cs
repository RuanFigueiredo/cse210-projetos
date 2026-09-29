using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Vídeo 1
        Video video1 = new Video(
            "Aprenda C#",
            "Escola de TI",
            620
        );

        video1.AdicionarComentario(
            new Comentario("João", "Excelente vídeo! Aprendi bastante.")
        );

        video1.AdicionarComentario(
            new Comentario("Maria", "A explicação foi muito clara.")
        );

        video1.AdicionarComentario(
            new Comentario("Pedro", "Vou assistir novamente para praticar.")
        );


        // Vídeo 2
        Video video2 = new Video(
            "Como Criar um Jogo em C#",
            "Dev Games",
            845
        );

        video2.AdicionarComentario(
            new Comentario("Carlos", "Esse tutorial me ajudou muito.")
        );

        video2.AdicionarComentario(
            new Comentario("Lucas", "Gostei bastante do projeto.")
        );

        video2.AdicionarComentario(
            new Comentario("Fernanda", "Poderia fazer uma parte 2?")
        );


        // Vídeo 3
        Video video3 = new Video(
            "Programação Orientada a Objetos",
            "Programador",
            735
        );

        video3.AdicionarComentario(
            new Comentario("Janaina", "Hoje fortaleci meu conhecimento sobre Encapsulamento.")
        );

        video3.AdicionarComentario(
            new Comentario("Daniel", "Ótima explicação")
        );

        video3.AdicionarComentario(
            new Comentario("Julio", "gostei , continue assim.")
        );

        video3.AdicionarComentario(
            new Comentario("Mayara", "Você abriu minha mente, Obrigada!")
        );


        // Vídeo 4
        Video video4 = new Video(
            "Dicas para receita de bolo",
            "cakes brasil",
            510
        );

        video4.AdicionarComentario(
            new Comentario("Caio", "As dicas são excelentes.")
        );

        video4.AdicionarComentario(
            new Comentario("Larissa", "Gostei principalmente da dica sobre farinha de trigo.")
        );

        video4.AdicionarComentario(
            new Comentario("Daniel", "Vou colocar essas dicas em prática.")
        );


        // Lista de vídeos
        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3,
            video4
        };


        // Exibir os vídeos e comentários
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Título: {video.Titulo}");
            Console.WriteLine($"Autor: {video.Autor}");
            Console.WriteLine($"Duração: {video.Duracao} segundos");
            Console.WriteLine($"Número de comentários: {video.ObterNumeroComentarios()}");
            Console.WriteLine("Comentários:");

            foreach (Comentario comentario in video.ObterComentarios())
            {
                Console.WriteLine($"  {comentario.Nome}: {comentario.Texto}");
            }

            Console.WriteLine();
        }
    }
}