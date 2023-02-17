using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    public class userinterface
    {
        public void Book ()
        {
            InventoryManager book = new InventoryManager();

            bool close = true;

            while (close)
            {
                Console.WriteLine(" Inventory \n1- add to cart \n2- for view \n3- delet\n4-edit\n5 -for save\n6-old record");
                char option = Console.ReadLine()[0];


                switch (option)
                {
                    case '1':
                              book.Add();

                        break;
                    case '2':
                              book.View();
                        break;
                    case '3':
                              book.delet();
                        break;
                    case '4': book.Edit();

                        break;
                    case '5':book.save();
                        
                        break;
                    case '6':book.record();
                        
                        break;
                    case '7':
                            close=false;
                        
                        break;
                    default:
                            Console.WriteLine("");
                        break;
                }
            }
        }

         }
}

