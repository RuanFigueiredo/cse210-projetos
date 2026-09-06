using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma nota de 0 a 100: ");
        int nota = int.Parse(Console.ReadLine());

        String letra;

        if(nota >=90 )
            {
                letra = "A";
                      
            }
        else if(nota >=80)
            {
               letra = "B";
                    
            }
        else if(nota >=70)
            {
                letra = "C";
                      
            }
        else if(nota >=60)
            {
                letra = "D";
                      
            }
        else
            {
                letra = "F";
                  
            }
            
            Console.WriteLine(letra);

        if (nota >=70)
            {
                Console.WriteLine("Parabéns, você passou!");       
            }
        else
            {
                Console.WriteLine("Você não passou, não desista! tente novamente!");       
            }
        
            
            

    }
}