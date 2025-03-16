using System.Reflection.Metadata;

namespace App18
{
    public class Button
    {
        public event Action<string> Clicked;

        public string Name { get; set; }

        public Button(string name)
        {
            Name = name;
        }

        public void SimulateClick()
        {
            Clicked?.Invoke(Name);
        }
    }

    public class Window
    {
        public Window()
        {
            // Am putea pastra o lista cu toate butoanele create aici

            Button button = new Button("Buton 1");
            button.Clicked += CandUnButonEsteApasat;

            Button button2 = new Button("Buton 2");
            button2.Clicked += CandUnButonEsteApasat;

            Button button3 = new Button("Buton 3");
            button3.Clicked += CandUnButonEsteApasat;

            Button button4 = new Button("Buton 4");
            button4.Clicked += CandUnButonEsteApasat;

            Button button5 = new Button("Buton 5");
            button5.Clicked += CandUnButonEsteApasat;
        }

        public void CandUnButonEsteApasat(string name)
        {
            Console.WriteLine($"Butonul {name} a fost apasat.");
        }
    }
}
