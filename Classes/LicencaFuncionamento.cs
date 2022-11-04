using devindocuments.Menu;
namespace devindocuments.Classes
{
    public class LicencaFuncionamento : DevinDocuments
    {
        public List<LicencaFuncionamento> ListaLicencaFuncionameto{get; set;}
        public string Endereco{get; set;}
        public AreaAtuacaoEnum AreaAtuacao{get; set;}

        public LicencaFuncionamento(DateTime? dataAlteracao, string nomeEstabelecimento, 
                        string cpnj, StatusDocumentoEnum statusDocumento, int idFuncionario):
                        base(dataAlteracao,nomeEstabelecimento, cpnj,statusDocumento,
                        idFuncionario)
        {

        }
        public void CadastrarDocumento(LicencaFuncionamento licencaFuncionamento)
        {
            ListaLicencaFuncionameto.Add(licencaFuncionamento);
            Console.WriteLine(ListaLicencaFuncionameto.Count + "Foi Licenca");
        }
    }
}