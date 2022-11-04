using devindocuments.Menu;

namespace devindocuments.Classes
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