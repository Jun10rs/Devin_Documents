using devindocuments.Menu;
namespace devindocuments.Classes
{
    public class LicencaFuncionamento : DevinDocuments
    {
        public List<LicencaFuncionamento> ListaLicencaFuncionameto{get; set;}
        public string Endereco{get; set;}
        public AreaAtuacaoEnum AreaAtuacao{get; set;}

        public LicencaFuncionamento(string codigoDocumento, DateTime dataCadastro, string nomeEstabelecimento, string cpnj, 
            string endereco):base(codigoDocumento, dataCadastro, nomeEstabelecimento, cpnj)
        {
            this.Endereco = endereco;
            //this.AreaAtuacao = areaAtuacao;
        }
       
    }
}