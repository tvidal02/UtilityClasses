using System;

namespace UtilityClasses
{
    /* Guideline: Como Criar uma Classe Utilitária */
    /* 0. Veja se você pode criar métodos de extensão como alternativa
     * 1. Crie uma classe estática stateless
     * 2. Stateless: não insira atributos ou propriedades 
     * 3. Crie métodos estáticos (vão ser chamados pelo nome da classe, sem instanciá-la, por isso que são sem estado)
     * 4. Crie uma classe para testar os métodos da classe utilitária
     * 5. Chame os métodos pelo nome da classe
     */

    public static class DateValidatorUtils
    {
        /// <summary>
        /// Valida uma data string no formato dd/mm/aaaa HH:MM:SS:MMM
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool ValidateDate(string date)
        {
            return IsDateTime(date) ? true : false;
        }

        /// <summary>
        /// Valida uma data string em horas, minutos e segundos e devolve um objeto DateTime
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime ValidateDateTime(string date) 
        {
            string[] arrDate = date.Split(':');
            
            try
            {
                var hour = Convert.ToInt32(arrDate[0]);
                var min = Convert.ToInt32(arrDate[1]);
                var sec = Convert.ToInt32(arrDate[2]);

                DateTime objDate = new DateTime(hour, min, sec);

                if (!IsDateTime(date))
                    throw new Exception("Erro na validação");
                
                return objDate;
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        /// <summary>
        /// Valida uma data string em horas, minutos, segundos e milissegundos e devolve um objeto DateTime
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime ValidateDateTimeMillis(string date)
        {
            string[] arrDate = date.Split(':', '.');

            try
            {
                var hour = Convert.ToInt32(arrDate[0]);
                var min = Convert.ToInt32(arrDate[1]);
                var sec = Convert.ToInt32(arrDate[2]);
                var millis = Convert.ToInt32(arrDate[3]);

                DateTime objDate = new DateTime(
                    DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day,
                    hour, min, sec, millis);

                if (!IsDateTime(date))
                    throw new Exception("Erro na validação");

                return objDate;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static bool IsDateTime(string date) 
        {
            DateTime value;

            return DateTime.TryParse(date, out value) ? true : false;
        }
    }
}