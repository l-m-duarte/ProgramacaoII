using System;
using System.Collections.Generic;

//o código inteiro está num único arquivo porque eu usei o online GBD para escrever tudo

public class Livro
{
	public string titulo;
	public string autor;
	public int ano;
	public int prateleira;
}


class Program
{
	static void addLivro(List<Livro> listaLivros)
	{
		Livro novoLivro = new Livro();
		Console.WriteLine("Entre com os dados do Livro");

		Console.Write("Título do livro: ");
		novoLivro.titulo = Console.ReadLine();
		Console.Write("Autor do livro: ");
		novoLivro.autor = Console.ReadLine();
		Console.Write("Ano do livro: ");
		novoLivro.ano = int.Parse(Console.ReadLine());
		Console.Write("Prateleira do livro: ");
		novoLivro.prateleira = int.Parse(Console.ReadLine());

		listaLivros.Add(novoLivro);
	}

	static void mostrarLivros(List<Livro> listaLivros)
	{
		Console.WriteLine("--------------------Livros Cadastrados");
		for (int i = 0; i < listaLivros.Count; i++)
		{
			Console.WriteLine($"-------------------Dados do Livro {i + 1}");
			Console.WriteLine($"Título: {listaLivros[i].titulo}");
			Console.WriteLine($"Autor: {listaLivros[i].autor}");
			Console.WriteLine($"Ano: {listaLivros[i].ano}");
			Console.WriteLine($"Prateleira: {listaLivros[i].prateleira}");
		}
	}

	static bool buscarLivro(List<Livro> listaLivros, string tituloLivro)
	{
		bool encontrado = false;
		for (int i = 0; i < listaLivros.Count; i++)
		{
			if (listaLivros[i].titulo.ToUpper().Contains(tituloLivro.ToUpper()))
			{
				Console.WriteLine("--------------------------Livro");
				Console.WriteLine($"Título: {listaLivros[i].titulo}");
				Console.WriteLine($"Prateleira: {listaLivros[i].prateleira}");

				encontrado = true;
			}
		}
		return encontrado;
	}

	static bool mostrarLivrosMaisNovos(List<Livro> listaLivros, int anoLido)
	{
		bool encontrado = false;
		for (int i = 0; i < listaLivros.Count; i++)
		{
			if (listaLivros[i].ano > anoLido)
			{
				Console.WriteLine("-------------------------------Livro");
				Console.WriteLine($"Título: {listaLivros[i].titulo}");
				Console.WriteLine($"Autor: {listaLivros[i].autor}");
				Console.WriteLine($"Ano: {listaLivros[i].ano}");
				Console.WriteLine($"Prateleira: {listaLivros[i].prateleira}");

				encontrado = true;
			}
		}
		return encontrado;
	}

	static int menu()
	{
		Console.WriteLine("-------------------------------SISTEMA DE CONTROLE DE BIBLIOTECA-------------------------------");
		Console.WriteLine("1 - Cadastrar livro");
		Console.WriteLine("2 - Mostrar livros");
		Console.WriteLine("3 - Buscar livro pelo título");
		Console.WriteLine("4 - Mostrar livros mais novos que um ano");
		Console.WriteLine("0 - Sair");
		Console.Write("Escolha uma opção: ");
		return int.Parse(Console.ReadLine());
	}

	static void Main()
	{
		List<Livro> listaLivros = new List<Livro>();
		int opcao = 0;
		do
		{
			opcao = menu();
			switch (opcao)
			{
			case 1:
				addLivro(listaLivros);
				break;
			case 2:
				mostrarLivros(listaLivros);
				break;
			case 3:
				Console.Write("Título do livro para buscar: ");
				string tituloLivro = Console.ReadLine();

				bool encontrado = buscarLivro(listaLivros, tituloLivro);
				if (!encontrado)
					Console.WriteLine("Livro ñ encontrado");
				break;
			case 4:
				Console.Write("Digite o ano: ");
				int anoLido = int.Parse(Console.ReadLine());

				bool maisNovos = mostrarLivrosMaisNovos(listaLivros, anoLido);
				if (!maisNovos)
					Console.WriteLine("Nenhum livro mais novo que o ano");
				break;
			case 0:
				break;
			}
			Console.ReadKey();
			Console.Clear();
		} while (opcao != 0);
	}
}
