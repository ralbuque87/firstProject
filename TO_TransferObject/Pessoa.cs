
namespace firstProject.TO_TransferObject
{
    public class Pessoa //public (vs private) para poder usar em outros arquivos do mesmo codigo
    {
        public string Tipo { get; set; } //string - Atributo 1 para classe criada (Pessoa)
        public string Nome { get; set; } //string - Atributo 2 para classe criada (Pessoa)
        public DateTime DOB { get; set; } //datetime se usa mais que date - Atributo 3 para classe criada (Pessoa)
        public string CEP { get; set; } //long = int mais comprido - Atributo 4 para classe criada (Pessoa) [LONG?]

    }

 }
