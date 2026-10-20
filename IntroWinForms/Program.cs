namespace IntroWinForms
{
    // Classe responsável apenas por "ligar" a aplicação.
    // Toda aplicação WinForms precisa de um método Main como este.
    internal static class Program
    {
        [STAThread] // Exigido pelo WinForms para interoperar com componentes COM (ex: caixas de diálogo)
        static void Main()
        {
            // Configurações visuais padrão do .NET moderno (fontes, DPI, temas)
            ApplicationConfiguration.Initialize();

            // Inicia a aplicação exibindo o formulário principal
            Application.Run(new Form1());
        }
    }
}
