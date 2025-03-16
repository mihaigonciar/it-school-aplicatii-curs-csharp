using ITSchool.AppUtilities;

namespace App18
{
    internal class Application18 : ApplicationBase
    {
        public Application18()
        {
            Cerinta = "Realizati o aplicatie de tip consola in care sa indepliniti urmatoarele cerinte, in ordine:" +
                "Creati o clasa numita “Button” in care sa definiti un eveniment “Clicked”. Evenimentul va fi declansat printr-o metoda publica numita “SimulateClick”. Elementele trebuie sa fie parte din obiecte.\n" +
                "Creati o clasa numita “Window”. Aceasta se va abona la evenimentul “Clicked” al oricarui buton adaugat in Constructor, iar listenerul va afisa un mesaj in consola.\n" +
                "Extindeti clasa Button, adaugand ca argument la eveniment numele butonului. Modificati clasa Window astfel incat denumirea butonului apasat sa fie transmisia.\n" +
                "Implementati un mecanism de citire de la tastatura in bucla. La introducerea corecta a denumirii unui buton existent, acestuia ii va fi apelata metoda “SimulateClick”.\n" +
                "Limitati elementele de cod astfel incat doar acele proprietati / metode dorite sa fie expuse.";
        }

        public override void Launch()
        {

        }
    }
}
