namespace Api_BotWhatsApp.Api.Model
{
    public record MensagensWhatsApp
    {
        public string Telefone { get; init; }
        public string Nome { get; init; }
        public string Mensagem { get; init; }

        public MensagensWhatsApp(string telefone, string nome, string mensagem)
        {
            Telefone = telefone;
            Nome = nome;
            Mensagem = mensagem;
        }

        public void Deconstruct(out string telefone, out string nome, out string mensagem)
        {
            telefone = Telefone;
            nome = Nome;
            mensagem = Mensagem;
        }
    }
}
