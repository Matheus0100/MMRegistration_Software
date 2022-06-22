namespace Back_End_5.Personalization
{
    public static class BarraCarregamento
    {
        public static void Mostrar(string texto, int tempo)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write(texto);
            for (int i = 0; i < 3; i++)
            {
                Console.Write(". ");
                Thread.Sleep(tempo);
            }



            Console.ResetColor();
        }
    }
}