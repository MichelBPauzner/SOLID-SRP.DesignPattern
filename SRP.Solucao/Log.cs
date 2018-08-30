namespace SRP.Solucao
{
    public static class Log
    {
        public static void Logar(string titulo, string mensagem)
        {
            System.Diagnostics.EventLog.WriteEntry(titulo, mensagem);
        }
    }
}
