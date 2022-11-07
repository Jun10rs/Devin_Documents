using devindocuments.Classes;
using devindocuments.Menu.MenuEnum;
using devindocuments.Menu.MenuSelecao;
using devindocuments.Relatorios;

var funcionario = new Pessoa();
funcionario.IdFuncionario = 001;
funcionario.Nome = "Devin_House";
funcionario.Endereco = "Rua das Flores";
funcionario.DataNascimento = new DateTime(1988, 06, 12);
funcionario.Filiacao = "Senai";
funcionario.DataAdmissao = new DateTime(2002, 08, 15);

var filtroAtivo = new FiltroListasAtivo();
var filtroSuspenso = new FiltroListaSuspenso();
var filtroTramitacao = new FiltroListaTramitacao();
var alterarStatus = new AlterarStatus();
var alterarItens = new AlterarItens();

NotaFiscal listaNotaFiscal = new NotaFiscal();
LicencaFuncionamento listaLicencaFuncionamento = new LicencaFuncionamento();
Contrato listaContrato = new Contrato();

Console.WriteLine("==================== BEM VINDO AO DEVINDOCUMENTS ====================\n");

Console.WriteLine($"Olá, {funcionario.Nome}!\n");

while (true)
{
    Console.WriteLine($"O que você deseja fazer?\n");
    Console.WriteLine($"1 - Cadastrar documento\n" +
                      $"2 - Listar documento\n" +
                      $"3 - Alterar itens do documento\n" +
                      $"4 - Alterar status do documento\n" +
                      $"0 - Sair do programa");
    var respostaMenu = Console.ReadLine();

    if (respostaMenu != "1" && respostaMenu != "2" && respostaMenu != "3" &&
        respostaMenu != "4" && respostaMenu != "0")
    {
        Console.WriteLine("----- Opção não encontrada. Por favor digite um valor válido -----\n");
    }
    if (respostaMenu == "1")
    {
        Console.WriteLine($"Qual tipo de documento você deseja cadastrar?\n");
        Console.WriteLine($"1 - Nota Fiscal\n" +
                          $"2 - Licenças de funcionamento\n" +
                          $"3 - Contrato");
        string respostaTipoDoc = Console.ReadLine();

        if (respostaTipoDoc != "1" && respostaTipoDoc != "2" && respostaTipoDoc != "3")
        {
            Console.WriteLine("----- Opção não encontrada. Por favor digite um valor válido -----\n");
        }
        else if (respostaTipoDoc == "1")
        {
            Console.WriteLine("Digite o Nome do Estabelecimento");
            string nomeEstabelecimento = Console.ReadLine();

            Console.WriteLine("Digite o CNPJ");
            string cnpj = Console.ReadLine();

            Console.WriteLine($"Selecione o Status do Documento\n");
            Console.WriteLine($"1 - {StatusDocumentoEnum.Ativo}\n" +
                              $"2 - {StatusDocumentoEnum.EmTramitacao}\n" +
                              $"3 - {StatusDocumentoEnum.Suspenso}");
            var statusDocumentoEnum = SelecaoStatusEnum.StatusSelecao(Console.ReadLine());

            Console.WriteLine("Digite o Valor da Nota Fiscal");
            decimal valorNotaFiscal = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Nome do Produto Vendido");
            string nomeProdutoVendido = Console.ReadLine();

            Console.WriteLine($"Selecione o Tipo de Imposto\n");
            Console.WriteLine($"1 - {TipoImpostoEnum.ICMS}\n" +
                              $"2 - {TipoImpostoEnum.IOF}\n" +
                              $"3 - {TipoImpostoEnum.IPI}\n");
            var tipoImpostoEnum = SelecaoImpostoEnum.ImpostoSelecao(Console.ReadLine());

            Console.WriteLine("Digite o Valor do Imposto");
            decimal valorTotalImposto = decimal.Parse(Console.ReadLine());

            NotaFiscal novaNota = new NotaFiscal
            (
                dataAlteracao: null, nomeEstabelecimento: nomeEstabelecimento, cpnj: cnpj,
                statusDocumento: statusDocumentoEnum, idFuncionario: funcionario.IdFuncionario,
                valorNotaFiscal: valorNotaFiscal, nomeProdutoVendido: nomeProdutoVendido,
                tipoImpostoEnum: tipoImpostoEnum, valorTotalImposto: valorTotalImposto
            );
            listaNotaFiscal.CadastrarDocumento(novaNota);
            Console.WriteLine("========== NOTA FISCAL CADASTRADA COM SUCESSO ==========");
            continue;
        }
        else if (respostaTipoDoc == "2")
        {
            Console.WriteLine("Digite o Nome do Estabelecimento");
            string nomeEstabelecimento = Console.ReadLine();

            Console.WriteLine("Digite o CNPJ");
            string cnpj = Console.ReadLine();

            Console.WriteLine($"Selecione o Status do documento\n");
            Console.WriteLine($"1 - {StatusDocumentoEnum.Ativo}\n" +
                              $"2 - {StatusDocumentoEnum.EmTramitacao}\n" +
                              $"3 - {StatusDocumentoEnum.Suspenso}");
            var statusLicencaEnum = SelecaoStatusEnum.StatusSelecao(Console.ReadLine());

            Console.WriteLine("Digite o Endereço");
            string endereco = Console.ReadLine();

            Console.WriteLine($"Selecione a Área de Atuação\n");
            Console.WriteLine($"1 - {AreaAtuacaoEnum.Industrial}\n" +
                              $"2 - {AreaAtuacaoEnum.Agropecuario}\n" +
                              $"3 - {AreaAtuacaoEnum.Metalurgico}\n" +
                              $"4 - {AreaAtuacaoEnum.Tecnologia}\n" +
                              $"5 - {AreaAtuacaoEnum.Outro}\n");
            var selecaoAtuacao = SelecaoAreaAtuacao.AreaAtuacao(Console.ReadLine());

            LicencaFuncionamento novaLicenca = new LicencaFuncionamento
            (
                dataAlteracao: null, nomeEstabelecimento: nomeEstabelecimento, cpnj: cnpj,
                statusDocumento: statusLicencaEnum, idFuncionario: funcionario.IdFuncionario,
                endereco: endereco, areaAtuacaoEnum: selecaoAtuacao
            );
            listaLicencaFuncionamento.CadastrarDocumento(novaLicenca);
            Console.WriteLine("========== LICENÇA CADASTRADA COM SUCESSO ==========");
        }
        else if (respostaTipoDoc == "3")
        {
            Console.WriteLine("Digite o Nome do Estabelecimento");
            string nomeEstabelecimento = Console.ReadLine();

            Console.WriteLine("Digite o CNPJ");
            string cnpj = Console.ReadLine();

            Console.WriteLine($"Selecione o Status do documento\n");
            Console.WriteLine($"1 - {StatusDocumentoEnum.Ativo}\n" +
                              $"2 - {StatusDocumentoEnum.EmTramitacao}\n" +
                              $"3 - {StatusDocumentoEnum.Suspenso}");
            var statusContratoEnum = SelecaoStatusEnum.StatusSelecao(Console.ReadLine());

            Console.WriteLine("Digite a Finalidade");
            string finalidade = Console.ReadLine();

            Console.WriteLine("Digite uma Testemunha");
            string testemunhas = Console.ReadLine();

            Console.WriteLine("Digite a Data de Expiração(ex:dd/MM/yyyy)");
            DateTime dataExpiracao = DateTime.Parse(Console.ReadLine());

            Contrato novoContrato = new Contrato
            (
                dataAlteracao: null, nomeEstabelecimento: nomeEstabelecimento, cpnj: cnpj,
                statusDocumento: statusContratoEnum, idFuncionario: funcionario.IdFuncionario,
                finalidade: finalidade, testemunhas: testemunhas, dataExpiracao: dataExpiracao);
            listaContrato.CadastrarDocumento(novoContrato);
            Console.WriteLine("========== CONTRATO CADASTRADO COM SUCESSO =========");
        }
    }
    else if (respostaMenu == "2")
    {
        while (true)
        {
            Console.WriteLine($"Selecione um tipo de Relatório:\n");
            Console.WriteLine($"1 - Relatório Completo\n" +
                              $"2 - Relatório por Status\n" +
                              $"3 - Relatório por tipo de Documento\n" +
                              $"4 - Total de Relatórios\n" +
                              $"0 - Retorna menu inicial");
            string respostaRelatorio = Console.ReadLine();

            if (respostaRelatorio != "1" && respostaRelatorio != "2" &&
               respostaRelatorio != "3" && respostaRelatorio != "4" && respostaRelatorio != "0")
            {
                Console.WriteLine("----- Opção não encontrada. Por favor digite um valor válido -----\n");
            }
            else if (respostaRelatorio == "1")
            {
                Console.WriteLine("########################## RELATÓRIO COMPLETO ##########################");
                listaNotaFiscal.ListarDocumentos();
                listaLicencaFuncionamento.ListarDocumentos();
                listaContrato.ListarDocumentos();
                Console.WriteLine("########################## FIM RELATÓRIO COMPLETO ##########################");
            }
            else if (respostaRelatorio == "2")
            {
                Console.WriteLine($"Selecione o tipo de Status");
                Console.WriteLine($"1 - Ativo\n" +
                                  $"2 - Em Tramitação\n" +
                                  $"3 - Suspenso");
                string respotaTipoStatus = Console.ReadLine();
                if (respotaTipoStatus != "1" && respotaTipoStatus != "2" && respotaTipoStatus != "3")
                {
                    Console.WriteLine("----- Opção não encontrada. Por favor digite um valor válido -----\n");
                }
                else if (respotaTipoStatus == "1")
                {
                    filtroAtivo.FiltroListaNotas();
                    filtroAtivo.FiltroListaLicenca();
                    filtroAtivo.FiltroListaContrato();
                }

                else if (respotaTipoStatus == "2")
                {
                    filtroTramitacao.FiltroListaNotas();
                    filtroTramitacao.FiltroListaLicenca();
                    filtroTramitacao.FiltroListaContrato();
                }

                else if (respotaTipoStatus == "3")
                {
                    filtroSuspenso.FiltroListaNotas();
                    filtroSuspenso.FiltroListaLicenca();
                    filtroSuspenso.FiltroListaContrato();
                }
            }
            else if (respostaRelatorio == "3")
            {
                Console.WriteLine($"Selecione o tipo de Documento");
                Console.WriteLine($"1 - Nota Fiscal\n" +
                                  $"2 - Licença de Funcionamento\n" +
                                  $"3 - Contratos");
                string respostaTipoDoc = Console.ReadLine();
                if (respostaTipoDoc != "1" && respostaTipoDoc != "2" && respostaTipoDoc != "3")
                {
                    Console.WriteLine("----- Opção não encontrada. Por favor digite um valor válido -----\n");
                }
                else if (respostaTipoDoc == "1")
                {
                    listaNotaFiscal.ListarDocumentos();
                }
                else if (respostaTipoDoc == "2")
                {
                    listaLicencaFuncionamento.ListarDocumentos();
                }
                else
                {
                    listaContrato.ListarDocumentos();
                }
            }
            else if (respostaRelatorio == "4")
            {
                listaContrato.TotalRelatorio();
            }
            else if (respostaRelatorio == "0")
            {
                break;
            }
        }
    }
    else if (respostaMenu == "3")
    {
        while (true)
        {
            Console.WriteLine("################## LISTA DE DOCUMENTOS ENCONTRADOS ##################");
            listaNotaFiscal.ListarDocumentos();
            listaLicencaFuncionamento.ListarDocumentos();
            listaContrato.ListarDocumentos();
            Console.WriteLine("");
            alterarItens.AlterarItensDocumento();
            break;
        }
    }
    else if (respostaMenu == "4")
    {
        Console.WriteLine("################## LISTA DE DOCUMENTOS ENCONTRADOS ##################");
        listaNotaFiscal.ListarDocumentos();
        listaLicencaFuncionamento.ListarDocumentos();
        listaContrato.ListarDocumentos();
        Console.WriteLine("");
        alterarStatus.AlterarStatusDocumento();
        continue;
    }
    else if (respostaMenu == "0")
    {
        Console.WriteLine($"Obrigado por usar nosso sistema.\n" + 
        $"Tenha um ótimo dia, {funcionario.Nome}!");
        break;
    }
}