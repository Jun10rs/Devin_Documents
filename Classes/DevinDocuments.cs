namespace devindocuments.Classes
{
    public class DevinDocuments
    {
        private List<DevinDocuments> _listaDocumentos{get; set;}
        private int _codigoDocumento;
        private DateTime _dataCadastro = DateTime.Now;
        private DateTime _dataAlteracao;
        private string _nomeEstabelecimento;
        private string _cpnj;
        private StatusDocumentoEnum _statusDocumento;
        private int _idFuncionario;


        public List<DevinDocuments> ListaDocumentos
        {
            get{return this.ListaDocumentos;}
            set{this.ListaDocumentos = value;}
        }
        public int CodigoDocumento
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
         public TipoImpostoEnum StatusDocumento
        {
            get{return this.StatusDocumento;}
            set{this.StatusDocumento = value;}
        }
         public int IdFuncionario
        {
            get{return this.IdFuncionario;}
            set{this.IdFuncionario = value;}
        }      
        public void CadastroDocumentos()
        {
            Console.WriteLine("Documentos Cadastrados");
        }   
         public void ListarDocumentos()
        {
            Console.WriteLine("Documentos Listados");
        } 
         public void AlterarItensDocumento()
        {
            Console.WriteLine("Itens Alterados");
        } 
         public void AlterarStatusDocumento()
        {
            Console.WriteLine("Status alterado");
        } 

    }
}