namespace App16
{
    public class VehicleCatalogue
    {
        public List<Vehicle> Vehicles;

        public VehicleCatalogue()
        {
            Vehicles = new List<Vehicle>();
        }

        public void SortByPrice(bool orderByDescending) 
        {
            if (orderByDescending == false)
            {
                Vehicles = Vehicles.OrderBy(item => item.Price).ToList();
            }
            else
            {
                Vehicles = Vehicles.OrderByDescending(item => item.Price).ToList();
            }
        }

        public void SortByYear(bool orderByDescending) 
        {
            if (orderByDescending == false)
            {
                Vehicles = Vehicles.OrderBy(item => item.Year).ToList();
            }
            else
            {
                Vehicles = Vehicles.OrderByDescending(item => item.Year).ToList();
            }
        }
        public void SortByKm(bool orderByDescending) 
        {
            if (orderByDescending == false)
            {
                Vehicles = Vehicles.OrderBy(item => item.Km).ToList();
            }
            else
            {
                Vehicles = Vehicles.OrderByDescending(item => item.Km).ToList();
            }
        }

        public List<Vehicle> FilterByBrand(string brand) 
        {
            return Vehicles.FindAll(item => item.Brand.ToLower() == brand.ToLower());
        }

        public void ShowAllVehicles() 
        {
            for (int i = 0; i < Vehicles.Count; i++)
            {
                Console.WriteLine((i + 1) + ": " + Vehicles[i].GetData());
            }
        }

        public static void ShowAllVehiclesFromCollection(List<Vehicle> collection)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                Console.WriteLine((i + 1) + ": " + collection[i].GetData());
            }
        }
    }
}
