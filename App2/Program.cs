namespace App02
{
    class Program
    {
        static void Main()
        {
            Application02 app = new Application02();

            // Afisam in consola cerinta
            Console.WriteLine(app.Cerinta);

            // lansam aplicatia
            app.Launch();
        }
    }
}
