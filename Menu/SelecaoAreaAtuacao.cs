namespace devindocuments.Menu
{
    public class SelecaoAreaAtuacao
    {
        public static AreaAtuacaoEnum AreaAtuacao(string valorAtuacao)
        {
            switch (valorAtuacao)
            {
                case "1":
                    return AreaAtuacaoEnum.Industrial;

                case "2":
                    return AreaAtuacaoEnum.Agropecuario;

                case "3":
                    return AreaAtuacaoEnum.Metalurgico;

                case "4":
                    return AreaAtuacaoEnum.Tecnologia;
                
                case "5":
                    return AreaAtuacaoEnum.Outro;
                default: return AreaAtuacaoEnum.Industrial;
            }
        }
    }
}