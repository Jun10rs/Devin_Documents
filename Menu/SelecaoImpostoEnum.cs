namespace devindocuments.Menu
{
    public class SelecaoImpostoEnum
    {
        public static TipoImpostoEnum ImpostoSelecao(string valorStatus)
        {
            switch (valorStatus)
            {
                case "1":
                    return TipoImpostoEnum.ICMS;

                case "2":
                    return TipoImpostoEnum.IOF;

                case "3":
                    return TipoImpostoEnum.IPI;
                default: return TipoImpostoEnum.ICMS;
            }
        }
    }
}