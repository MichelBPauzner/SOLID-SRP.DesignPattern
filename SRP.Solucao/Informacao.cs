namespace SRP.Solucao
{
    public class Informacao
    {
        public void RetornaInformacao()
        {
            //Toda lógica para retorna informação do banco de dados
            Log.Logar("Retorna Informação", "Retorna alguma informação do banco de dados.");
        }

        public void SalvaInformacao()
        {
            //Toda lógica para salvar informação no banco de dados
            Log.Logar("Salva Informação", "Salva alguma informação do banco de dados.");
        }
    }
}
