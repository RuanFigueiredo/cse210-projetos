using System;

class Program
{
    static void Main(string[] args)
    {
        // ==========================
        // PEDIDO 1
        // ==========================

        Endereco endereco1 = new Endereco(
            "85 Terry Street",
            "New York",
            "NY",
            "USA"
        );

        Cliente cliente1 = new Cliente(
            "Juan Uceda",
            endereco1
        );

        Pedido pedido1 = new Pedido(cliente1);

        Produto produto1 = new Produto(
            "Cadeira",
            "P001",
            175.00,
            1
        );

        Produto produto2 = new Produto(
            "Mouse Gamer",
            "P002",
            40.00,
            2
        );

        Produto produto3 = new Produto(
            "Fone Headset",
            "P003",
            70.00,
            1
        );

        pedido1.AdicionarProduto(produto1);
        pedido1.AdicionarProduto(produto2);
        pedido1.AdicionarProduto(produto3);


        // ==========================
        // PEDIDO 2
        // ==========================

        Endereco endereco2 = new Endereco(
            "Rua das Gaivotas, 1111",
            "Santa Catarina",
            "Blumenau",
            "Brasil"
        );

        Cliente cliente2 = new Cliente(
            "amaro",
            endereco2
        );

        Pedido pedido2 = new Pedido(cliente2);

        Produto produto4 = new Produto(
            "parafuso cx",
            "P004",
            20.00,
            1
        );

        Produto produto5 = new Produto(
            "Webcam",
            "P005",
            80.00,
            1
        );

        Produto produto6 = new Produto(
            "borracha",
            "P006",
            10.00,
            2
        );

        pedido2.AdicionarProduto(produto4);
        pedido2.AdicionarProduto(produto5);
        pedido2.AdicionarProduto(produto6);


        // ==========================
        // EXIBIR PEDIDO 1
        // ==========================

        Console.WriteLine("========================================");
        Console.WriteLine("PEDIDO 1");
        Console.WriteLine("========================================");

        Console.WriteLine(pedido1.ObterEtiquetaEmbalagem());

        Console.WriteLine("----------------------------------------");

        Console.WriteLine(pedido1.ObterEtiquetaEnvio());

        Console.WriteLine("----------------------------------------");

        Console.WriteLine($"Preço total: ${pedido1.CalcularTotal():F2}");

        Console.WriteLine();


        // ==========================
        // EXIBIR PEDIDO 2
        // ==========================

        Console.WriteLine("========================================");
        Console.WriteLine("PEDIDO 2");
        Console.WriteLine("========================================");

        Console.WriteLine(pedido2.ObterEtiquetaEmbalagem());

        Console.WriteLine("----------------------------------------");

        Console.WriteLine(pedido2.ObterEtiquetaEnvio());

        Console.WriteLine("----------------------------------------");

        Console.WriteLine($"Preço total: ${pedido2.CalcularTotal():F2}");
    }
}