using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_3
{
    class Hotel
    {
        public double price_per_day { get; set; }
        public int num_day { get; set; }
        public string season { get; set; }
        public string discount { get; set; }
        public void tinh_tien()
        {
            switch(season)
            {
                case "Autumn":
                    if (discount == "VIP")
                    {
                        Console.WriteLine("{0} {1} {2} {3} co gia la : {4}",price_per_day,num_day,season,discount, price_per_day * num_day * 1 * 0.8);
                    }
                    else if (discount == "SecondVisit")
                    {
                        Console.WriteLine("{0} {1} {2} {3} co gia la : {4}", price_per_day, num_day, season, discount, price_per_day * num_day * 1 * 0.9);
                    }
                    else if (discount == "None" || discount == "")
                    {
                        Console.WriteLine("{0} {1} {2} {3} co gia la : {4}", price_per_day, num_day, season, discount, price_per_day * num_day * 1);
                    }
                break;

                case "Spring":
                    if (discount == "VIP")
                    {
                        Console.WriteLine("{0} {1} {2} {3} co gia la : {4}", price_per_day, num_day, season, discount, price_per_day * num_day * 2 * 0.8);
                    }
                    else if (discount == "SecondVisit")
                    {
                        Console.WriteLine("{0} {1} {2} {3} co gia la : {4}", price_per_day, num_day, season, discount, price_per_day * num_day * 2 * 0.9);
                    }
                    else if (discount == "None" || discount == "")
                    {
                        Console.WriteLine("{0} {1} {2} {3} co gia la : {4}", price_per_day, num_day, season, discount, price_per_day * num_day * 2);
                    }
                break;

                case "Summer":
                    if (discount == "VIP")
                    {
                        Console.WriteLine("{0} {1} {2} {3} co gia la : {4}", price_per_day, num_day, season, discount, price_per_day * num_day * 4 * 0.8);
                    }
                    else if (discount == "SecondVisit")
                    {
                        Console.WriteLine("{0} {1} {2} {3} co gia la : {4}", price_per_day, num_day, season, discount, price_per_day * num_day * 4 * 0.9);
                    }
                    else if (discount == "None" || discount == "")
                    {
                        Console.WriteLine("{0} {1} {2} {3} co gia la : {4}", price_per_day, num_day, season, discount, price_per_day * num_day * 4);
                    }
                    break;
                case "Winter":
                    if (discount == "VIP")
                    {
                        Console.WriteLine("{0} {1} {2} {3} co gia la : {4}", price_per_day, num_day, season, discount, price_per_day * num_day * 3 * 0.8);
                    }
                    else if (discount == "SecondVisit")
                    {
                        Console.WriteLine("{0} {1} {2} {3} co gia la : {4}", price_per_day, num_day, season, discount, price_per_day * num_day * 3 * 0.9);
                    }
                    else if (discount == "None" || discount == "")
                    {
                        Console.WriteLine("{0} {1} {2} {3} co gia la : {4}", price_per_day, num_day, season, discount, price_per_day * num_day * 3);
                    }
                break;
            }
        }
    }
}
