using devindocuments.Menu;
namespace devindocuments.Classes
{
    public class DevinDocuments
    {
        //private List<DevinDocuments> _listaDocumentos{get; set;}
        private string _codigoDocumento;
        private DateTime _dataCadastro = DateTime.Now;
        private DateTime _dataAlteracao;
        private string _nomeEstabelecimento;
        private string _cpnj;
        private StatusDocumentoEnum _statusDocumento;
        private int _idFuncionario;

        // public List<DevinDocuments> ListaDocumentos
        // {
        //     get{return this.ListaDocumentos;}
        //     set{this.ListaDocumentos = value;}
        // }
        public string CodigoDocumento
        {
            get{return this.CodigoDocumento;}
            set{this.CodigoDocumento = value;}
        }
        public DateTime DataCadastro
        {
            get{return this.DataCadastro;}
            set{this.DataCadastro = value;}
        }
        public DateTime DataAlteracao
        {
            get{return this.DataAlteracao;}
            set{this.DataAlteracao = value;}
        }
        public string NomeEstabelecimento
        {
            get{return this.NomeEstabelecimento;}
            set{this.NomeEstabelecimento = value;}
        }
        public string CNPJ
        {
            get{return this.CNPJ;}
            set{this.CNPJ = value;}
        }
         public StatusDocumentoEnum StatusDocumento
        {
            get{return this.StatusDocumento;}
            set{this.StatusDocumento = value;}
        }
         public int IdFuncionario
        {
            get{return this.IdFuncionario;}
            set{this.IdFuncionario = value;}
        }  

        public DevinDocuments(string codigoDocumento, DateTime dataCadastro, string nomeEstabelecimento, string cpnj, StatusDocumentoEnum statusDocumento)
        {
            this.CodigoDocumento = codigoDocumento;
            this.DataCadastro = dataCadastro;
            this.NomeEstabelecimento = nomeEstabelecimento;
            this.CNPJ = cpnj;
            this.StatusDocumento = statusDocumento;
        }
  
        public void CadastrarDocumento(DevinDocuments devinDocuments)
        {
            Console.WriteLine("Nota fiscal");
        }
         public void ListarDocumentos(DevinDocuments devinDocuments)
        {
            Console.WriteLine("Documentos Listados");
        } 
        //  public void AlterarItensDocumento(DevinDocuments devinDocuments)
        // {
        //     Console.WriteLine("Itens Alterados");
        // } 
        //  public void AlterarStatusDocumento()
        // {
        //     Console.WriteLine("Status alterado");
        // } 
    }
}