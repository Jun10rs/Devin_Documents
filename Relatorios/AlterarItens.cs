using devindocuments.Menu.MenuEnum;
using devindocuments.Menu.MenuSelecao;

namespace devindocuments.Relatorios
{
    public class AlterarItens
    {
        public void AlterarItensDocumento()
        {
            Console.WriteLine("Digite os 5 primeiros digitos do Código do Documento que deseja alterar.");
            var editar = Console.ReadLine();
            if (editar.Length != 5)
            {
                Console.WriteLine("----- Opção não encontrada. Por favor digite um valor válido -----\n");
            }
            else
            {
                var notaFiscal = ListaDocuments.ListaNotaFiscal.Where(c => c.CodigoDocumento.Contains(editar)).FirstOrDefault();
                var licenca = ListaDocuments.ListaLicencaFuncionamento.Where(c => c.CodigoDocumento.Contains(editar)).FirstOrDefault();
                var contrato = ListaDocuments.ListaContrato.Where(c => c.CodigoDocumento.Contains(editar)).FirstOrDefault();
                if (contrato != null)
                {
                    Console.WriteLine($"**** Digite novo Estabelecimento: {contrato.NomeEstabelecimento} ****");
                    contrato.NomeEstabelecimento = Console.ReadLine();

                    Console.WriteLine($"******** Digite novo CNPJ: {contrato.CNPJ} ********");
                    contrato.CNPJ = Console.ReadLine();

                    Console.WriteLine("******** Selecione um novo Status ********");
                    Console.WriteLine($"1 - {StatusDocumentoEnum.Ativo}\n" +
                                      $"2 - {StatusDocumentoEnum.EmTramitacao}\n" +
                                      $"3 - {StatusDocumentoEnum.Suspenso}");
                    contrato.StatusDocumento = SelecaoStatusEnum.StatusSelecao(Console.ReadLine());

                    Console.WriteLine($"******** Digite nova Finalidade: {contrato.Finalidade} ********");
                    contrato.Finalidade = Console.ReadLine();

                    Console.WriteLine($"******** Digite nova Testemunha: {contrato.Testemunhas} *******");
                    contrato.Testemunhas = Console.ReadLine();

                    contrato.DataAlteracao = DateTime.Now;
                    Console.WriteLine($"================== ITENS ALTERADOS COM SUCESSO!!! ==================");
                }
                else if (licenca != null)
                {
                    Console.WriteLine($"**** Digite novo Estabelecimento: {licenca.NomeEstabelecimento} ****");
                    licenca.NomeEstabelecimento = Console.ReadLine();

                    Console.WriteLine($"******** Digite novo CNPJ: {licenca.CNPJ} ********");
                    licenca.CNPJ = Console.ReadLine();

                    Console.WriteLine("******** Selecione um novo Status ********");
                    Console.WriteLine($"1 - {StatusDocumentoEnum.Ativo}\n" +
                                      $"2 - {StatusDocumentoEnum.EmTramitacao}\n" +
                                      $"3 - {StatusDocumentoEnum.Suspenso}");
                    licenca.StatusDocumento = SelecaoStatusEnum.StatusSelecao(Console.ReadLine());

                    Console.WriteLine($"******** Digite novo Endereço: {licenca.Endereco}");
                    licenca.Endereco = Console.ReadLine();

                    Console.WriteLine($"******** Selecione nova Área de Atuação: ********");
                    Console.WriteLine($"1 - {AreaAtuacaoEnum.Industrial}\n" +
                                      $"2 - {AreaAtuacaoEnum.Agropecuario}\n" +
                                      $"3 - {AreaAtuacaoEnum.Metalurgico}\n" +
                                      $"4 - {AreaAtuacaoEnum.Tecnologia}\n" +
                                      $"5 - {AreaAtuacaoEnum.Outro}\n");
                    licenca.AreaAtuacao = SelecaoAreaAtuacao.AreaAtuacao(Console.ReadLine());

                    contrato.DataAlteracao = DateTime.Now;
                    Console.WriteLine($"================== ITENS ALTERADOS COM SUCESSO!!! ==================");
                }
                else if (notaFiscal != null)
                {
                    Console.WriteLine($"**** Digite novo Estabelecimento: {notaFiscal.NomeEstabelecimento} ****");
                    notaFiscal.NomeEstabelecimento = Console.ReadLine();

                    Console.WriteLine($"******** Digite novo CNPJ: {notaFiscal.CNPJ} ********");
                    notaFiscal.CNPJ = Console.ReadLine();

                    Console.WriteLine("******** Selecione um novo Status ********");
                    Console.WriteLine($"1 - {StatusDocumentoEnum.Ativo}\n" +
                                      $"2 - {StatusDocumentoEnum.EmTramitacao}\n" +
                                      $"3 - {StatusDocumentoEnum.Suspenso}");
                    notaFiscal.StatusDocumento = SelecaoStatusEnum.StatusSelecao(Console.ReadLine());

                    Console.WriteLine($" ***** Digite novo Valor da Nota Fiscal: {notaFiscal.ValorNotaFiscal} *****");
                    notaFiscal.ValorNotaFiscal = decimal.Parse(Console.ReadLine());

                    Console.WriteLine($" ******** Digite novo Nome do Produto: {notaFiscal.NomeProdutoVendido} ******** ");
                    notaFiscal.NomeProdutoVendido = Console.ReadLine();

                    Console.WriteLine($"******** Selecione novo Tipo de Imposto ********");
                    Console.WriteLine($"1 - {TipoImpostoEnum.ICMS}\n" +
                                      $"2 - {TipoImpostoEnum.IOF}\n" +
                                      $"3 - {TipoImpostoEnum.IPI}\n");
                    notaFiscal.TipoImposto = SelecaoImpostoEnum.ImpostoSelecao(Console.ReadLine());

                    Console.WriteLine($"******** Digite novo valor de Imposto: {notaFiscal.ValorTotalImposto} ********");
                    notaFiscal.ValorTotalImposto = decimal.Parse(Console.ReadLine());

                    notaFiscal.DataAlteracao = DateTime.Now;
                    Console.WriteLine($"================== ITENS ALTERADOS COM SUCESSO!!! ==================");
                }
                else
                {
                    Console.WriteLine("--------- ITENS NÃO ALTERADOS ---------");
                }
            }
        }
    }
}
