using devindocuments.Menu;
namespace devindocuments.Classes
{
    public class Contrato : DevinDocuments
    {
        public List<Contrato> ListaContrato{get; set;}
        public string Finalidade{get; set;}
        public string Testemunhas{get; set;}
        public DateTime DataExpiracao{get; set;}
        public Contrato(DateTime? dataAlteracao, string nomeEstabelecimento, 
                        string cpnj, StatusDocumentoEnum statusDocumento, int idFuncionario):
                        base(dataAlteracao,nomeEstabelecimento, cpnj,statusDocumento,
                        idFuncionario)
        {

        }

        public void CadastrarDocumento(Contrato contrato)
        {
            ListaContrato.Add(contrato);
            Console.WriteLine(ListaContrato.Count + "Foi contrato");
        }
    }
}