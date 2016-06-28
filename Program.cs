using System;

namespace UtilityClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testes - método ValidateDate
            DateValidatorUtils.ValidateDate("18:09:01"); //ok
            DateValidatorUtils.ValidateDate("25/01/2006 18:09:01"); //ok
            DateValidatorUtils.ValidateDate("25/01/2006 18:09:01.345"); //ok
            DateValidatorUtils.ValidateDate("1/31/2016"); //erro: formato en-US

            //Testes - método ValidateDateTime
            //1- Testar string com horas, minutos e segundos
            DateValidatorUtils.ValidateDateTime("18:09:01"); //ok
            DateValidatorUtils.ValidateDateTime("18:09:91"); //erro
            DateValidatorUtils.ValidateDateTime("31/05/1999 18:09:01"); //erro

            //Testes - método ValidateDateTimeMillis
            //2- Testar string com horas, minutos, segundos e milissegundos
            DateValidatorUtils.ValidateDateTimeMillis("8:32:45.126"); //ok
            DateValidatorUtils.ValidateDateTimeMillis("07/12/2008 8:32:45.126"); //erro

            Console.ReadLine();
        }
    }
}