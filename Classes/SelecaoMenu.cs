using devindocuments.Menu;

namespace devindocuments.Classes
{
    public class SelecaoMenu
    {
        public static OpcaoMenuEnum ObterSelecaoMenu(string valorMenu)
        {
            switch (valorMenu)
            {
                case "1":
                    return OpcaoMenuEnum.CadastrarDocumento;

                case "2":
                    return OpcaoMenuEnum.ListaDocumento;

                case "3":
                    return OpcaoMenuEnum.AlterarItensDocumento;

                case "4":
                    return OpcaoMenuEnum.AlterarStatusDocumento;
                default: return OpcaoMenuEnum.CadastrarDocumento;
            }
        }
    }
}