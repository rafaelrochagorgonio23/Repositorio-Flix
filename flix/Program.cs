using System;
using System.Collections.Generic;

namespace flix
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        

        static void Main(string[] args)
        {
           string opcaoUsuario = ObterOpcaoUsuario();

           while (opcaoUsuario.ToUpper() != "X")
           {
               switch (opcaoUsuario)
               {
                   case "1":
                            ListarSerie();
                            break;
                    case "2":
                            InserirSerie();
                            break;
                    case "3":
                            AtualizarSerie();
                            break;
                    case "4":
                            ExcluirSerie();                 
                            break;
                    case "5":
                            VisualizarSerie();
                            break;
                    case "C":
                            Console.Clear();
                            break;
                   default:
                            throw new ArgumentOutOfRangeException();
               }

               opcaoUsuario = ObterOpcaoUsuario();
           }
                Console.WriteLine("Obrigado por utilizar nossos serviços.");
                Console.ReadLine();
        }

        private static void VisualizarSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceserie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaporId(indiceserie);

            Console.WriteLine(serie);
        }

        private static void ExcluirSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceserie = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceserie);
        }

        private static void AtualizarSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceserie = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(genero)))
            {
                Console.WriteLine("{0} - {1}",i,Enum.GetName(typeof(genero), i));

            }

            Console.Write("Digite o genero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de ínicio da série: ");
            int entradaAno = int.Parse(Console.ReadLine());
            /*
            Serie AtualizarSerie = new Serie(Id: indiceserie, genero: (genero)entradaGenero, Titulo: entradaTitulo, Ano: entradaAno);

            repositorio.Atualiza(indiceserie,AtualizarSerie);
            */
        }

        private static void ListarSerie()
        {
            Console.WriteLine("Listar séries");

            var lista = repositorio.Lista();

            if(lista.Count == 0 )
            {
                Console.WriteLine("Nenuma série cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();
                
                //condicional ternário
                //Console.WriteLine("#ID {0}: - {1} - {2}", serie.retornaId(), serie.retornoTitulo(), excluido ? "Excluido" : );
                Console.WriteLine("#ID {0}: - {1} - {2}", serie.retornaId(), serie.retornoTitulo(), excluido ? "Excluido" : );
            }
        }

        private static void InserirSerie()
        {
            
            Console.WriteLine("Inserir nova série");

            foreach (var i in Enum.GetValues(typeof(genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(genero),i));
            }

            Console.Write("Digite o genero dentre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de inicio da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            //Cria uma nova série
            /*Serie novaSerie = new Serie(id: repositorio.ProximoId(), 
                                        genero: (genero)entradaGenero),
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            
            repositorio.Insere(novaSerie);
            */
        }


        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu dispor!");
            Console.WriteLine("Informa a opção desejada:");

            Console.WriteLine("1 - Listar Séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

    }
}
