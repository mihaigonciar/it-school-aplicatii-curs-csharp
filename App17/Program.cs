using ITSchool.AppUtilities;

namespace App17
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Square s1 = new Square(2);
            Square s2 = new Square(3);
            Square s3 = new Square(4);

            Rectangle r1 = new Rectangle(2, 3);
            Rectangle r2 = new Rectangle(3, 4);
            Rectangle r3 = new Rectangle(4, 5);

            Console.WriteLine(s1.GetArea() + " " + s1.GetPerimeter());
        }
    }

    public class Application17 : ApplicationBase
    {
        public Application17()
        {
            Cerinta = "Sa se defineasca urmatoarele forme geometrice: patrat, dreptunghi, cerc, triunghi. Elementele trebuie sa poata oferi metode de calcul pentru arie si perimetru.";
        }

        public override void Launch()
        {

        }
    }
}