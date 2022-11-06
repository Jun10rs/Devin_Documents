using devindocuments.Menu;
namespace devindocuments.Classes
{
    public class NotaFiscal : DevinDocuments
    {
        //public List<NotaFiscal> ListaNotaFiscal{get; set;}
        public decimal? ValorNotaFiscal { get; set; }
        public string? NomeProdutoVendido { get; set; }
        public TipoImpostoEnum TipoImposto { get; set; }
        public decimal ValorTotalImposto { get; set; }

        public NotaFiscal(DateTime? dataAlteracao, string nomeEstabelecimento,
                        string cpnj, StatusDocumentoEnum statusDocumento, int idFuncionario, 
                        decimal valorNotaFiscal, string nomeProdutoVendido, TipoImpostoEnum tipoImpostoEnum,
                        decimal valorTotalImposto):
                        base(dataAlteracao, nomeEstabelecimento, cpnj, statusDocumento, idFuncionario)
        {

        }
        public NotaFiscal()
        {

        }

        public void CadastrarDocumento(NotaFiscal notaFiscal)
        {
            ListaDocuments.ListaNotaFiscal.Add(notaFiscal);
            Console.WriteLine(ListaDocuments.ListaNotaFiscal.Count + "Foi aqui nota");
        }

        public void ListarDocumentos()
        {
            if (ListaDocuments.ListaNotaFiscal.Count == 0)
            {
                Console.WriteLine($"===================== BANCO DE DADOS NOTA FISCAL =====================\n" +
                                  $"Foram encontrados: {ListaDocuments.ListaNotaFiscal.Count} realtórios em nosso banco de dados\n" +
                                  $"Por favor, retorne ao menu e adicione um novo documento!\n" +
                                  $"===================== BANCO DE DADOS NOTA FISCAL=====================");
            }
            else
            {
                foreach (var item in ListaDocuments.ListaNotaFiscal)
                {
                    Console.WriteLine($"===================== RELATÓRIO NOTAS FISCAIS =====================\n" +
                    $"Id do Funcionario: {item.IdFuncionario}\n" +
                    $"Codigo do documento: {item.CodigoDocumento}\n" +
                    $"Data de Cadastro: {item.DataCadastro}\n" +
                    $"Nome Estabelecimento {item.NomeEstabelecimento}\n" +
                    $"Numero CNPJ: {item.CNPJ}\n" +
                    $"Status do Documento: {item.StatusDocumento}\n" +
                    $"Valor da Nota Fiscal: {item.ValorNotaFiscal}\n" +
                    $"Nome do Produto Vendido: {item.NomeProdutoVendido}\n" +
                    $"Tipo de Imposto: {item.TipoImposto}\n" +
                    $"Valor Total imposto: {item.ValorTotalImposto}\n" +
                    $"===================== RELATÓRIO NOTAS FISCAIS =====================\n");
                }
            }
        }       
    }
}