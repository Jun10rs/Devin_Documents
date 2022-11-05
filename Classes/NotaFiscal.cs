using devindocuments.Menu;
namespace devindocuments.Classes
{
    public class NotaFiscal : DevinDocuments
    {
        //public List<NotaFiscal> ListaNotaFiscal{get; set;}
        public decimal? ValorNotaFiscal{get; set;}
        public string? NomeProdutoVendido{get; set;}
        public TipoImpostoEnum TipoImposto{get; set;}
        public decimal ValorTotalImposto{get; set;}

        public NotaFiscal(DateTime? dataAlteracao, string nomeEstabelecimento, 
                        string cpnj, StatusDocumentoEnum statusDocumento, int idFuncionario):
                        base(dataAlteracao,nomeEstabelecimento, cpnj,statusDocumento,idFuncionario)
        {

        }
                
        public void CadastrarDocumento(NotaFiscal notaFiscal)
        {
            ListaDocuments.ListaNotaFiscal.Add(notaFiscal);
            Console.WriteLine(ListaDocuments.ListaNotaFiscal.Count + "Foi aqui nota");
        }
        public void ListarDocumentos(List<NotaFiscal> ListaNotaFiscal)
        {
            foreach (var item in ListaDocuments.ListaNotaFiscal)
            {
                Console.WriteLine($"=========== Lista de Notas Fiscais ============\n" +
                $"Id do Funcionario: {item.IdFuncionario}\n" +
                $"Codigo do documento: {item.CodigoDocumento}\n" +
                $"Data de Cadastro: {item.DataCadastro}\n" +
                $"Nome Estabelecimento {item.NomeEstabelecimento}\n" +
                $"Status do Documento: {item.StatusDocumento}\n" +
                $"Valor da Nota Fiscal: {item.ValorNotaFiscal}\n" +
                $"Nome do Produto Vendido: {item.NomeProdutoVendido}\n" +
                $"Tipo de Imposto: {item.TipoImposto}\n" +
                $"Valor Total imposto: {item.ValorTotalImposto}\n" +
                $"=========== Final da Lista de Notas Fiscais ============\n");
            }
        }
        public NotaFiscal()
        {

        }
    }
}