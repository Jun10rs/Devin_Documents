using System;
using System.Collections.Generic;
using System.Linq;
using devindocuments.Menu;

namespace devindocuments.Classes
{
    public class AlterarStatus
    {
        public void AlterarStatusDocumento()
        {
            Console.WriteLine("Foram encontrados estes documentos");
            
            // foreach (var item in ListaDocuments.ListaContrato)
            // {
            //     if (item.StatusDocumento == StatusDocumentoEnum.Ativo)
            //     {
            //         Console.WriteLine($"================= RELATÓRIO DE CONTRATOS =================\n" +
            //                           $"Id do Funcionario: {item.IdFuncionario}\n" +
            //                           $"Codigo do documento: {item.CodigoDocumento}\n" +
            //                           $"Data de Cadastro: {item.DataCadastro}\n" +
            //                           $"Nome Estabelecimento {item.NomeEstabelecimento}\n" +
            //                           $"Numero CNPJ: {item.CNPJ}\n" +
            //                           $"Status do Documento: {item.StatusDocumento}\n" +
            //                           $"Finalidade: {item.Finalidade}\n" +
            //                           $"Testemunhas: {item.Testemunhas}\n" +
            //                           $"Data de Expiração: {item.DataExpiracao}\n" +
            //                           $"================= RELATÓRIO DE CONTRATOS =================\n");
            //     }
            //     else
            //     {
            //         Console.WriteLine("Documento não encontrado");
            //     }
                Console.WriteLine("Digite os 5 primeiros digitos do Codigo do Documento ");
                var editar = Console.ReadLine();
                var doc = ListaDocuments.ListaContrato.Where(c => c.NomeEstabelecimento.Equals(editar)).FirstOrDefault();
                if(doc != null)
                {
                    // Console.WriteLine($"Status do documento: {doc.StatusDocumento}\n" +
                    //                   $"CNPJ: {doc.CNPJ}");
                    Console.WriteLine("Digite novo cnpj");
                    doc.CNPJ = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Não cadastrou");
                }

            
        }
    }
}