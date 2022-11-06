using devindocuments.Menu.MenuEnum;
using devindocuments.Classes;

namespace devindocuments.Relatorios
{
    public static class ListaDocuments
    {
        public static List<NotaFiscal> ListaNotaFiscal = new List<NotaFiscal>
        {
            new NotaFiscal(dataAlteracao:null , nomeEstabelecimento: "Mecanica", cpnj: "127312323",
                          statusDocumento: StatusDocumentoEnum.Ativo, idFuncionario: 1, valorNotaFiscal: 245.34M,
                          nomeProdutoVendido: "Manutenção carro", tipoImpostoEnum: TipoImpostoEnum.ICMS,
                          valorTotalImposto: 12)
        };
        public static List<LicencaFuncionamento> ListaLicencaFuncionamento = new List<LicencaFuncionamento>
        {
            new LicencaFuncionamento(dataAlteracao:null , nomeEstabelecimento: "Mercearia", cpnj: "127372193",
                                    statusDocumento: StatusDocumentoEnum.Ativo, idFuncionario: 1,
                                    endereco: "Rua 2 de janeiro", AreaAtuacaoEnum.Industrial)
        };
        public static List<Contrato> ListaContrato = new List<Contrato>
        {
            new Contrato(dataAlteracao:null , nomeEstabelecimento: "Padaria", cpnj: "16546542193",
                        statusDocumento: StatusDocumentoEnum.Ativo, idFuncionario: 1, finalidade: "venda",
                        testemunhas: "Jose", dataExpiracao: new DateTime(2022,03,10))
        };
    }
}