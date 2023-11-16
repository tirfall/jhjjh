using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace GeoMapGameLabor3
{
    public class Map
    {
        
        List<string> list_country = new List<string>();
        List<string> list_country2 = new List<string>();
        string ListName = "";
        Random random = new Random();
        int randomIndex;
        string randomCountry;

        public Map(string List_Name)
        {
            ListName = List_Name;
            
        }
        public void ListAndMap ()
        {
            try
            {
                
                using (StreamReader reader = new StreamReader(ListName))
                {
                    
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        list_country.Add(line);
                        list_country2.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine(list_country);

        }
        public string ListCountryIndex(int index)
        {
            int h = list_country.Count;
            if (index >= 0 && index < h)
            {
                return list_country[index];
            }
            else
            {
                return "Invalid Index";
            }
        }

        public string CountryName()
        {
            //if (list_country.Count == 0)
            //{
            //    return string.Empty;
            //}

            //do
            //{
            //    randomIndex = random.Next(list_country.Count);
            //    randomCountry = list_country[randomIndex];
            //    list_country2 = new List<string>();
            //    return randomCountry;

            //} while (list_country2.Contains(randomCountry));
            if (list_country.Count == 0)
            {
                // Если список пуст, вернуть пустую строку или другое значение по умолчанию
                return string.Empty;
            }

            // Получаем случайный индекс из списка
            if (list_country.Count > 1)
            {
                int randomIndex = random.Next(list_country2.Count);
                randomCountry = list_country2[randomIndex];
                list_country2.RemoveAt(randomIndex);
                return randomCountry;
            }
            else
            {
                randomCountry = list_country2[0];
                return randomCountry;
            }
            return string.Empty;
            


        }
        
    }
}
