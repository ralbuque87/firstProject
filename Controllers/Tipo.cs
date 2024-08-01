namespace firstProject.Controllers
{
    public class Tipo //criando classe public (vs private) para poder usar em outros arquivos do mesmo codigo
    {
        public string CapturaTipo () //funcao para capturar input tipo pessoa
        {

        inicioTipo: //label para voltar o "loop" para esse ponto

            Console.WriteLine("Digite qual tipo de pessoa: Fisica ou Juridica?"); //pegar input
            string valorTemporario = Console.ReadLine().ToLower(); //input convertido pra minusculo e registrado em nova variavel

            if (valorTemporario != "fisica" && valorTemporario != "juridica") //se input minusculo NAO for valido:
            {
                Console.WriteLine("formato invalido, escolha fisica ou juridica"); //msg de alerta para input invalido
                goto inicioTipo; //voltar para inicio do "loop" 
            }

            return valorTemporario; //se input for valido, variavel mantem o mesmo valor e retorna

        } //fechar funcao de capture
    } //fechar classe
} //fechar controller
