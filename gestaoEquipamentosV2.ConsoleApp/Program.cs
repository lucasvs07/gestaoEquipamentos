using System;

namespace gestaoDeEquipamentos.ConsoleApp
{
    internal class Program
    {
        static string[] nomeEquipamentos = new string[1000];
        static decimal[] precoEquipamentos = new decimal[1000];
        static string[] numerodeSerie = new string[1000];
        static DateTime[] dataDeFabricacao = new DateTime[1000];
        static string[] fabricantes = new string[1000];

        static string[] equipamentosChamados = new string[1000];
        static string[] numeroDeChamados = new string[1000];
        static string[] tituloDeChamados = new string[1000];
        static string[] dataAberturaChamados = new string[1000];
        static string[] descricaoDeChamados = new string[1000];
        
        static string[] nomeUsuarios = new string[1000];
        static string[] emailUsuarios = new string[1000];
        static string[] telefoneUsuarios = new string[1000];
        static string[] nomeResponsaveisCadaChamado = new string[1000];
        




        static int contadorEquipamentos = 0;
        static int contadorChamados = 0;
        //static int contadorUsuarios = 0;

        //método do primeiro menu
        static void Main(string[] args)
        {
            menuPrincipal();
        }


        static void menuPrincipal()
        {
            string opcao = "0";

            while (opcao != "4")
            {
                Console.Write("Digite a opção desejada:\n" +
                    "1 para o menu de equipamentos.\n" +
                    "2 para o menu de manutenção.\n" +
                    "3 para o menu de solicitantes.\n" +
                    "4 para sair.\n");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    menuEquipamentos();
                }
                else if (opcao == "2")
                {
                    chamados();
                }
                else if (opcao == "3")
                {
                    Console.WriteLine("responsaveis()");
                }
                else if (opcao == "4")
                {
                    break;
                }
                else
                    Console.WriteLine("Opção inválida, tente novamente.");

                return;
            }
        }


        //métodos para os equipamentos
        static void menuEquipamentos()
        {
            Console.Clear();

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

                        registrarEquipamento();

                        return;

                    case 2:

                        visualizarEquipamentos();

                        return;

                    case 3:

                        editarEquipamento();

                        return;

                    case 4:

                        excluirEquipamento();


                        return;

                    case 5:

                        Console.Clear();
                        menuPrincipal();

                        break;
                }
            }

        }



        static void registrarEquipamento()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Digite o nome do equipamento (min. 6 caracteres).");
                string nome = Console.ReadLine();

                char[] nomeArray = nome.ToCharArray();

                if (nomeArray.Length < 6)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("Nome de equipamento deve ter 6 caracteres.");

                    Console.ResetColor();

                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadKey();

                    continue;
                }

                else
                    nomeEquipamentos[contadorEquipamentos] = nome;
                break;
            }

                Console.WriteLine("Cadastre o preço de aquisição desse equipamento.");
                decimal preco = Convert.ToDecimal(Console.ReadLine());
                precoEquipamentos[contadorEquipamentos] = preco;

                Console.WriteLine("Cadastre o número de série do equipamento.");
                string numDeSerieEquipamento = Console.ReadLine();
                numerodeSerie[contadorEquipamentos] = numDeSerieEquipamento;

                Console.WriteLine("Cadastre a data de fabricação do equipamento.");
                DateTime dataEquipamento = Convert.ToDateTime(Console.ReadLine());
                dataDeFabricacao[contadorEquipamentos] = dataEquipamento;

                Console.WriteLine("Cadastre o fabricante do equipamento.");
                string fabricanteEquipamento = Console.ReadLine();
                fabricantes[contadorEquipamentos] = fabricanteEquipamento;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nEquipamento " + numDeSerieEquipamento + " cadastrado com sucesso.");
            Console.ResetColor();

                contadorEquipamentos++;

            while (true)
            {
                
                Console.Write("\nDigite 1 para registrar um novo equipamento e 2 para voltar ao menu anterior.\n");
                string opcao = Console.ReadLine();

                if (opcao != "1" && opcao != "2")
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write("\nOpção Inválida.");
                    Console.ResetColor();

                    Console.Write("\nPressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    continue;
                }

                else if (opcao == "1")
                {
                    registrarEquipamento();
                    break;
                }

                else if (opcao == "2")
                {
                    Console.Clear();
                    menuEquipamentos();
                    break;
                }
                
            }

        }

        static void visualizarEquipamentos()
        {
            Console.Clear();

            for (int i = 0; i < contadorEquipamentos; i++)
            {
                Console.WriteLine(numerodeSerie[i] + " " + nomeEquipamentos[i] + " "
                    + precoEquipamentos[i] + " " + dataDeFabricacao[i] + " " + fabricantes[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
            menuEquipamentos();
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
                    Console.WriteLine(numerodeSerie[i] + " " + nomeEquipamentos[i] + " "
                        + precoEquipamentos[i] + " " + dataDeFabricacao[i] + " " + fabricantes[i]);
                    Console.WriteLine();
                    while (true)
                    {
                        Console.Write("O que você deseja editar:\n" +
                            "1 para editar o número de série do equipamento.\n" +
                            "2 para editar o nome do equipamento.\n" +
                            "3 para editar o preço.\n" +
                            "4 para editar a data de fabricação.\n" +
                            "5 para editar o fabricante.\n");
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
                                decimal precoNovo = Convert.ToDecimal(Console.ReadLine());
                                precoEquipamentos[i] = precoNovo;
                                break;
                            case 4:
                                Console.WriteLine("Digite a nova data de fabricação:");
                                DateTime dataNova = Convert.ToDateTime(Console.ReadLine());
                                dataDeFabricacao[i] = dataNova;
                                break;
                            case 5:
                                Console.WriteLine("Digite o novo fabricante:");
                                string fabricanteNovo = Console.ReadLine();
                                fabricantes[i] = fabricanteNovo;
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("\nOpção inválida, tente novamente.\n");
                                Console.ResetColor();
                                return;

                        }
                        //  break;

                        // }
                        while (true)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Digite 1 para fazer uma nova edição neste equipamento.");
                            Console.WriteLine("Digite 2 para editar outro equipamento.");
                            Console.WriteLine("Digite 3 para voltar ao menu principal.");
                            int opcaoMenuFinalEdicaoEquipamentos = Convert.ToInt16(Console.ReadLine());

                            switch (opcaoMenuFinalEdicaoEquipamentos)
                            {
                                //if (opcaoMenuFinalEdicaoEquipamentos == 1)
                                case 1:
                                    continue;

                                //else if (opcaoMenuFinalEdicaoEquipamentos == 2)
                                case 2:
                                    //{
                                    editarEquipamento();
                                    break;
                                //}

                                //else if (opcaoMenuFinalEdicaoEquipamentos == 3)
                                case 3:
                                    //{
                                    menuPrincipal();
                                    break;

                                default:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Opção inválida, tente novamente.");
                                    Console.ResetColor();

                                    break;
                            }
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
                Console.Clear();

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
            Console.Clear();

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

            Console.WriteLine("Informe o nome responsável pela abertura do chamado:");
            string responsavelChamado = Console.ReadLine();
            nomeResponsaveisCadaChamado[contadorChamados] = responsavelChamado;


            contadorChamados++;
            Console.Clear();

            chamados();

        }

        static void verChamados()
        {
            Console.Clear();

            for (int i = 0; i < contadorChamados; i++)
            {
                Console.WriteLine(tituloDeChamados[i] + " " + equipamentosChamados[i] + " "
                    + dataAberturaChamados[i] + " " + descricaoDeChamados[i] + " " + nomeResponsaveisCadaChamado[i]);

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
            Console.Clear();

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

        //métodos para os responsáveis.
        /*
        static void responsaveis()
        {
            Console.Clear();

            Console.Write("Digite a opção desejada.\n" +
                "1 para cadastrar novo responsável.\n" +
                "2 para visualizar a lista de responsáveis pela manutenção.\n" +
                "3 para editar os dados de um responsável pela manutenção cadastrado.\n");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    cadastrarResponsavel();
                    break;

                case "2":
                    visualizarListadeResponsaveis();
                    break;

                case "3":
                    editarResponsavel();
                    break;

                case "4":
                    Console.Clear();
                    menuPrincipal();
                    break;
            }

        }

        static void cadastrarResponsavel()
        {
            Console.Clear();

            Console.WriteLine("Digite o nome do novo usuário:");
            string nomeDeUsuario = Console.ReadLine();
            nomeUsuarios[contadorUsuarios] = nomeDeUsuario;

            Console.WriteLine("Digite o e-mail do usuário " + nomeDeUsuario + ".");
            string emailDoUsuario = Console.ReadLine();
            emailUsuarios[contadorUsuarios] = emailDoUsuario;

            Console.WriteLine("Digite o número de telefone do usuário " + nomeDeUsuario + ".");
            string telefoneDoUsuario = Console.ReadLine();
            telefoneUsuarios[contadorUsuarios] = telefoneDoUsuario;

            Console.Clear();

            responsaveis();

        }

        static void visualizarListadeResponsaveis()
        {
            Console.Clear();

            for (int i = 0; i < contadorUsuarios; i++)
            {
                Console.WriteLine(nomeUsuarios[i] + " " + emailUsuarios[i] + " "
                    + telefoneUsuarios[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
            chamados();
        }

        static void editarResponsavel()
        {
            Console.Clear();

            Console.WriteLine("Digite o nome do usuário que você deseja editar:");
            string usuarioParaEditar = Console.ReadLine();

            for (int i = 0; i < contadorUsuarios; i++)
            {
                if (usuarioParaEditar == nomeUsuarios[i])
                {
                    Console.WriteLine(nomeUsuarios[i] + " " + emailUsuarios[i] + " "
                        + telefoneUsuarios[i]);
                    Console.WriteLine();
                    while (true)
                    {
                        Console.Write("O que você deseja editar?\n" +
                                      "1 para nome.\n" +
                                      "2 para e-mail.\n" +
                                      "3 para telefone.\n");
                        int itemParaEditar = Convert.ToInt16(Console.ReadLine());

                        switch (itemParaEditar)
                        {
                            case 1:
                                Console.WriteLine("Digite o novo nome:");
                                string nomeNovo = Console.ReadLine();
                                nomeUsuarios[i] = nomeNovo;
                                break;
                            case 2:
                                Console.WriteLine("Digite o novo e-mail.");
                                string emailNovo = Console.ReadLine();
                                emailUsuarios[i] = emailNovo;
                                break;
                            case 3:
                                Console.WriteLine("Digite o novo telefone:");
                                string telefoneNovo = Console.ReadLine();
                                telefoneUsuarios[i] = telefoneNovo;
                                break;
                        }
                        Console.WriteLine();
                        Console.WriteLine("Digite 1 para fazer uma nova edição neste usuário.");
                        Console.WriteLine("Digite 2 para editar outro usuário.");
                        Console.WriteLine("Digite 3 para voltar ao menu principal.");
                        int opcaoMenuFinalEdicao = Convert.ToInt16(Console.ReadLine());


                        if (opcaoMenuFinalEdicao == 1)
                            continue;

                        else if (opcaoMenuFinalEdicao == 2)
                        {
                            editarResponsavel();
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

        */
    }
}


