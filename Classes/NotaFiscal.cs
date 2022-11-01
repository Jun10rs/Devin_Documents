namespace devindocuments.Classes
{
    public class NotaFiscal : DevinDocuments
    {
        public decimal ValorNotaFiscal{get; set;}
        public string Nome{get; set;}
        public TipoImpostoEnum TipoImposto{get; set;}
        public decimal ValorTotalImposto{get; set;}
    }
}