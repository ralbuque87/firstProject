﻿using firstProject.TO_TransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProject.Controllers
{
    public class CEP //criando classe public (vs private) para poder usar em outros arquivos do mesmo codigo
    {
        public string CapturaCEP () //funcao para capturar input CEP
        {
            inicioCEP: //label para inicio da funcao

            Console.WriteLine("Digite CEP"); //pegar input 
            string valorTemporario = Console.ReadLine(); //input = valorTemporario
            bool isNumber = int.TryParse(valorTemporario, out int numero); //Verificar se input tem algum integer

            if (isNumber == true) //se input for verdareiro, contem numeros no string.
            {
                return valorTemporario; //se input for aceito, retorna
            }

            else
            {
                Console.WriteLine("formato invalido, use apenas numeros"); //msg de alerta para input invalido
                goto inicioCEP; //voltar para inicio do "loop" 
            }
        } //fechando funcao
    } //fechando classe
} //fechandro controller
