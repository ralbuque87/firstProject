using firstProject.Controllers;
using firstProject.TO_TransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

try //tentar realizar o codigo
{
    

    List<Car> listCar = new List<Car>(); //Criar nova lista com metodos <car> (code/description em outro arq) //memoria local

inicio:

    Console.WriteLine("Deseja consultar [1] ou cadastrar [2] ?");
    int.TryParse(Console.ReadLine(), out int opcao);

    if (opcao == 1)
    {
        Console.WriteLine("Insira numero matricula (Code)");
        string matriculaTemp = Console.ReadLine();
        int.TryParse(matriculaTemp, out int matricula);

        if (listCar.Where(x => x.Code == matricula).Any())
        {
            Console.WriteLine("Code" + listCar.Where(x => x.Code == matricula).FirstOrDefault().Code);
            Console.WriteLine("Name" + listCar.Where(x => x.Code == matricula).FirstOrDefault().Name);
            Console.WriteLine("Pais" + listCar.Where(x => x.Code == matricula).FirstOrDefault().Pais);
            Console.WriteLine("Description" + listCar.Where(x => x.Code == matricula).FirstOrDefault().Description);
            Console.WriteLine("Data" + listCar.Where(x => x.Code == matricula).FirstOrDefault().Data);
        }

        else
        {
            Console.WriteLine("Matricula nao encontrada");
            
        }

        goto inicio;
    }

    else if (opcao == 2)
    {
        Console.WriteLine("Hello, your database have a total of " + listCar.Count + " items"); //msg dizendo total de items na lista

        Car car = new Car(); //converter obj Car (outro arq) para car (nesse arq)

        Console.WriteLine("Description of car?"); //solicitar input 
        car.Description = Console.ReadLine(); //input = obj local car, atributo de Description

    inicioData:

        Console.WriteLine("Data Fab Carro?"); //solicitar input
        string valorTemp = Console.ReadLine(); //input = valorTemporario

        if (DateTime.TryParse(valorTemp, out DateTime DataConvertida)) //se formato imput for correto = data conv
        {
            car.Data = DataConvertida;
        }

        else
        {
            Console.WriteLine("formato invalido");
            goto inicioData;
        }


        Console.WriteLine("Brand name of car?"); //solicitar input
        car.Name = Console.ReadLine(); //input = obj local car, atributo de Name

        Console.WriteLine("Pais de Fab do Carro?"); //solicitar input
        car.Pais = Console.ReadLine();

        car.Code = listCar.Count; //objeto local car = adicionar contagem no atributo de Code.

        listCar.Add(car); //adcionar a lista obj local car

        Console.WriteLine("Your car entry saved with success, registration number: " + car.Code);
        Console.WriteLine("you car is: " + car.Description + " " + car.Name + " " + car.Pais + " " + car.Data);

        goto inicio;
    }
    else
    {
        Console.WriteLine("Opcao Invalida");
        goto inicio;
    }


} 

catch (Exception ex) //em caso da funcao try ter falha: [ESSE VARIAVEL EX PRECISAR SER DEFINIDO?]
{
    Console.WriteLine("Ocorreu um erro grave, contatar SAC"); //msg de erro em caso de falha
}


//List<string> listCity = new List<string>(); //criar nova lista (string) = listcity
//listCity.Add("Pedra"); //Add string "cidade" para lista listcity
//listCity.Add("João Pessoa");
//listCity.Add("New York");
//listCity.Add("Recife");
//listCity.Add("Garanhuns");

//inicioLista: //label comeco da lista

//Console.WriteLine("Digite o nome da cidade onde já nos encontramos:"); //solicitar input
//string cityName = Console.ReadLine(); //input = variavel cityname
//if (listCity.Contains(cityName)) //se input (cityname) estiver dentro da lista (listcity)
//{
//    Console.WriteLine("A cidade informada {" + cityName + "} está correta!"); //output com nome do input (cityname)
//}

//else
//{
//    Console.WriteLine("A cidade informada {" + cityName + "} está incorreta!, tente novamente"); // output pede pra tentar denovo
//    goto inicioLista; //retornar para label inicio da lista
//}

//Pessoa pessoa = new Pessoa(); //Converter obj Pessoa (outro arq) para pessoa (nesse arq), e armazenar memoria local

//Tipo tipo = new Tipo(); //converter obj Tipo (outro arq) para tipo (nesse arq)
//Nome nome = new Nome(); //converter obj Nome (outro arq) para nome (nesse arq)
//DOB dob = new DOB(); //converter obj DOB (outro arq) para dob (nesse arq)
//CEP cep = new CEP(); //converter obj CEP (outro arq) para cep (nesse arq)

//pessoa.Tipo = tipo.CapturaTipo(); //variavel Tipo (obj local pessoa) = resultado funcao (outro arq)
//pessoa.Nome = nome.CapturaNome(); //variavel Nome (obj local pessoa) = resultado funcao (outro arq)
//pessoa.DOB = dob.CapturaDOB(); //variavel DOB (obj local pessoa) = resultado funcao (outro arq)
//pessoa.CEP = cep.CapturaCEP(); //variavel CEP (obj local pessoa) = resultado funcao (outro arq)


//if (pessoa.Tipo == "fisica" || pessoa.Tipo == "juridica" ) //se tipo for fis ou jur, mostrar os resultados [COMO COLOCAR "CONTROLLER" para isso?]
//{
//    Console.WriteLine(pessoa.Tipo);
//    Console.WriteLine(pessoa.Nome);
//    Console.WriteLine(pessoa.DOB.ToString("dd/MM/yy"));
//    Console.WriteLine(pessoa.CEP.ToString());
//}

//else
//{
//    Console.WriteLine("Nao e uma pessoa fisica nem juridica"); //se tipo for juridica, nao mostrar os resultados
//}


//List<City> listCity = new List<City>(); // Criar nova lista listCity com metodos <city> (add/name em outro arq)
//                                        // e armazenar memoria local

//listCity.Add(new City() { DDD = 87, Name = "Garanhuns" });
//listCity.Add(new City() { DDD = 87, Name = "Pedra" });
//listCity.Add(new City() { DDD = 83, Name = "Jampa" });
//listCity.Add(new City() { DDD = 81, Name = "Recife" });

//inicio: //label de retorno 

//Console.WriteLine("Digite o DDD e descubra as cidades a qual faz parte:"); //solicitar input

//string ddd = Console.ReadLine(); //input = ddd variavel (string)

//int.TryParse(ddd, out int dddint); //converter string ddd em int - novo variavel

//int count = 0; //contador: valor inicial = 0
//while (count < listCity.Count) //condicao: enquanto contador (max 3) for menor que total de items da lista (4)
//{
//    if (listCity[count].DDD == dddint) //procurar na lista [0..1..2..3] o respectivo DDD, e comparar com ddd do input
//    {
//        Console.WriteLine(listCity[count].Name); //se for igual, output o nome da cidade correspondendo aquele DDD
//    }
//    count++; //faz o IF statement loopar por toda lista
//}

//goto inicio; //leva paro o inicio

//SHORTCUTS TO KNOW: CTRL + K + D = Auto Ident Code
                   //CTRL + K + C = Comment Code
                   //CTRL + K + U = Undo Comment Code
