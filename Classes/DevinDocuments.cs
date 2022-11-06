using devindocuments.Menu;
namespace devindocuments.Classes
{
    public class DevinDocuments
    {
        private string _codigoDocumento;
        private DateTime _dataCadastro;
        private DateTime? _dataAlteracao;
        private string _nomeEstabelecimento;
        private string _cpnj;
        private StatusDocumentoEnum _statusDocumento;
        private int _idFuncionario;

        public string CodigoDocumento
        {
            get{return this._codigoDocumento;}
        }
        public DateTime DataCadastro
        {
            get{return this._dataCadastro;}
        }
        public DateTime? DataAlteracao
        {
            get{return this._dataAlteracao;}
        }
        public string NomeEstabelecimento
        {
            get{return this._nomeEstabelecimento;}
            set{this._nomeEstabelecimento = value;}
        }
        public string CNPJ
        {
            get{return this._cpnj;}
            set{this._cpnj = value;}
        }
         public StatusDocumentoEnum StatusDocumento
        {
            get{return this._statusDocumento;}
            set{this._statusDocumento = value;}
        }
         public int IdFuncionario
        {
            get{return this._idFuncionario;}
        }  

        public DevinDocuments(DateTime? dataAlteracao, string nomeEstabelecimento, 
                                string cpnj, StatusDocumentoEnum statusDocumento, int idFuncionario)
        {
            this._codigoDocumento = Guid.NewGuid().ToString();
            this._dataCadastro = DateTime.Now;
            this._dataAlteracao = dataAlteracao;
            this._nomeEstabelecimento = nomeEstabelecimento;
            this._cpnj = cpnj;
            this._statusDocumento = statusDocumento;
            this._idFuncionario = idFuncionario;
        }
        public DevinDocuments()
        {

        }
    }
}