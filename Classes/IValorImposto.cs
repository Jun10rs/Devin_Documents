namespace devindocuments.Classes
{
    public interface IValorImposto
    {
        decimal ObterValorImpostoIcms();
        
        decimal ObterValorImpostoIpi();
        
        decimal ObterValorImpostoIof();
        
        decimal ObterValorImpostoOutro();
        
        decimal CalcularTotalImposto();
    }
}