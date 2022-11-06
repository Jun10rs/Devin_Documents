using devindocuments.Menu;
using System.Linq;
namespace devindocuments.Classes
{
    public class Contrato : DevinDocuments
    {
        //public static List<Contrato> ListaContrato{get; set;}
        public string? Finalidade { get; set; }
        public string? Testemunhas { get; set; }
        public DateTime DataExpiracao { get; set; }

        public Contrato(DateTime? dataAlteracao, string nomeEstabelecimento,
                        string cpnj, StatusDocumentoEnum statusDocumento, int idFuncionario, string finalidade,
                        string testemunhas, DateTime dataExpiracao) :
                        base(dataAlteracao, nomeEstabelecimento, cpnj, statusDocumento,
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

        public void ListarDocumentos()
        {
            if (ListaDocuments.ListaContrato.Count == 0)
            {
                Console.WriteLine($"===================== BANCO DE DADOS CONTRATO =====================\n" +
                                  $"Foram encontrados: {ListaDocuments.ListaContrato.Count} realtórios em nosso banco de dados\n" +
                                  $"Por favor, retorne ao menu e adicione um novo documento!\n" +
                                  $"===================== BANCO DE DADOS CONTRATO =====================");
            }
            else
            {
                foreach (var item in ListaDocuments.ListaContrato)
                {
                    Console.WriteLine($"================= RELATÓRIO DE CONTRATOS =================\n" +
                                      $"Id do Funcionario: {item.IdFuncionario}\n" +
                                      $"Codigo do documento: {item.CodigoDocumento}\n" +
                                      $"Data de Cadastro: {item.DataCadastro}\n" +
                                      $"Nome Estabelecimento {item.NomeEstabelecimento}\n" +
                                      $"Numero CNPJ: {item.CNPJ}\n" +
                                      $"Status do Documento: {item.StatusDocumento}\n" +
                                      $"Finalidade: {item.Finalidade}\n" +
                                      $"Testemunhas: {item.Testemunhas}\n" +
                                      $"Data de Expiração: {item.DataExpiracao}\n" +
                                      $"================= RELATÓRIO DE CONTRATOS =================\n");
                }
            }
        }
      
        //  public void AlterarItensDocumento(Contrato contrato)
        // {

        // }
         public void AlterarStatusDocumento()
        {

        }
        public void TotalRelatorio()
        {
            int soma = ListaDocuments.ListaContrato.Count + ListaDocuments.ListaNotaFiscal.Count + ListaDocuments.ListaLicencaFuncionamento.Count;
            Console.WriteLine($"Foram encontrados {ListaDocuments.ListaNotaFiscal.Count} relatórios de Notas Fiscais\n" +
                              $"Foram encontrados {ListaDocuments.ListaLicencaFuncionamento.Count} relatórios de Licença de Funcionamento\n" +
                              $"Foram encontrados {ListaDocuments.ListaContrato.Count} relatórios de Contratos\n" +
                              $"Total de Relatótios: {soma}");
        }
    }
}