using System;

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] workDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            String[] offDays = { "Saturday", "Sunday" };

            String[] price = {" Off - Peak"," Off - Peak"," Off - Peak"," Off - Peak"," Off - Peak"," Off - Peak"," Off - Peak"," Mid - Peak"," Mid - Peak"," Mid - Peak"," Mid - Peak"," On - Peak"," On - Peak",
                              " On - Peak"," On - Peak"," On - Peak"," On - Peak"," Mid - Peak"," Mid - Peak"," Off - Peak"," Off - Peak"," Off - Peak"," Off - Peak"," Off - Peak"};

            DateTime dat = new DateTime(2021, 11, 18, 23, 0, 0);

            dat = dat.AddMinutes(60);

            for (int i = 0; i < workDays.Length; i++)

            {
                Console.WriteLine("");

                String today = workDays[i];
                Console.WriteLine(today);

                if (today == offDays[0] || today == offDays[1])

                {
                    for (int x = 0; x < 24; x++)
                    {
                        
                        var partOfDay = dat.ToString("hh:mm tt");
                        
                        Console.WriteLine(partOfDay + ": Off - Peak");

                        dat = dat.AddMinutes(60);
                    }
                }

                else
                {
                    for (int x = 0; x < 24; x++)
                    {
                        var partOfDay = dat.ToString("hh:mm tt");

                        Console.WriteLine(partOfDay + ":" + price[x]);

                        dat = dat.AddMinutes(60);

                    }
                }

            }
        }
    }
}

