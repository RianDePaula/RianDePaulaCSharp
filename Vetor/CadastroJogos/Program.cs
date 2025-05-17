using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroJogos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vetJogos = new string[3];

            do
            {

                Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

░░░░░██╗░█████╗░░██████╗░░█████╗░░██████╗
░░░░░██║██╔══██╗██╔════╝░██╔══██╗██╔════╝
░░░░░██║██║░░██║██║░░██╗░██║░░██║╚█████╗░
██╗░░██║██║░░██║██║░░╚██╗██║░░██║░╚═══██╗
╚█████╔╝╚█████╔╝╚██████╔╝╚█████╔╝██████╔╝
░╚════╝░░╚════╝░░╚═════╝░░╚════╝░╚═════╝░");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");


                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Consultar");
                Console.WriteLine("3 - Atualizar");
                Console.WriteLine("4 - Excluir");

                int opcao = int.Parse(Console.ReadLine());





                if (opcao == 1)
                {
                    for (int i = 0; i < vetJogos.Length; i++)
                    {
                        Console.WriteLine($"Informe o {i + 1}° nome do jogo: ");
                        vetJogos[i] = Console.ReadLine();
                    }
                    Console.WriteLine("Para continuar, pressione a tecla enter ");
                    Console.ReadKey();
                }


                else if (opcao == 2)
                {
                    for (int i = 0; i < vetJogos.Length; i++)
                    {
                        Console.WriteLine($"Posição: {i} | Nome do jogo: {vetJogos[i]} ");
                    }
                    Console.WriteLine("Para continuar, pressione a tecla enter ");
                    Console.ReadKey();

                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Informe qual indice deseja mudar:(1, 2, 3) ");
                    int indice = int.Parse(Console.ReadLine());
                    if (indice == 1)
                    {
                        Console.WriteLine($"Coloque o nome que voce quer para substituir {vetJogos[0]}");
                        vetJogos[0] = Console.ReadLine();
                    }
                    else if (indice == 2)
                    {
                        Console.WriteLine($"Coloque o nome que voce quer para substituir {vetJogos[1]}");
                        vetJogos[1] = Console.ReadLine();
                    }
                    else if (indice == 3)
                    {
                        Console.WriteLine($"Coloque o nome que voce quer para substituir {vetJogos[2]}");
                        vetJogos[2] = Console.ReadLine();
                    }
                }
                else if (opcao == 4)
                {
                    Console.WriteLine("Informe qual indice deseja excluir:(1, 2, 3) ");
                    int indice = int.Parse(Console.ReadLine());
                    if (indice == 1)
                    {
                        vetJogos[0] = ("");

                    }
                    else if (indice == 2)
                    {

                        vetJogos[1] = ("");
                    }
                    else if (indice == 3)
                    {

                        vetJogos[2] = ("");
                    }
                    
                }
                else if (opcao != 1 || opcao != 2 || opcao != 3 || opcao != 4)
                {
                    Console.WriteLine("Número não reconhecido ");
                    Console.WriteLine("Para continuar, pressione a tecla enter ");
                    Console.ReadKey();
                }
                Console.Clear();
            } while (true);
            
        }
    }
}
