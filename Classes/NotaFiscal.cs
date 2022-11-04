using devindocuments.Menu;
namespace devindocuments.Classes
{
    public class NotaFiscal : DevinDocuments
    {
        public List<NotaFiscal> ListaNotaFiscal{get; set;}
        public decimal ValorNotaFiscal{get; set;}
        public string NomeProdutoVendido{get; set;}
        public TipoImpostoEnum TipoImposto{get; set;}
        public decimal ValorTotalImposto{get; set;}

        public NotaFiscal(DateTime? dataAlteracao, string nomeEstabelecimento, 
                        string cpnj, StatusDocumentoEnum statusDocumento, int idFuncionario):
                        base(dataAlteracao,nomeEstabelecimento, cpnj,statusDocumento,idFuncionario)
        {

        }
        
        public void CadastrarDocumento(NotaFiscal notaFiscal)
        {
            ListaNotaFiscal.Add(notaFiscal);
            Console.WriteLine(ListaNotaFiscal.Count + "Foi aqui nota");
        }
    }
}