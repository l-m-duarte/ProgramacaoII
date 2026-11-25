using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;


public class Data
{
	public int mes;
	public int ano;
}


public class Gado
{
	public int codigo;
	public double leite; // por semana
	public double alim;  // por semana
	public Data nasc;
	public char abate;   // igual o exercício anterior, seria melhor usar boolean mas pede S ou N
}


class Program
{
	static void addGado(List<Gado> listaGado)
	{
		Gado novoGado = new Gado(); // Instancie um novo Gado
		Console.WriteLine("Entre com os dados do Gado");

		Console.Write("Código do gado: ");
		novoGado.codigo = int.Parse(Console.ReadLine());
		Console.Write("Leite produzido por semana (litros): ");
		novoGado.leite = double.Parse(Console.ReadLine());
		Console.Write("Alimento ingerido por semana (kg): ");
		novoGado.alim = double.Parse(Console.ReadLine());

		novoGado.nasc = new Data();
		Console.Write("Mês de nascimento: ");
		novoGado.nasc.mes = int.Parse(Console.ReadLine());
		Console.Write("Ano de nascimento: ");

		novoGado.nasc.ano = int.Parse(Console.ReadLine());
		novoGado.abate = 'N';

		listaGado.Add(novoGado); // colocando o novo gado na lista
	}


	static void definirAbate(List<Gado> listaGado)
	{
		int mesAtual = DateTime.Now.Month;
		int anoAtual = DateTime.Now.Year;

		for (int i = 0; i < listaGado.Count; i++)
		{
			int idadeMeses = (anoAtual - listaGado[i].nasc.ano) * 12 + (mesAtual - listaGado[i].nasc.mes);
			if (idadeMeses > 60 || listaGado[i].leite < 40) // + de 60 meses ou menos de 40 l / semana
			{
				listaGado[i].abate = 'S';
			}
			else
			{
				listaGado[i].abate = 'N';
			}
		}
	}


	static double totalLeite(List<Gado> listaGado)
	{
		double total = 0;
		for (int i = 0; i < listaGado.Count; i++)
		{
			total += listaGado[i].leite;
		}
		return total;
	}


	static double totalAlimento(List<Gado> listaGado)
	{
		double total = 0;
		for (int i = 0; i < listaGado.Count; i++)
		{
			total += listaGado[i].alim;
		}
		return total;
	}


	static bool listarAbate(List<Gado> listaGado)
	{
		bool encontrado = false;

		Console.WriteLine("-------------------------Gado para abate");
		for (int i = 0; i < listaGado.Count; i++)
		{
			if (listaGado[i].abate == 'S')
			{
				Console.WriteLine($"Código: {listaGado[i].codigo}");
				Console.WriteLine($"Leite por semana: {listaGado[i].leite}");
				Console.WriteLine($"Alimento por semana: {listaGado[i].alim}");
				Console.WriteLine($"Nascimento: {listaGado[i].nasc.mes}/{listaGado[i].nasc.ano}\n");

				encontrado = true;
			}
		}
		return encontrado;
	}


	static void salvarDados(List<Gado> listaGado, string nomeArquivo)
	{
		StreamWriter writer = new StreamWriter(nomeArquivo);
		foreach (Gado gado in listaGado)
		{
			writer.WriteLine($"{gado.codigo},{gado.leite},{gado.alim},{gado.nasc.mes},{gado.nasc.ano},{gado.abate}");
			//aqui eu já estava cansado, então gambiarrei e também usei .txt em vez de .csv
			//ademais, o nome do arquivo é entrado como argumento
		}
		Console.WriteLine("Dados salvos");
		writer.Dispose();
	}


	static void carregarDados(List<Gado> listaGado, string nomeArquivo)
	{
		if (File.Exists(nomeArquivo))
		{
			string[] linhasDoArquivo = File.ReadAllLines(nomeArquivo);
			foreach (string linha in linhasDoArquivo)
			{
				string[] campos = linha.Split(',');
				Gado gado = new Gado();
				gado.codigo = int.Parse(campos[0]);
				gado.leite = double.Parse(campos[1]);
				gado.alim = double.Parse(campos[2]);
				gado.nasc = new Data();
				gado.nasc.mes = int.Parse(campos[3]);
				gado.nasc.ano = int.Parse(campos[4]);
				gado.abate = char.Parse(campos[5]);

				listaGado.Add(gado);
			}
			Console.WriteLine("Dados carregados");
		}
		else
		{
			Console.WriteLine("Arquivo ñ encontrado");
		}
	}

	static int menu()
	{
		Console.WriteLine("-------------------------SISTEMA DE CONTROLE DA FAZENDA DE GADO-------------------------");
		Console.WriteLine("1 - Cadastrar gado");
		Console.WriteLine("2 - Total de leite produzido por semana");
		Console.WriteLine("3 - Total de alimento consumido por semana");
		Console.WriteLine("4 - Listar gado para abate");
		Console.WriteLine("5 - Salvar dados em arquivo");
		Console.WriteLine("6 - Carregar dados do arquivo");
		Console.WriteLine("0 - Sair");
		Console.Write("Escolha uma opção: ");
		return int.Parse(Console.ReadLine());
	}

	static void Main()
	{
		List<Gado> listaGado = new List<Gado>();
		int opcao = 0;
		do
		{
			opcao = menu();
			switch (opcao)
			{
			case 1:
				addGado(listaGado);
				definirAbate(listaGado);
				break;
			case 2:
				double totalLeiteSemana = totalLeite(listaGado);
				Console.WriteLine($"Total de leite por semana: {totalLeiteSemana} litros");
				break;
			case 3:
				double totalAlimentoSemana = totalAlimento(listaGado);
				Console.WriteLine($"Total de alimento por semana: {totalAlimentoSemana} kg");
				break;
			case 4:
				bool encontrado = listarAbate(listaGado);
				if (!encontrado)
					Console.WriteLine("Nenhum gado para abate!");
				break;
			case 5:
				salvarDados(listaGado, "gado.txt");
				break;
			case 6:
				carregarDados(listaGado, "gado.txt");
				definirAbate(listaGado);
				break;
			case 0:
				break;
			}
			Console.ReadKey();
			Console.Clear();
		} while (opcao != 0);
	}
}
