using devindocuments.Menu;
namespace devindocuments.Classes
{
    public class Contrato : DevinDocuments
    {
        //public static List<Contrato> ListaContrato{get; set;}
        public string? Finalidade{get; set;}
        public string? Testemunhas{get; set;}
        public DateTime DataExpiracao{get; set;}

        public Contrato(DateTime? dataAlteracao, string nomeEstabelecimento, 
                        string cpnj, StatusDocumentoEnum statusDocumento, int idFuncionario):
                        base(dataAlteracao,nomeEstabelecimento, cpnj,statusDocumento,
                        idFuncionario)
        {

        }

        public Contrato()
        {

        }
        public void CadastrarDocumento(Contrato contrato)
        {
            ListaDocuments.ListaContrato.Add(contrato);
            Console.WriteLine(ListaDocuments.ListaContrato.Count + "Foi contrato");
        }
        public void ListarDocumentos(List<NotaFiscal> ListaContrato)
        {
            foreach (var item in ListaDocuments.ListaContrato)
            {
                Console.WriteLine($"{item.CodigoDocumento} {item.DataCadastro}");
            }
        }
        //  public void AlterarItensDocumento(Contrato contrato)
        // {

        // }
        //  public void AlterarStatusDocumento(SelecaoStatusEnum selecaoStatusEnum)
        // {

        // }
    }
}