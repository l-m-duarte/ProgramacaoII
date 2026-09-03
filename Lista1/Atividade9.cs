using System;

class Atividade9
{
    static string gerarComplementar(string dna)
    {
        string complement = "";

        for (int i=0; i < dna.Length; i++)
        {
            if (dna[i] == 'A')
            {
                complement += "T";
            }
            else if (dna[i] == 'T')
            {
                complement += "A";
            }
            else if (dna[i] == 'C')
            {
                complement += "G";
            }
            else if (dna[i] == 'G')
            {
                complement += "C";
            }
        }
        return complement;
    }
    
    
    
    static void Main()
    {
        string dna = "";
        Console.Write("Digite a fita de DNA: ");
        dna = Console.ReadLine()!;

        Console.WriteLine($"Fita complementar: {gerarComplementar(dna)}");
    }
}

