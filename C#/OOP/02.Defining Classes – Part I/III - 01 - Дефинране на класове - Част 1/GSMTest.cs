using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III___01___Дефинране_на_класове___Част_1
{
    class GSMTest
    {
        static void Main(string[] args)
        {

            

            Battery testBattery = new Battery("China", 100, 200, BatteryType.NiCd);
            Display testDisplay = new Display(480, 820, 16);

            GSM Nokia = new GSM("Äshe", "Nokia", 120.00M, "Pesho", testBattery, testDisplay);
            GSM SamsungS3 = new GSM("S3", "Samsung", 800.00M, "Bongo", testBattery, testDisplay);
            GSM SamsungH1 = new GSM("i8320", "Samsung", 150.00M, "I", testBattery, testDisplay);

            GSM[] phones = new GSM[] 
            {
                Nokia,SamsungS3,SamsungH1
            };
            foreach (var item in phones)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(GSM.Iphone4S);

            Console.WriteLine(Nokia);


            
            Console.WriteLine(Nokia.TotalPrice() + " лв.");
            foreach (var item in Nokia.callHistory)
            {
                Console.WriteLine(item.Duration);
            }




        }
    }
}
