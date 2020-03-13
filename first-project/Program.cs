using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;





namespace first_project
{

    class Car
    {
        public string Name { get; set; }
        public string Marca { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<string> city = new List<string>();

            city.Add("São Paulo");
            city.Add("Fortaleza");
            city.Add("Mogi Mirin");
            city.Add("Rio de Janeiro");


            Car[] cars =
            {
            new Car { Name="Oelta",Marca="GM"},
            new Car { Name="Onix",Marca="GM"},
            new Car { Name="Oamaro",Marca="GM"}
        };
            // search first Caractere in list to string 
            bool SearchAll = cars.All(x => x.Name.StartsWith("O"));
            Console.WriteLine(
                "{0} cars name",
                SearchAll ? "All" : "not All");
            
            Console.ReadKey();


            // searchs  
            Console.WriteLine(SearchText(city, "Fortaleza"));
            SearchLinq(city, "Fortaleza").ForEach(x => Console.WriteLine(x));
            Console.WriteLine(SearchLinqLambda(city, "Rio de Janeiro"));
            Console.ReadKey();
        }

        public static string SearchText(List<string> List, string valuereturn)
        {
            foreach (string item in List)
            {
                if (item.Equals(valuereturn))
                    return item + " :item encontrado";
            }
            return null;
        }

        public static List<string> SearchLinq(List<string> List, string termo)
        {
            return (from item in List where item.Equals(termo) select item).ToList();
        }
        public static string SearchLinqLambda(List<string> List,string termo)
        {
            return "Item Encontrado: "+ List.First(x => x.Equals(termo));
        }
    }

    
}

