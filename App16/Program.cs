using ITSchool.AppUtilities;


namespace App16
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Application16 app = new Application16();
            app.Launch();
        }
    }

    public class Application16 : ApplicationBase
    {
        public Application16()
        {
            Cerinta = "Sa se realizeze un catalog pentru vehicule. Obiectele trebuie sa contina cel putin informatii despre marca, model, an fabricaţie, numar de kilometri si pret de vanzare. Elementele trebuie sa poata fi sortate si afisate dupa pret, an sau numarul de kilometri.";
        }

        public override void Launch()
        {
            VehicleCatalogue catalogue = new VehicleCatalogue();

            catalogue.Vehicles.Add(new Vehicle("Chevrolet", "Aveo", 2010, 153000, 2300));
            catalogue.Vehicles.Add(new Vehicle("Volkswagen", "Polo", 2011, 120000, 3000));
            catalogue.Vehicles.Add(new Vehicle("Renault", "Megane", 2012, 175000, 5000));
            catalogue.Vehicles.Add(new Vehicle("Opel", "Corsa", 2004, 180000, 3200));
            catalogue.Vehicles.Add(new Vehicle("Mercedes", "GLA", 2020, 20000, 38280));
            catalogue.Vehicles.Add(new Vehicle("Seat", "Noul Leon", 2024, 100, 27000));
            catalogue.Vehicles.Add(new Vehicle("Seat", "Leon", 2006, 200000, 3000));
            catalogue.Vehicles.Add(new Vehicle("Opel", "Zafira", 1999, 245000, 500));
            catalogue.Vehicles.Add(new Vehicle("Chevrolet", "Camaro", 2020, 60000, 35000));

            catalogue.ShowAllVehicles();

            catalogue.SortByPrice(true);

            Console.WriteLine();

            catalogue.ShowAllVehicles();

            List<Vehicle> filteredList = catalogue.FilterByBrand("SeaT");

            Console.WriteLine();

            VehicleCatalogue.ShowAllVehiclesFromCollection(filteredList);
        }
    }
}

