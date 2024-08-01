using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProject.TO_TransferObject
{
    public abstract class Brand //cria classe public e abstrata (so pode ser usada herdada) Brand
    {
        public string Name { get; set; } //atributo 1 da classe (string)
        public string Pais { get; set; } //atributo 2 da classe (string)
    }
}
