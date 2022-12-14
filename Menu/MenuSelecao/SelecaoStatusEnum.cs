using devindocuments.Menu.MenuEnum;

namespace devindocuments.Menu.MenuSelecao
{
    public class SelecaoStatusEnum
    {
        public static StatusDocumentoEnum StatusSelecao(string valorStatus)
        {
            switch (valorStatus)
            {
                case "1":
                    return StatusDocumentoEnum.Ativo;

                case "2":
                    return StatusDocumentoEnum.EmTramitacao;

                case "3":
                    return StatusDocumentoEnum.Suspenso;
                default: return StatusDocumentoEnum.Ativo;
            }
        }
    }
}