using Catalogo_series.Application.Model;
using Catalogo_series.Application.Repository;
using System;

namespace Catalogo_series.Application.Controller
{
    public class SerieController : SerieRepository, ISerieCRUD
    {
        public void InsertSerie()
        {
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Ano: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Descrição: ");
            string description = Console.ReadLine();
            Console.WriteLine("Selecione o gênero:");

            for (int i = 1; i <= Enum.GetValues(typeof(Genre)).Length; i++)
            {
                Console.WriteLine($"{i} - {Enum.GetName((Genre)i)}");
            }

            Console.Write("Digite o ID da série: ");
            int genre = int.Parse(Console.ReadLine());

            Add(
                new Serie
                (
                    id: List().Count,
                    name: name,
                    year: year,
                    description: description,
                    genre: ((Genre)genre).ToString(),
                    excluded: false
                )
            );
        }

        public void ListSerie()
        {
            foreach (var serie in List())
            {
                if (serie.Excluded == false)
                {
                    Console.WriteLine($"{serie.Id}: {serie.Name}");
                }
            }

            if (List().Count == 0)
            {
                Console.WriteLine("Nenhuma série disponível");
            }

            Console.ReadLine();
        }

        public void CleanScreen()
        {
            Console.Clear();
        }

        public void ViewSerie()
        {
            Console.Write("Digite o ID da série: ");
            int id = int.Parse(Console.ReadLine());
            if (List()[id].Excluded)
            {
                Console.WriteLine("Série indisponivel");
            }
            else
            {
                Console.WriteLine($"id: {List()[id].Id}");
                Console.WriteLine($"nome: {List()[id].Name}");
                Console.WriteLine($"ano: {List()[id].Year}");
                Console.WriteLine($"descricão: {List()[id].Description}");
                Console.WriteLine($"gênero: {List()[id].Genre}");
            }

            Console.ReadLine();
        }

        public void DeleteSerie()
        {
            Console.Write("Digite o ID da série: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Tem certeza que deseja deletar essa série (s/n)");
            string confirmation = Console.ReadLine().ToUpper();
            if (confirmation == "Y")
            {
                Delete(id, true);
            }

        }

        public void UpdateSerie()
        {
            Console.Write("Digite o ID da série: ");
            var id = int.Parse(Console.ReadLine());
            var element = List()[id];

            Console.Write("Nome(Deixe vazio para manter o nome atual): ");
            String name = Console.ReadLine();

            Console.WriteLine("Selecione o gênero:");

            for (int i = 1; i <= Enum.GetValues(typeof(Genre)).Length; i++)
            {
                Console.WriteLine($"{i} - {Enum.GetName((Genre)i)}");
            }

            Console.Write("Gênero ID(Deixe vazio para manter o gênero atual): ");
            string genre = Console.ReadLine();

            Console.Write("Descrição(Deixe vazio para manter a descrição atual): ");
            string description = Console.ReadLine();

            Console.Write("Ano(Deixe vazio para manter o ano atual): ");
            string year = Console.ReadLine();

            if (!String.IsNullOrEmpty(name))
            {
                element.Name = name;
            }
            if (!String.IsNullOrEmpty(description))
            {
                element.Description = description;
            }
            if (!String.IsNullOrEmpty(year.ToString()))
            {
                element.Year = int.Parse(year);
            }
            if (!String.IsNullOrEmpty(genre.ToString()))
            {
                int genreValue = int.Parse(genre);
                element.Genre = ((Genre)genreValue).ToString();
            }
        }
    }
}
