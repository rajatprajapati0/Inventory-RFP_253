using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace inventory
{
    public class InventoryManager
    {

        private Inventory inventory;

        public InventoryManager()
        {

            inventory = new Inventory();

        }
        public void Edit()
        { 
                Console.WriteLine("enter opttion for Edit inventory option\n a- rice\nb-wheat\nc-pulse");
                char option = Console.ReadLine()[0];
                switch (option)
                {
                    case 'a':
                        Console.WriteLine("enter brand  name wich u want to edit ");
                        string brandname = Console.ReadLine();
                        Seed seed = null;
                        foreach (var item in inventory.Rice)
                        {
                            if (item.BrandName == brandname)
                            {
                                seed = item;
                            }
                        }
                        if (seed != null)
                        {
                                 seed = Takeinput();
                            for (int i = 0; i < inventory.Rice.Count; i++)
                            {
                                if (inventory.Rice[i].BrandName.Equals(brandname))
                                {
                                    inventory.Rice.RemoveAt(i);
                                   inventory.Rice.Add(seed);

                                }

                            }
                            Console.WriteLine("edited");
                        }

                        else { Console.WriteLine("inventory is empty"); }
                        break;

                    case 'b':
                        Console.WriteLine("enter brand  name wich u want to edit ");
                        brandname = Console.ReadLine();
                        seed = null;
                        foreach (var item in inventory.Wheats)
                        {
                            if (item.BrandName == brandname)
                            {
                                seed = item;
                            }
                        }
                        if (seed != null)
                        {  seed = Takeinput();
                            for (int i = 0; i < inventory.Wheats.Count; i++)
                            {
                                if (inventory.Wheats[i].BrandName.Equals(brandname))
                                {
                                    inventory.Wheats.RemoveAt(i);
                                inventory.Wheats.Add(seed);

                            }
                            
                        }
                            Console.WriteLine("Edited");
                        }

                        else { Console.WriteLine("inventory is empty"); }
                        break;
                    case 'c':
                        Console.WriteLine("enter brand  name wich u want to edit ");
                        brandname = Console.ReadLine();
                        seed = null;
                        foreach (var item in inventory.Pulses)
                        {
                            if (item.BrandName == brandname)
                            {
                                seed = item;
                            }
                        }
                        if (seed != null)
                        {
                        seed= Takeinput();
                            for (int i = 0; i < inventory.Pulses.Count; i++)
                            {
                                if (inventory.Pulses[i].BrandName.Equals(brandname))
                                {
                                    inventory.Pulses.RemoveAt(i);
                                   inventory.Pulses.Add(seed);
                                }

                            }
                            Console.WriteLine("Edited");
                        }

                        else { Console.WriteLine("inventory is empty"); }
                        break;
               }

        }

        public void save() 
        {
            string path = @"E:\bridgelabz\RFP-253-dotnet\Day 11_12\inventory\inventory.json";
            var jsoninventory = JsonConvert.SerializeObject(inventory,Formatting.Indented);
           
            File.WriteAllText(path, jsoninventory);

        
        }

        public void record() 
        {
            string path = @"E:\bridgelabz\RFP-253-dotnet\Day 11_12\inventory\inventory.json";
           var json= File.ReadAllText(path);
            inventory =JsonConvert.DeserializeObject<Inventory>(json);
            View();
        }

        public void delet()
        {
            Console.WriteLine("enter opttion for deleting inventory option\n a- rice\nb-wheat\nc-pulse");
            char option = Console.ReadLine()[0];
            switch (option)
            {
             case 'a':
             Console.WriteLine("enter brand  name wich u want to delet ");
             string brandname = Console.ReadLine();
             Seed seed = null;
               foreach (var item in inventory.Rice)
               { 
                  if (item.BrandName== brandname) 
                  {
                            seed=item;  
                  }       
               }
               if(seed!=null) 
               {
                   for(int i=0;i<inventory.Rice.Count;i++)
                   {
                       if (inventory.Rice[i].BrandName.Equals(brandname))
                       {
                                inventory.Rice.RemoveAt(i);
                               
                       }
                   
                   }
                        Console.WriteLine("deleted");
               }

                    else { Console.WriteLine("inventory is empty"); }    
                   break;

                case 'b':
                    Console.WriteLine("enter brand  name wich u want to delet ");
                    brandname = Console.ReadLine();
                    seed = null;
                    foreach (var item in inventory.Wheats)
                    {
                        if (item.BrandName == brandname)
                        {
                            seed = item;
                        }
                    }
                    if (seed != null)
                    {
                        for (int i = 0; i < inventory.Rice.Count; i++)
                        {
                            if (inventory.Wheats[i].BrandName.Equals(brandname))
                            {
                                inventory.Wheats.RemoveAt(i);

                            }

                        }
                        Console.WriteLine("deleted");
                    }

                    else { Console.WriteLine("inventory is empty"); }
                    break;
                case 'c':
                    Console.WriteLine("enter brand  name wich u want to delet ");
                    brandname = Console.ReadLine();
                    seed = null;
                    foreach (var item in inventory.Pulses)
                    {
                        if (item.BrandName == brandname)
                        {
                            seed = item;
                        }
                    }
                    if (seed != null)
                    {
                        for (int i = 0; i < inventory.Pulses.Count; i++)
                        {
                            if (inventory.Rice[i].BrandName.Equals(brandname))
                            {
                                inventory.Rice.RemoveAt(i);

                            }

                        }
                        Console.WriteLine("deleted");
                    }

                    else { Console.WriteLine("inventory is empty"); }
                    break;

            }

        }

        public void View()
        {
           
            Console.WriteLine(inventory.ToString());
        }

        public void Add()
        {
            Console.WriteLine(" add to cart \na- for rice\nb- for wheats\nc-pulses ");
            char option = Console.ReadLine()[0];


            switch (option)
            {
                case 'a':
                    inventory.Rice.Add(Takeinput());
                    break;
                case 'b':
                    inventory.Wheats.Add(Takeinput());
                    break;
                case 'c':
                    inventory.Pulses.Add(Takeinput());
                    break;
                default:
                    Console.WriteLine("");
                    break;

            }

        }

        private Seed Takeinput() 
        {
            Console.WriteLine("enter brand name ");
            string brandname = Console.ReadLine();
            Console.WriteLine("weight");
            int wight = int.Parse(Console.ReadLine());
            Console.WriteLine("price per kg.");
            int price = int.Parse(Console.ReadLine());
            Seed seed = new Seed();

            {
                seed.BrandName = brandname;
                seed.Wight = wight;
                seed.price = price;
            }
            return seed;
        }
    }

}
