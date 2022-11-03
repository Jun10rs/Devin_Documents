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

        public NotaFiscal(string codigoDocumento, DateTime dataCadastro, string nomeEstabelecimento, string cpnj, 
            StatusDocumentoEnum statusDocumentoEnum, decimal valorNotaFiscal, string nomeProdutoVendido, 
            TipoImpostoEnum tipoImpostoEnum, decimal valorTotalImposto):
            base(codigoDocumento, dataCadastro, nomeEstabelecimento, cpnj, statusDocumentoEnum)
        {
            this.ValorNotaFiscal = valorNotaFiscal;
            this.NomeProdutoVendido = nomeProdutoVendido;
            this.TipoImposto = tipoImpostoEnum;
            this.ValorTotalImposto = valorTotalImposto;
        }


        // public override CadastrarDocumento()
        // {
        //     ListaDocumentos.Add(NotaFiscal);
        // }

        // public decimal ObterValorImpostoIcms()
        // {
        //     return 15;
        // }
        // public decimal ObterValorImpostoIpi()
        // {
        //     return 18;
        // }
        // public decimal ObterValorImpostoIof()
        // {
        //     return 0.38M;
        // }
        // public decimal ObterValorImpostoOutro()
        // {
        //     return 5;
        // }
    }
}