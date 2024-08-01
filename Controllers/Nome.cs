using firstProject.TO_TransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProject.Controllers
{
    public class Nome //criando classe public (vs private) para poder usar em outros arquivos do mesmo codigo
    {
        public string CapturaNome() //funcao para capturar input nome pessoa
        {

        inicioNome: //label para voltar o "loop" para esse ponto

            Console.WriteLine("Digite seu nome"); //pegar input de nome
            string valorTemporario = Console.ReadLine(); //input = valorTemporario
            bool isNumber = int.TryParse(valorTemporario, out int numero); //Verificar se input tem algum integer

            if (isNumber == true) //se input for verdareiro, contem numeros no string. [SE FOR ALPHANUMERIC NAO BLOQUEIA]
            {
                Console.WriteLine("formato invalido, use apenas letras"); //msg de alerta para input invalido
                goto inicioNome; //voltar para inicio do "loop" 
            }

            else
            {
               return valorTemporario; //se input for aceito, retorna
            }
        } //fechar funcao
    } //fechar classe obj
} //fechar controller