namespace SRP.Violacao
{
    public class Informacao
    {
        public void RetornaInformacao()
        {
            //Toda lógica para retornar informação do banco de dados e loga
            System.Diagnostics.EventLog.WriteEntry("Retorna Informação","Retorna alguma informação do banco de dados.");
        }

        public void SalvaInformacao()
        {
            //Toda lógica para salvar informação no banco de dados
            System.Diagnostics.EventLog.WriteEntry("Salva Informação", "Salva alguma informação do banco de dados.");
        }
    }
}
