using devindocuments.Classes;
using devindocuments.Menu;

var funcionario = new Pessoa();
funcionario.Codigo = 001;
funcionario.Nome = "Valdecir Silva";
funcionario.Endereco = "Rua das Flores";
funcionario.DataNascimento = new DateTime(1988, 06, 12);
funcionario.Filiacao = "Servidor";
funcionario.DataAdmissao = new DateTime(2002, 08, 15);

List<NotaFiscal> ListaNotaFiscal = new List<NotaFiscal>();
List<LicencaFuncionamento> ListaLicencaFuncionameto = new List<LicencaFuncionamento>();
List<Contrato> ListaContrato = new List<Contrato>();

var statusDoc = Enum.GetValues<StatusDocumentoEnum>();
var tipoImposto = Enum.GetValues<TipoImpostoEnum>();
var areaAtuacao = Enum.GetValues<AreaAtuacaoEnum>();
//var opcoes = Enum.GetValues<OpcaoMenuEnum>();
//nota.CodigoDocumento = Guid.NewGuid().ToString();

Console.WriteLine("==Seja Bem Vindo ao DEVIN DOCUMENTS==");

while(true)
{
    Console.WriteLine("O que você deseja fazer?");
    Console.WriteLine("1 - Cadastrar documento");
    Console.WriteLine("2 - Listar documento");
    Console.WriteLine("3 - Alterar itens do documento");
    Console.WriteLine("4 - Alterar status do documento");
    var respostaCadastrar = Console.ReadLine();

    if(respostaCadastrar != "1" && respostaCadastrar != "2" && respostaCadastrar != "3" && respostaCadastrar != "4"){
        Console.WriteLine("Digite um valor válido");
        continue;
    }
    if(respostaCadastrar == "1"){
        Console.WriteLine("Qual tipo de documento você deseja cadastrar?");
        Console.WriteLine("1 - Nota Fiscal");
        Console.WriteLine("2 - Licenças de funcionamento");
        Console.WriteLine("3 - Contrato");
        var respostaTipoDoc = Console.ReadLine();

        if(respostaTipoDoc != "1" && respostaTipoDoc != "2" && respostaTipoDoc != "3"){
        Console.WriteLine("Digite um valor válido");
        continue;
        }
        if(respostaTipoDoc == "1"){
            Console.WriteLine("Digite o Código do Documento");
            string codigoDocumento = (Console.ReadLine());
           
            Console.WriteLine("Digite o Nome do Estabelecimento");
            string nomeEstabelecimento = Console.ReadLine();
            
            Console.WriteLine("Digite o CNPJ");
            string cnpj = Console.ReadLine();
            
            Console.WriteLine("Selecione o Status do documento");
                foreach(var status in statusDoc){
                    if(status == StatusDocumentoEnum.Ativo)
                    {
                        Console.WriteLine($"{(int)status} - Ativo");
                    }
                    if(status == StatusDocumentoEnum.EmTramitacao)
                    {
                        Console.WriteLine($"{(int)status} - Em Tramitação");
                    }
                    if(status == StatusDocumentoEnum.Suspenso)
                    {
                        Console.WriteLine($"{(int)status} - Suspenso");
                    } 
                }
            var statusDocumentoEnum = Console.ReadLine();    

            Console.WriteLine("Digite o valor da Nota Fiscal");
            decimal valorNotaFiscal = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o nome do Produto Vendido");
            string nomeProdutoVendido = Console.ReadLine();

            Console.WriteLine("Selecione o Tipo de Imposto");
                foreach(var imposto in tipoImposto){
                    if(imposto == TipoImpostoEnum.ICMS)
                    {
                        Console.WriteLine($"{(int)imposto} - ");
                    }
                    if(imposto == TipoImpostoEnum.IOF)
                    {
                        Console.WriteLine($"{(int)imposto} - IOF");
                    }
                    if(imposto == TipoImpostoEnum.IPI)
                    {
                        Console.WriteLine($"{(int)imposto} - IPI");
                    } 
                }
            var tipoImpostoEnum = Console.ReadLine();    
            
            Console.WriteLine("Digite o valor do imposto");
            decimal valorTotalImposto = decimal.Parse(Console.ReadLine());
            
            NotaFiscal nota = new NotaFiscal(codigoDocumento, DateTime.Now, nomeEstabelecimento, cnpj, 
            statusDocumentoEnum, valorNotaFiscal, nomeProdutoVendido, tipoImpostoEnum, valorTotalImposto);
            ListaNotaFiscal.Add(nota);

            Console.WriteLine("Cadastrado com Sucesso");
            continue;
        }else if(respostaTipoDoc == "2")
        {
            Console.WriteLine("Digite o Código do Documento");
            string codigoDocumento = (Console.ReadLine());
           
            Console.WriteLine("Digite o Nome do Estabelecimento");
            string nomeEstabelecimento = Console.ReadLine();
            
            Console.WriteLine("Digite o CNPJ");
            string cnpj = Console.ReadLine();
            
            Console.WriteLine("Digite o Endereço");
            string endereco = Console.ReadLine();
            LicencaFuncionamento novaLicenca = new LicencaFuncionamento(codigoDocumento, DateTime.Now, nomeEstabelecimento, cnpj, endereco);
            ListaLicencaFuncionameto.Add(novaLicenca);
            //novaLicenca.CadastrarDocumento(novaLicenca);
            Console.WriteLine("Cadastrado com sucesso");
            continue;

        }else if(respostaTipoDoc == "3")
        {
            Console.WriteLine("Digite o Código do Documento");
            string codigoDocumento = (Console.ReadLine());
           
            Console.WriteLine("Digite o Nome do Estabelecimento");
            string nomeEstabelecimento = Console.ReadLine();
            
            Console.WriteLine("Digite o CNPJ");
            string cnpj = Console.ReadLine();
            
            Console.WriteLine("Digite a Finalidade");
            string finalidade = Console.ReadLine();
            
            Console.WriteLine("Digite uma Testemunha");
            string testemunhas = Console.ReadLine();

            Console.WriteLine("Digite a Data de Expiração(ex:01/01/0101)");
            DateTime dataExpiracao = DateTime.Parse(Console.ReadLine());
            Contrato novoContrato = new Contrato(codigoDocumento, DateTime.Now, nomeEstabelecimento, cnpj, finalidade, testemunhas, dataExpiracao);
            ListaContrato.Add(novoContrato);    
            //novoContrato.CadastrarDocumento(); 
            continue;   
        }
    }else if(respostaCadastrar == "2")
    {

    }else if(respostaCadastrar == "3")
    {

    }else if(respostaCadastrar == "4")
    {
        
    }      
}