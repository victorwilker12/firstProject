using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace first_project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> city = new List<string>();

            city.Add("São Paulo");
            city.Add("Fortaleza");
            city.Add("Mogi Mirin");
            city.Add("Rio de Janeiro");
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

