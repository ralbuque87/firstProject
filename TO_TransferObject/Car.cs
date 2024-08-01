using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProject.TO_TransferObject
{
    public sealed class Car : Brand //cria uma classe car publica e selada, com alguma relacao a outra classe brand
    {
        public int Code { get; set; } //atributo 1 da classe (integer)
        public string Description { get; set; } //atributo 2 da classe (string)
        public DateTime Data { get; set; } //atributo 3 da classe (DateTime)
}

}
