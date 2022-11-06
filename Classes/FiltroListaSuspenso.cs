using devindocuments.Menu;
namespace devindocuments.Classes
{
    public class FiltroListaSuspenso
    {
        public void FiltroListaNotas()
        {
            foreach (var item in ListaDocuments.ListaNotaFiscal)
            {
                if (item.StatusDocumento == StatusDocumentoEnum.Suspenso)
                {
                    Console.WriteLine($"================= RELATÓRIO DE CONTRATOS =================\n" +
                                      $"Id do Funcionario: {item.IdFuncionario}\n" +
                                      $"Codigo do documento: {item.CodigoDocumento}\n" +
                                      $"Data de Cadastro: {item.DataCadastro}\n" +
                                      $"Nome Estabelecimento {item.NomeEstabelecimento}\n" +
                                      $"Numero CNPJ: {item.CNPJ}\n" +
                                      $"Status do Documento: {item.StatusDocumento}\n" +
                                      $"Valor da Nota Fiscal: {item.ValorNotaFiscal}\n" +
                                      $"Nome do Produto Vendido: {item.NomeProdutoVendido}\n" +
                                      $"Tipo de Imposto: {item.TipoImposto}\n" +
                                      $"Valor Total imposto: {item.ValorTotalImposto}\n" +
                                      $"================= RELATÓRIO DE CONTRATOS =================\n");
                }
                else
                {
                    Console.WriteLine("Não foram encontrados itens na lista");
                }
            }
        }
        public void FiltroListaLicenca()
        {
            foreach (var item in ListaDocuments.ListaLicencaFuncionamento)
            {
                if (item.StatusDocumento == StatusDocumentoEnum.Suspenso)
                {
                    Console.WriteLine($"================= RELATÓRIO DE CONTRATOS =================\n" +
                                      $"Id do Funcionario: {item.IdFuncionario}\n" +
                                      $"Codigo do documento: {item.CodigoDocumento}\n" +
                                      $"Data de Cadastro: {item.DataCadastro}\n" +
                                      $"Nome Estabelecimento {item.NomeEstabelecimento}\n" +
                                      $"Numero CNPJ: {item.CNPJ}\n" +
                                      $"Status do Documento: {item.StatusDocumento}\n" +
                                      $"Endereço: {item.Endereco}\n" +
                                      $"Área de Atuação: {item.AreaAtuacao}\n" +
                                      $"================= RELATÓRIO DE CONTRATOS =================\n");
                }
                else
                {
                    Console.WriteLine("Não foram encontrados itens na lista");
                }
            }
        }  
        public void FiltroListaContrato()
        {
            foreach (var item in ListaDocuments.ListaContrato)
            {
                if (item.StatusDocumento == StatusDocumentoEnum.Suspenso)
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
                else
                {
                    Console.WriteLine("Não foram encontrados itens na lista");
                }
            }
        }
    }
}