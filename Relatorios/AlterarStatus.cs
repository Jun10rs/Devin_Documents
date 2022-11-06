using devindocuments.Menu.MenuEnum;
using devindocuments.Menu.MenuSelecao;

namespace devindocuments.Relatorios
{
    public class AlterarStatus
    {
        public void AlterarStatusDocumento()
        {
            Console.WriteLine("==================== DOCUMENTOS ENCONTRADOS ====================");
            Console.WriteLine("Digite os 5 primeiros digitos do Código do Documento que você deseja alterar.");
            var editar = Console.ReadLine();
            if (editar.Length != 5)
            {
                Console.WriteLine("Codigo não encontrado, digite novamente!!!");
            }
            else
            {
                var notaFiscal = ListaDocuments.ListaNotaFiscal.Where(c => c.CodigoDocumento.Contains(editar)).FirstOrDefault();
                var licenca = ListaDocuments.ListaLicencaFuncionamento.Where(c => c.CodigoDocumento.Contains(editar)).FirstOrDefault();
                var contrato = ListaDocuments.ListaContrato.Where(c => c.CodigoDocumento.Contains(editar)).FirstOrDefault();
                if (contrato != null)
                {
                    Console.WriteLine("******** Selecione um novo Status ********");
                    Console.WriteLine($"1 - {StatusDocumentoEnum.Ativo}\n" +
                                      $"2 - {StatusDocumentoEnum.EmTramitacao}\n" +
                                      $"3 - {StatusDocumentoEnum.Suspenso}");
                    contrato.StatusDocumento = SelecaoStatusEnum.StatusSelecao(Console.ReadLine());
                    contrato.DataAlteracao = DateTime.Now;
                    Console.WriteLine($"================== STATUS ALTERADO COM SUCESSO!!! ==================");
                }
                else if (licenca != null)
                {
                    Console.WriteLine("******** Selecione um novo Status ********");
                    Console.WriteLine($"1 - {StatusDocumentoEnum.Ativo}\n" +
                                      $"2 - {StatusDocumentoEnum.EmTramitacao}\n" +
                                      $"3 - {StatusDocumentoEnum.Suspenso}");
                    licenca.StatusDocumento = SelecaoStatusEnum.StatusSelecao(Console.ReadLine());
                    Console.WriteLine($"================== STATUS ALTERADO COM SUCESSO!!! ==================");
                }
                else if (notaFiscal != null)
                {
                    Console.WriteLine("******** Selecione um novo Status ********");
                    Console.WriteLine($"1 - {StatusDocumentoEnum.Ativo}\n" +
                                      $"2 - {StatusDocumentoEnum.EmTramitacao}\n" +
                                      $"3 - {StatusDocumentoEnum.Suspenso}");
                    notaFiscal.StatusDocumento = SelecaoStatusEnum.StatusSelecao(Console.ReadLine());
                    Console.WriteLine($"================== STATUS ALTERADO COM SUCESSO!!! ==================");
                }
                else
                {
                    Console.WriteLine("Status não alterado!");
                }
            }
        }
    }
}