using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    private static int contar = 0; 

    static void Main()
    {
        Inicio(); 
    }

    private static void Inicio()
    {
        Console.WriteLine("Digite a palavra:");
        string input = Console.ReadLine();
        contador(input); 
    }

    private static void contador(string input)
    {
        contar = 0; 
        string lowerInput = input.ToLower();

        foreach (char letra in lowerInput)
        {
            if (letra == 'a')
            {
                contar++;
            }
        }

        if (contar > 0)
        {
            Console.WriteLine($"A letra 'a' aparece {contar} vez(es) na palavra escolhida.");
           Fim();
        }
        else
        {
            Console.WriteLine("Não existe a letra 'a' na palavra escolhida.");
            Fim();

        }
 
    }
    private static void Fim()
    {
        Console.WriteLine("Deseja fazer uma nova verificação? (Sim/Não)");
        string fim = Console.ReadLine();
        fim = fim?.ToLower();


        if (fim == "sim" )
        {
            Inicio();
        }
        else if (fim == "não" || fim =="nao") 
                {
            Console.WriteLine("Até a próxima verificação");
            return;
        }
    }
}

