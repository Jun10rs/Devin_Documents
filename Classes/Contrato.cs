using devindocuments.Menu.MenuEnum;
using devindocuments.Relatorios;
namespace devindocuments.Classes
{
    public class Contrato : DevinDocuments
    {
        public string Finalidade { get; set; }
        public string Testemunhas { get; set; }
        public DateTime DataExpiracao { get; set; }

        public Contrato(DateTime? dataAlteracao, string nomeEstabelecimento,
                        string cpnj, StatusDocumentoEnum statusDocumento, int idFuncionario, string finalidade,
                        string testemunhas, DateTime dataExpiracao) :
                        base(dataAlteracao, nomeEstabelecimento, cpnj, statusDocumento,
                        idFuncionario)
        {
            this.Finalidade = finalidade;
            this.Testemunhas = testemunhas;
            this.DataExpiracao = dataExpiracao;
        }
        public Contrato()
        {

        }

        public void CadastrarDocumento(Contrato contrato)
        {
            ListaDocuments.ListaContrato.Add(contrato);
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
                    Console.WriteLine($"====================== RELATÓRIO DE CONTRATOS =======================\n" +
                                      $"Id do Funcionario: {item.IdFuncionario}\n" +
                                      $"Codigo do documento: {item.CodigoDocumento}\n" +
                                      $"Data de Cadastro: {item.DataCadastro}\n" +
                                      $"Data Alteração: {item.DataAlteracao}\n" +
                                      $"Nome Estabelecimento {item.NomeEstabelecimento}\n" +
                                      $"Numero CNPJ: {item.CNPJ}\n" +
                                      $"Status do Documento: {item.StatusDocumento}\n" +
                                      $"Finalidade: {item.Finalidade}\n" +
                                      $"Testemunhas: {item.Testemunhas}\n" +
                                      $"Data de Expiração: {item.DataExpiracao}\n" +
                                      $"====================== RELATÓRIO DE CONTRATOS =======================\n");
                }
            }
        }
        public void TotalRelatorio()
        {
            int soma = ListaDocuments.ListaContrato.Count + ListaDocuments.ListaNotaFiscal.Count + ListaDocuments.ListaLicencaFuncionamento.Count;
            Console.WriteLine($"Foram encontrados {ListaDocuments.ListaNotaFiscal.Count} relatórios de Notas Fiscais\n" +
                              $"Foram encontrados {ListaDocuments.ListaLicencaFuncionamento.Count} relatórios de Licença de Funcionamento\n" +
                              $"Foram encontrados {ListaDocuments.ListaContrato.Count} relatórios de Contratos\n" +
                              $"TOTAL DE RELATÓRIOS: {soma} relatórios");
        }
    }
}