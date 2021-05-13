using System;

namespace Passagens_Aereas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = null;
            string[] origem = null;
            string[] destino = null;
            string[] data = null;
            int tamanhosArray = 5;
            nome = new string[tamanhosArray];
            origem = new string[tamanhosArray];
            destino = new string[tamanhosArray];
            data = new string[tamanhosArray];
            bool verificarSenha = false;
            bool repetirSenha = true;
            int c = 0;

            do
            {
                Console.WriteLine("Digite sua senha");
                string senha = Console.ReadLine();

                do
                {
                    if (senha == "123456")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(@"Qual opção você quer realizar:
                    
                    1 - Cadastrar passagem
                    2 - Listar Passagens
                    0 - Sair
                    ");
                        string opcao = Console.ReadLine();

                        switch (opcao)
                        {
                            case "1":
                                Console.WriteLine("Cadastre suas passagens; Máximo de 5 passagens");

                                bool novoCadrasto = true;

                                do
                                {
                                    if (c < tamanhosArray)
                                    {
                                        Console.WriteLine($"Digite o nome");
                                        nome[c] = Console.ReadLine();

                                        Console.WriteLine($"Digite a origem");
                                        origem[c] = Console.ReadLine();

                                        Console.WriteLine($"Digite o destino");
                                        destino[c] = Console.ReadLine();

                                        Console.WriteLine($"Digite a data no seguinte formato DD/MM/AA");
                                        data[c] = Console.ReadLine();

                                        Console.WriteLine("Deseja cadastrar uma nova passagem; N para não e S para sim");
                                        string novaPassagem = Console.ReadLine().ToUpper();

                                        c++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Máximo de cadastros alcançados");
                                        novoCadrasto = false;
                                    }

                                    // if (c == nome.Length)
                                    // {
                                    //     Console.WriteLine("Número máximo de cadastros alcançado");
                                    //     novoCadrasto = false;
                                    // }
                                    // else
                                    // {
                                    //     if (novaPassagem == "N")
                                    //     {
                                    //         novoCadrasto = false;
                                    //     }
                                    //     else
                                    //     {
                                    //         Console.WriteLine("Ok,faremos um novo cadrasto");
                                    //     }
                                    // }
                                } while (novoCadrasto == true);

                                break;
                            case "2":
                                for (var i = 0; i < c; i++)
                                {
                                    Console.WriteLine($"{i + 1}° Cadastro: {nome[i]} / {origem[i]} / {destino[i]} / {data[i]}");
                                }
                                break;
                            case "0":
                                Console.WriteLine("Adeus");
                                verificarSenha = true;
                                repetirSenha = false;
                                break;
                            default:
                                Console.WriteLine("Opção Invalida");
                                break;
                        }

                        // verificarSenha = true;
                    }
                    else
                    {
                        Console.WriteLine("Senha incorreta, tente novamente");
                        repetirSenha = false;
                    }
                } while (repetirSenha == true);

            } while (verificarSenha == false);
        }
    }
}
