using devindocuments.Classes;
using devindocuments.Menu;

var funcionario = new Pessoa();
funcionario.Codigo = 001;
funcionario.Nome = "Junior";
funcionario.Endereco = "Rua das Flores";
funcionario.DataNascimento = new DateTime(1988, 06, 12);
funcionario.Filiacao = "Servidor";
funcionario.DataAdmissao = new DateTime(2002, 08, 15);

//var listaNotaFiscal1 = new List<NotaFiscal>();
var statusDoc = Enum.GetValues<StatusDocumentoEnum>();
var tipoImposto = Enum.GetValues<TipoImpostoEnum>();
var areaAtuacao = Enum.GetValues<AreaAtuacaoEnum>();
var opcaoMenu = Enum.GetValues<OpcaoMenuEnum>();

Console.WriteLine("=== Seja Bem Vindo ao DEVIN DOCUMENTS ===");
Console.WriteLine($"Olá, {funcionario.Nome}!");


while (true)
{
    Console.WriteLine("O que você deseja fazer?");
    Console.WriteLine("1 - Cadastrar documento");
    Console.WriteLine("2 - Listar documento");
    Console.WriteLine("3 - Alterar itens do documento");
    Console.WriteLine("4 - Alterar status do documento");
    var respostaCadastrar = Console.ReadLine();

    if (respostaCadastrar != "1" && respostaCadastrar != "2" && respostaCadastrar != "3" && respostaCadastrar != "4")
    {
        Console.WriteLine("Digite um valor válido");
        continue;
    }
    if (respostaCadastrar == "1")
    {
        Console.WriteLine("Qual tipo de documento você deseja cadastrar?");
        Console.WriteLine("1 - Nota Fiscal");
        Console.WriteLine("2 - Licenças de funcionamento");
        Console.WriteLine("3 - Contrato");
        var respostaTipoDoc = Console.ReadLine();

        if (respostaTipoDoc != "1" && respostaTipoDoc != "2" && respostaTipoDoc != "3")
        {
            Console.WriteLine("Digite um valor válido");
            continue;
        }
        if (respostaTipoDoc == "1")
        {
            Console.WriteLine("Digite o Nome do Estabelecimento");
            string nomeEstabelecimento = Console.ReadLine();

            Console.WriteLine("Digite o CNPJ");
            string cnpj = Console.ReadLine();

            Console.WriteLine("Selecione o Status do documento");
            foreach (var status in statusDoc)
            {
                if (status == StatusDocumentoEnum.Ativo)
                {
                    Console.WriteLine($"{(int)status} - Ativo");
                }
                if (status == StatusDocumentoEnum.EmTramitacao)
                {
                    Console.WriteLine($"{(int)status} - Em Tramitação");
                }
                if (status == StatusDocumentoEnum.Suspenso)
                {
                    Console.WriteLine($"{(int)status} - Suspenso");
                }
            }
            var statusDocumentoEnum = SelecaoStatusEnum.StatusSelecao(Console.ReadLine());

            Console.WriteLine("Digite o valor da Nota Fiscal");
            decimal valorNotaFiscal = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do Produto Vendido");
            string nomeProdutoVendido = Console.ReadLine();

            Console.WriteLine("Selecione o Tipo de Imposto");
            foreach (var imposto in tipoImposto)
            {
                if (imposto == TipoImpostoEnum.ICMS)
                {
                    Console.WriteLine($"{(int)imposto} - ICMS ");
                }
                if (imposto == TipoImpostoEnum.IOF)
                {
                    Console.WriteLine($"{(int)imposto} - IOF");
                }
                if (imposto == TipoImpostoEnum.IPI)
                {
                    Console.WriteLine($"{(int)imposto} - IPI");
                }
            }
          
            var tipoImpostoEnum = SelecaoImpostoEnum.ImpostoSelecao(Console.ReadLine());

            Console.WriteLine("Digite o valor do imposto");
            decimal valorTotalImposto = decimal.Parse(Console.ReadLine());

            NotaFiscal nota = new NotaFiscal(dataAlteracao: null, nomeEstabelecimento: nomeEstabelecimento, cpnj: cnpj,
             statusDocumento: statusDocumentoEnum, idFuncionario: funcionario.Codigo);

            nota.ListaNotaFiscal = new List<NotaFiscal>();
            nota.ValorNotaFiscal = valorNotaFiscal;
            nota.NomeProdutoVendido = nomeProdutoVendido;
            nota.TipoImposto = tipoImpostoEnum;
            nota.ValorTotalImposto = valorTotalImposto;
            nota.CadastrarDocumento(nota);
            Console.WriteLine("Cadastrado com Sucesso");
            continue;
        }
        else if (respostaTipoDoc == "2")
        {
            Console.WriteLine("Digite o Nome do Estabelecimento");
            string nomeEstabelecimento = Console.ReadLine();

            Console.WriteLine("Digite o CNPJ");
            string cnpj = Console.ReadLine();

            Console.WriteLine("Selecione o Status do documento");
            foreach (var status in statusDoc)
            {
                if (status == StatusDocumentoEnum.Ativo)
                {
                    Console.WriteLine($"{(int)status} - Ativo");
                }
                else if (status == StatusDocumentoEnum.EmTramitacao)
                {
                    Console.WriteLine($"{(int)status} - Em Tramitação");
                }
                else if (status == StatusDocumentoEnum.Suspenso)
                {
                    Console.WriteLine($"{(int)status} - Suspenso");
                }
            }
            var statusDocumentoLicenca = Console.ReadLine();
            
            var statusLicencaEnum = SelecaoStatusEnum.StatusSelecao(Console.ReadLine());

            Console.WriteLine("Digite o Endereço");
            string endereco = Console.ReadLine();

            Console.WriteLine("Selecione a Área de Atuação");
            foreach (var atuacao in areaAtuacao)
            {
                if (atuacao == AreaAtuacaoEnum.Industrial)
                {
                    Console.WriteLine($"{(int)atuacao} - Industrial");
                }
                if (atuacao == AreaAtuacaoEnum.Agropecuario)
                {
                    Console.WriteLine($"{(int)atuacao} - Agropecuário");
                }
                if (atuacao == AreaAtuacaoEnum.Metalurgico)
                {
                    Console.WriteLine($"{(int)atuacao} - Metalurgiico");
                }
                if (atuacao == AreaAtuacaoEnum.Tecnologia)
                {
                    Console.WriteLine($"{(int)atuacao}) - Tecnologia");
                }
                if (atuacao == AreaAtuacaoEnum.Outro)
                {
                    Console.WriteLine($"{(int)atuacao} - Outro");
                }

            }
            var selecaoArea = Console.ReadLine();
           
            var selecaoAtuacao = SelecaoAreaAtuacao.AreaAtuacao(Console.ReadLine());

            LicencaFuncionamento novaLicenca = new LicencaFuncionamento(dataAlteracao: null, nomeEstabelecimento: nomeEstabelecimento, cpnj: cnpj,
              statusDocumento: statusLicencaEnum, idFuncionario: funcionario.Codigo);
            novaLicenca.ListaLicencaFuncionameto = new List<LicencaFuncionamento>();
            novaLicenca.Endereco = endereco;
            novaLicenca.AreaAtuacao = selecaoAtuacao;
            novaLicenca.CadastrarDocumento(novaLicenca);

            Console.WriteLine("Licença Funcionamento Cadastrada com sucesso");
            continue;

        }
        else if (respostaTipoDoc == "3")
        {
            Console.WriteLine("Digite o Nome do Estabelecimento");
            string nomeEstabelecimento = Console.ReadLine();

            Console.WriteLine("Digite o CNPJ");
            string cnpj = Console.ReadLine();

            Console.WriteLine("Selecione o Status do documento");
            foreach (var status in statusDoc)
            {
                if (status == StatusDocumentoEnum.Ativo)
                {
                    Console.WriteLine($"{(int)status} - Ativo");
                }
                if (status == StatusDocumentoEnum.EmTramitacao)
                {
                    Console.WriteLine($"{(int)status} - Em Tramitação");
                }
                if (status == StatusDocumentoEnum.Suspenso)
                {
                    Console.WriteLine($"{(int)status} - Suspenso");
                }
            }
            var statusDocumentoContrato = Console.ReadLine();
            
            var statusContratoEnum = SelecaoStatusEnum.StatusSelecao(Console.ReadLine());
            
            Console.WriteLine("Digite a Finalidade");
            string finalidade = Console.ReadLine();

            Console.WriteLine("Digite uma Testemunha");
            string testemunhas = Console.ReadLine();

            Console.WriteLine("Digite a Data de Expiração(ex:01/01/0101)");
            DateTime dataExpiracao = DateTime.Parse(Console.ReadLine());

            Contrato novoContrato = new Contrato(dataAlteracao: null, nomeEstabelecimento: nomeEstabelecimento, cpnj: cnpj,
              statusDocumento: statusContratoEnum, idFuncionario: funcionario.Codigo);
            novoContrato.Finalidade = finalidade;
            novoContrato.Testemunhas = testemunhas;
            novoContrato.DataExpiracao = dataExpiracao;
            novoContrato.CadastrarDocumento(novoContrato);    
            continue;
        }
    }
    else if (respostaCadastrar == "2")
    {

    }
    else if (respostaCadastrar == "3")
    {

    }
    else if (respostaCadastrar == "4")
    {

    }
}
