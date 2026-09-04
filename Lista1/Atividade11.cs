using System;

class Roteiro4
{
    static string decodificar(string frase)
    {
        string fraseMaiuscula = frase.ToUpper();
        string fraseDecod = "";
        for (int i = 0; i < frase.Length; i++)
        {
            if (fraseMaiuscula[i] == 'P')
            {
                if (i + 2 < frase.Length - 1)
                {
                    if (fraseMaiuscula[i + 1] == 'P' & fraseMaiuscula[i + 2] == 'P')
                    {
                        fraseDecod += frase[i + 1];
                    }
                }
            }
            else fraseDecod += frase[i];
        }
        return fraseDecod;
    }






static void Main(string[] args){
        String codificada;
        Console.WriteLine("Digite a palavra  codificada: ");
        codificada = Console.ReadLine();
       // chamada da função


        Console.WriteLine($"Decodificada : {decodificar(codificada)}");
    }
}
