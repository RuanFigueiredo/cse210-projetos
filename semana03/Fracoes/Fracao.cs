public class Fracao
{
    //atributos
    private int _numerador;
    private int _denominador;


//construtores
    public Fracao()
    {
        _numerador = 1;
        _denominador = 1;
    }

    public Fracao(int numerador)
    {
        _numerador = numerador;
        _denominador = 1;

    }

    public Fracao(int numerador, int denominador)
    {
          _numerador = numerador;
          _denominador = denominador;
    }

    // getters e setters
    
    public int ObterNumerador() //getter para numerador
    {
        return _numerador;
    }
    public void DefinirNumerador(int numerador) //setter para numerador
    {
        _numerador = numerador;
    }
    public int ObterDenominador() // getter para denominador
    {
        return _denominador;
    }
    public void DefinirDenominador(int denominador)
    {
        _denominador = denominador;
    }

    public string ObterFracaoEmTexto()
    {
        return $"{_numerador}/{_denominador}";
    }
    
    public double ObterFracaoEmDecimal()
    {
        return (double)_numerador / _denominador;
    }
}