using ITSchool.AppUtilities;

namespace App03
{
    public class Application03 : ApplicationBase
    {
        public Application03()
        {
            Cerinta = "Cititi un numar si calculati patratul acestuia. Afisati rezultatul.";
        }

        public override void Launch()
        {
            // Inregistrare numar intreg valid de la tastatura pentru "a"
            int a = Utils.GetIntFromKeyboard("a");

            // calculam patratul numarului si afisam
            int patrat = a * a;
            Console.WriteLine($"Patratul numarului \"a\" ({a}) este {patrat}.");
        }
    }
}
