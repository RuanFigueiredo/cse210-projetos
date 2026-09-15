public class Curriculo
{
    public string _nome;
    public List<Emprego> _emprego = new List<Emprego>();

    public void Exibir()
    {
        Console.WriteLine($"Nome: {_nome}");
        Console.WriteLine("Empregos: ");

        foreach(Emprego emprego in _emprego)
        {
            emprego.Exibir();
        }
    }
}