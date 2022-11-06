using devindocuments.Menu.MenuEnum;
using devindocuments.Relatorios;
namespace devindocuments.Classes
{
    public class LicencaFuncionamento : DevinDocuments
    {
        public string Endereco { get; set; }
        public AreaAtuacaoEnum AreaAtuacao { get; set; }

        public LicencaFuncionamento(DateTime? dataAlteracao, string nomeEstabelecimento,
                                    string cpnj, StatusDocumentoEnum statusDocumento, int idFuncionario,
                                    string endereco, AreaAtuacaoEnum areaAtuacaoEnum) :
                                    base(dataAlteracao, nomeEstabelecimento, cpnj, statusDocumento,
                                    idFuncionario)
        {
            this.Endereco = endereco;
            this.AreaAtuacao = areaAtuacaoEnum;
        }
        public LicencaFuncionamento()
        {

        }
        public void CadastrarDocumento(LicencaFuncionamento licencaFuncionamento)
        {
            ListaDocuments.ListaLicencaFuncionamento.Add(licencaFuncionamento);
        }
        public void ListarDocumentos()
        {
            if (ListaDocuments.ListaLicencaFuncionamento.Count == 0)
            {
                Console.WriteLine($"=============== BANCO DE DADOS LICENÇAS===============\n" +
                                  $" Foram encontrados: {ListaDocuments.ListaLicencaFuncionamento.Count} realtórios em nosso banco de dados\n" +
                                  $" Por favor, retorne ao menu e adicione um novo documento!\n" +
                                  $"=============== BANCO DE DADOS LICENÇAS ===============");
            }
            else
            {
                foreach (var item in ListaDocuments.ListaLicencaFuncionamento)
                {
                    Console.WriteLine($"=============== RELATÓRIO DE LICENÇA DE FUNCIONAMENTO ===============\n" +
                                      $"Id do Funcionario: {item.IdFuncionario}\n" +
                                      $"Codigo do documento: {item.CodigoDocumento}\n" +
                                      $"Data de Cadastro: {item.DataCadastro}\n" +
                                      $"Data Alteração: {item.DataAlteracao}\n" +
                                      $"Nome Estabelecimento {item.NomeEstabelecimento}\n" +
                                      $"Numero CNPJ: {item.CNPJ}\n" +
                                      $"Status do Documento: {item.StatusDocumento}\n" +
                                      $"Endereço: {item.Endereco}\n" +
                                      $"Área de Atuação: {item.AreaAtuacao}\n" +
                                      $"=============== RELATÓRIO DE LICENÇA DE FUNCIONAMENTO ===============\n");
                }
            }
        }
    }
}