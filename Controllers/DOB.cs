using firstProject.TO_TransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProject.Controllers
{
    public class DOB //criando classe public (vs private) para poder usar em outros arquivos do mesmo codigo
    {
        public DateTime CapturaDOB() //funcao para capturar input DOB
        {

        inicioDOB: //label para voltar o "loop" para esse ponto

            Console.WriteLine("Digite DOB no Formato YYYY/MM/DD"); //pegar input
            string valorTemporario = Console.ReadLine(); //input = valorTemporario

            if (DateTime.TryParse(valorTemporario, out DateTime DataConvertida)) //se formato imput for correto = data conv
            {
                return DataConvertida;
            }

            else
            {
                Console.WriteLine("formato invalido");
                goto inicioDOB;
            }

        } //fechar funcao
    } //fechar classe
} //fechar controller