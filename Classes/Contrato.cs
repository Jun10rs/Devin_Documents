using devindocuments.Menu;
namespace devindocuments.Classes
{
    public class Contrato : DevinDocuments
    {
        public List<Contrato> ListaContrato{get; set;}
        public string Finalidade{get; set;}
        public string Testemunhas{get; set;}
        public DateTime DataExpiracao{get; set;}

        public Contrato(string codigoDocumento, DateTime dataCadastro, string nomeEstabelecimento, 
            string cpnj, StatusDocumentoEnum statusDocumentoEnum, string finalidade, string testemunhas, DateTime dataExpiracao):
            base(codigoDocumento, dataCadastro, nomeEstabelecimento, cpnj, statusDocumentoEnum)
        {
            this.Finalidade = finalidade;
            this.Testemunhas = testemunhas;
            this.DataExpiracao = dataExpiracao;
        }
    }
}