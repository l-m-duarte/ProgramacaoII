using System;
using System.Collections.Generic;

//o código inteiro está num único arquivo porque eu usei o online GBD para escrever tudo

public class Emprestimo
{
	public string data;
	public string nomePessoa;
	public char emprestado; // aqui seria muito melhor usar boolean mas pede para ser 'S' ou 'N' o enunciado
}

public class Jogo
{
	public string titulo;
	public string console;
	public int ano;
	public int ranking;
	public Emprestimo emprestimo;
}

class Program
{
	static void addJogo(List<Jogo> listaJogos)
	{
		Jogo novoJogo = new Jogo();

		Console.WriteLine("Entre com os dados do Jogo");

		Console.Write("Título do jogo: ");
		novoJogo.titulo = Console.ReadLine();

		Console.Write("Console do jogo: ");
		novoJogo.console = Console.ReadLine();

		Console.Write("Ano do jogo: ");
		novoJogo.ano = int.Parse(Console.ReadLine());

		Console.Write("Ranking do jogo: ");
		novoJogo.ranking = int.Parse(Console.ReadLine());

		novoJogo.emprestimo = new Emprestimo();
		novoJogo.emprestimo.data = "";
		novoJogo.emprestimo.nomePessoa = "";
		novoJogo.emprestimo.emprestado = 'N';

		listaJogos.Add(novoJogo);
	}

	static void mostrarJogos(List<Jogo> listaJogos)
	{
		Console.WriteLine("------------------------Jogos Cadastrados");

		for (int i = 0; i < listaJogos.Count; i++)
		{
			Console.WriteLine($"-------------Dados do jogo {i + 1}");
			Console.WriteLine($"Título: {listaJogos[i].titulo}");
			Console.WriteLine($"Console: {listaJogos[i].console}");
			Console.WriteLine($"Ano: {listaJogos[i].ano}");
			Console.WriteLine($"Ranking: {listaJogos[i].ranking}");
			Console.WriteLine($"Emprestado: {listaJogos[i].emprestimo.emprestado}");
		}
	}

	static bool buscarJogo(List<Jogo> listaJogos, string tituloJogo)
	{
		bool encontrado = false;

		for (int i = 0; i < listaJogos.Count; i++)
		{
			if (listaJogos[i].titulo.ToUpper().Contains(tituloJogo.ToUpper()))
			{
				Console.WriteLine("--------------------------Jogo");
				Console.WriteLine($"Título: {listaJogos[i].titulo}");
				Console.WriteLine($"Console: {listaJogos[i].console}");
				Console.WriteLine($"Ano: {listaJogos[i].ano}");
				Console.WriteLine($"Ranking: {listaJogos[i].ranking}");
				Console.WriteLine($"Emprestado: {listaJogos[i].emprestimo.emprestado}");

				encontrado = true;
			}
		}

		return encontrado;
	}

	static bool listarJogosConsole(List<Jogo> listaJogos, string nomeConsole)
	{
		bool encontrado = false;

		for (int i = 0; i < listaJogos.Count; i++)
		{
			if (listaJogos[i].console.ToUpper().Equals(nomeConsole.ToUpper()))
			{
				Console.WriteLine("--------------------------Jogo");
				Console.WriteLine($"Título: {listaJogos[i].titulo}");
				Console.WriteLine($"Console: {listaJogos[i].console}");
				Console.WriteLine($"Ano: {listaJogos[i].ano}");
				Console.WriteLine($"Ranking: {listaJogos[i].ranking}");
				Console.WriteLine($"Emprestado: {listaJogos[i].emprestimo.emprestado}");

				encontrado = true;
			}
		}

		return encontrado;
	}

	static int buscarIndiceJogo(List<Jogo> listaJogos, string tituloJogo)
	{
		for (int i = 0; i < listaJogos.Count; i++)
		{
			if (listaJogos[i].titulo.ToUpper().Equals(tituloJogo.ToUpper()))
			{
				Console.WriteLine("--------------------------Jogo");
				Console.WriteLine($"Título: {listaJogos[i].titulo}");
				Console.WriteLine($"Console: {listaJogos[i].console}");
				Console.WriteLine($"Ano: {listaJogos[i].ano}");
				Console.WriteLine($"Ranking: {listaJogos[i].ranking}");
				Console.WriteLine($"Emprestado: {listaJogos[i].emprestimo.emprestado}");

				return i;
			}
		}

		return -1;
	}

	static bool emprestarJogo(List<Jogo> listaJogos, string tituloJogo)
	{
		int indice = buscarIndiceJogo(listaJogos, tituloJogo);

		if (indice != -1 && listaJogos[indice].emprestimo.emprestado == 'N')
		{
			Console.Write("Nome da pessoa que pegou o jogo: ");
			listaJogos[indice].emprestimo.nomePessoa = Console.ReadLine();

			listaJogos[indice].emprestimo.data = DateTime.Now.ToString("dd/MM/yyyy");
			listaJogos[indice].emprestimo.emprestado = 'S';

			return true;
		}

		return false;
	}

	static bool devolverJogo(List<Jogo> listaJogos, string tituloJogo)
	{
		int indice = buscarIndiceJogo(listaJogos, tituloJogo);

		if (indice != -1 && listaJogos[indice].emprestimo.emprestado == 'S')
		{
			listaJogos[indice].emprestimo.nomePessoa = "";
			listaJogos[indice].emprestimo.data = "";
			listaJogos[indice].emprestimo.emprestado = 'N';

			return true;
		}

		return false;
	}

	static bool mostrarEmprestados(List<Jogo> listaJogos)
	{
		bool encontrado = false;

		Console.WriteLine("--------------------------Jogos emprestados");

		for (int i = 0; i < listaJogos.Count; i++)
		{
			if (listaJogos[i].emprestimo.emprestado == 'S')
			{
				Console.WriteLine($"Título: {listaJogos[i].titulo}");
				Console.WriteLine($"Console: {listaJogos[i].console}");
				Console.WriteLine($"Emprestado para: {listaJogos[i].emprestimo.nomePessoa}");
				Console.WriteLine($"Data do empréstimo: {listaJogos[i].emprestimo.data}\n");

				encontrado = true;
			}
		}

		return encontrado;
	}

	static int menu()
	{
		Console.WriteLine("--------------------------SISTEMA DE COLEÇÃO DE JOGOS--------------------------");
		Console.WriteLine("1 - Adicionar jogo");
		Console.WriteLine("2 - Mostrar jogos");
		Console.WriteLine("3 - Buscar jogo pelo título");
		Console.WriteLine("4 - Listar jogos de um console");
		Console.WriteLine("5 - Emprestar jogo");
		Console.WriteLine("6 - Devolver jogo");
		Console.WriteLine("7 - Mostrar jogos emprestados");
		Console.WriteLine("0 - Sair");

		Console.Write("Escolha uma opção: ");

		return int.Parse(Console.ReadLine());
	}

	static void Main()
	{
		List<Jogo> listaJogos = new List<Jogo>();

		int opcao = 0;

		do
		{
			opcao = menu();

			switch (opcao)
			{
			case 1:
				addJogo(listaJogos);
				break;

			case 2:
				mostrarJogos(listaJogos);
				break;

			case 3:
				Console.Write("Título do jogo para buscar: ");
				string tituloBuscar = Console.ReadLine();

				bool encontrado = buscarJogo(listaJogos, tituloBuscar);

				if (!encontrado)
					Console.WriteLine("Jogo não encontrado");

				break;

			case 4:
				Console.Write("Digite o console: ");
				string nomeConsole = Console.ReadLine();

				bool listado = listarJogosConsole(listaJogos, nomeConsole);

				if (!listado)
					Console.WriteLine("Nenhum jogo encontrado nesse console");

				break;

			case 5:
				Console.Write("Título do jogo para emprestar: ");
				string tituloEmprestar = Console.ReadLine();

				bool emprestado = emprestarJogo(listaJogos, tituloEmprestar);

				if (emprestado)
					Console.WriteLine("O jogo foi emprestado");
				else
					Console.WriteLine("Jogo não encontrado ou já emprestado");

				break;

			case 6:
				Console.Write("Título do jogo para devolver: ");
				string tituloDevolver = Console.ReadLine();

				bool devolvido = devolverJogo(listaJogos, tituloDevolver);

				if (devolvido)
					Console.WriteLine("Jogo devolvido com sucesso!");
				else
					Console.WriteLine("Jogo ñ encontrado ou ñ está emprestado");

				break;

			case 7:
				bool haEmprestados = mostrarEmprestados(listaJogos);

				if (!haEmprestados)
					Console.WriteLine("Nenhum jogo emprestado");

				break;

			case 0:
				break;

			default:
				Console.WriteLine("Opção inválida!");
				break;
			}

			if (opcao != 0)
			{
				Console.WriteLine("\nPressione qualquer tecla para continuar...");
				Console.ReadKey();
				Console.Clear();
			}

		} while (opcao != 0);
	}
}

