using System;

namespace gestaoDeEquipamentos.ConsoleApp
{
    internal class Program
    {
        static string[] nomeEquipamentos = new string[1000];
        static string[] precoEquipamentos = new string[1000];
        static string[] numerodeSerie = new string[1000];
        static string[] dataDeFabricacao = new string[1000];
        static string[] fabricantes = new string[1000];
        static string[] equipamentosChamados = new string[1000];
        static string[] numeroDeChamados = new string[1000];
        static string[] tituloDeChamados  = new string[1000];
        static string[] dataAberturaChamados = new string[1000];
        static string[] descricaoDeChamados = new string[1000];



        static int contadorEquipamentos = 0;
        static int contadorChamados = 0;

        //método do primeiro menu
        static void Main(string[] args)
        {
            menuPrincipal();
        }


        static void menuPrincipal()
        {
            string opcao = "0";

            while (opcao != "3")
            {
                Console.Write("Digite a opção desejada:\n" +
                    "1 para o menu de equipamentos.\n" +
                    "2 para o menu de manutenção.\n" +
                    "3 para sair.\n");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    equipamentos();
                }
                else if (opcao == "2")
                {
                    chamados();
                }
                else if (opcao == "3")
                {
                    break;
                }
                else
                    Console.WriteLine("Opção inválida, tente novamente.");

                return;
            }
        }


        //métodos para os equipamentos
        static void equipamentos()
        {
            while (true)
            {
                Console.Write("Digite a opção desejada:\n" +
                    "1 para registrar um equipamento.\n" +
                    "2 para visualizar todos os equipamentos.\n" +
                    "3 para editar um equipamento.\n" +
                    "4 para excluir um equipamento.\n" +
                    "5 para voltar ao menu principal.\n");

                int opcaoEquipammento = Convert.ToInt32(Console.ReadLine());

                switch (opcaoEquipammento)
                {
                    case 1:
                    //if (opcaoEquipammento == 1)
                    
                        registrarEquipamento();
                        return;
                    

                    case 2:
                    //else if (opcaoEquipammento == 2)
                    
                        visualizarEquipamentos();
                        return;
                    


                    case 3:
                    //else if (opcaoEquipammento == 3)
                    
                        editarEquipamento();
                        return;
                    


                    case 4:
                    //else if (opcaoEquipammento == 4)
                    
                        excluirEquipamento();
                        return;
                    

                    //else if (opcaoEquipammento == 5)
                    case 5:
                       Console.Clear();
                       menuPrincipal();
                       break;
                }
            }

        }



        static void registrarEquipamento()
        {
            Console.WriteLine("Digite o nome do equipamento (min. 6 caracteres).");
            string nome = Console.ReadLine();
            nomeEquipamentos[contadorEquipamentos] = nome;

            Console.WriteLine("Digite o preço de aquisição desse equipamento.");
            string preco = Console.ReadLine();
            precoEquipamentos[contadorEquipamentos] = preco;

            Console.WriteLine("Cadastre o número de série do equipamento.");
            string numDeSerieEquipamento = Console.ReadLine();
            numerodeSerie[contadorEquipamentos] = numDeSerieEquipamento;

            Console.WriteLine("Cadastre a data de fabricação do equipamento.");
            string dataEquipamento = Console.ReadLine();
            dataDeFabricacao[contadorEquipamentos] = dataEquipamento;

            Console.WriteLine("Cadastre o fabricante do equipamento.");
            string fabricanteEquipamento = Console.ReadLine();
            fabricantes[contadorEquipamentos] = fabricanteEquipamento;

            contadorEquipamentos++;
            Console.Clear();

            equipamentos();
        }

        static void visualizarEquipamentos()
        {
            for (int i = 0; i < contadorEquipamentos; i++)
            {
                Console.WriteLine(tituloDeChamados[i] + " " + equipamentosChamados[i] + " "
                    + dataAberturaChamados[i] + " " + descricaoDeChamados[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
            chamados();
        }

        static void editarEquipamento()
        {
            Console.Clear();
            Console.WriteLine("Digite o número de série do equipamento você deseja editar:");
            string equipamentoParaEditar = Console.ReadLine();

            for (int i = 0; i < contadorEquipamentos; i++)
            {
                if (equipamentoParaEditar == numerodeSerie[i])
                {
                    Console.WriteLine(nomeEquipamentos[i] + " " + numerodeSerie[i] + " " 
                        + precoEquipamentos[i] + " " + dataDeFabricacao[i] + " " + fabricantes[i]);
                    Console.WriteLine();
                    while (true)
                    {
                        Console.WriteLine("O que você deseja editar:");
                        int itemParaEditar = Convert.ToInt16(Console.ReadLine());

                        switch (itemParaEditar)
                        {
                            case 1:
                                Console.WriteLine("Digite o novo nome:");
                                string nomeNovo = Console.ReadLine();
                                nomeEquipamentos[i] = nomeNovo;
                                break;
                            case 2:
                                Console.WriteLine("Digite o novo número de série:");
                                string numeroNovo = Console.ReadLine();
                                numerodeSerie[i] = numeroNovo;
                                break;
                            case 3:
                                Console.WriteLine("Digite o novo preço:");
                                string precoNovo = Console.ReadLine();
                                precoEquipamentos[i] = precoNovo;
                                break;
                            case 4:
                                Console.WriteLine("Digite a nova data de fabricação:");
                                string dataNova = Console.ReadLine();
                                dataDeFabricacao[i] = dataNova;
                                break;
                            case 5:
                                Console.WriteLine("Digite o novo fabricante:");
                                string fabricanteNovo = Console.ReadLine();
                                fabricantes[i] = fabricanteNovo;
                                break;
                        }
                        Console.WriteLine("Digite 1 para fazer uma nova edição neste equipamento.");
                        Console.WriteLine("Digite 2 para editar outro equipamento.");
                        Console.WriteLine("Digite 3 para voltar ao menu principal.");
                        int opcaoMenuFinalEdicao = Convert.ToInt16(Console.ReadLine());

                        
                        if (opcaoMenuFinalEdicao == 1)
                            continue;
                        
                        else if (opcaoMenuFinalEdicao == 2)
                        {
                            editarEquipamento();
                            break;
                        }

                        else if (opcaoMenuFinalEdicao == 3)
                        {
                            menuPrincipal();
                            break;
                        }
                    }

                }
            }
        }

        static void excluirEquipamento()
        {
            Console.WriteLine("Digite o número de série do equipamento para excluir.");
            string serieParaExcluir = Console.ReadLine();

            for (int i = 0; i < contadorEquipamentos; i++)
            {
                if (serieParaExcluir == numerodeSerie[i])
                {
                    Array.Clear(numerodeSerie, i, 1);
                    Array.Clear(nomeEquipamentos, i, 1);
                    Array.Clear(precoEquipamentos, i, 1);
                    Array.Clear(fabricantes, i, 1);
                    Array.Clear(dataDeFabricacao, i, 1);
                }
                
            }
        }

        //métodos para os chamados
        static void chamados()
        {
            while (true)
            {
                Console.Write("Digite a opção desejada:\n" +
                    "1 para registrar um novo chamado.\n" +
                    "2 para visualizar os chamados abertos.\n" +
                    "3 para excluir um chamado.");

                int opcaoChamado = Convert.ToInt32(Console.ReadLine());

                switch (opcaoChamado)
                {
                    case 1:
                        Console.Clear();
                        registrarChamado();
                        break;

                    case 2:
                        verChamados();
                        break;

                    case 3:
                        deletarChamado();
                        break;
                }
                return;
            }
        }

        static void registrarChamado()
        {
            Console.WriteLine("Registro de um novo chamado.");
            Console.WriteLine("Digite o nome do equipamento:");
            string nomeEquipamentoChamado = Console.ReadLine();
            equipamentosChamados[contadorChamados] = nomeEquipamentoChamado;

            Console.WriteLine("Digite o título do chamado:");
            string tituloDeUmChamado = Console.ReadLine();
            tituloDeChamados[contadorChamados] = tituloDeUmChamado;

            Console.WriteLine("Informe a descrição do chamado:");
            string descricaoDeUmChamado = Console.ReadLine();
            descricaoDeChamados[contadorChamados] = descricaoDeUmChamado;

            Console.WriteLine("Informe a data de abertura do chamado:");
            string aberturaDeUmChamado = Console.ReadLine();
            dataAberturaChamados[contadorChamados] = aberturaDeUmChamado;

            contadorChamados++;
            Console.Clear();

            chamados();
            
        }

        static void verChamados()
        {
            for (int i = 0; i < contadorChamados; i++)
            {
                Console.WriteLine(tituloDeChamados[i] + " " + equipamentosChamados[i] + " "
                    + dataAberturaChamados[i] + " " + descricaoDeChamados[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
            chamados();
        }

        static void deletarChamado()
        {
            Console.WriteLine("Digite o número do chamado para excluir.");
            string serieParaExcluir = Console.ReadLine();

            for (int i = 0; i < contadorEquipamentos; i++)
            {
                if (serieParaExcluir == numerodeSerie[i])
                {
                    Array.Clear(numerodeSerie, i, 1);
                    Array.Clear(nomeEquipamentos, i, 1);
                    Array.Clear(precoEquipamentos, i, 1);
                    Array.Clear(fabricantes, i, 1);
                    Array.Clear(dataDeFabricacao, i, 1);
                }

            }

            Console.Clear();
            chamados();

        }


    }
}


