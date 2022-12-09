using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Addressbook addressbook = new Addressbook();
            while (true)
            {
                Console.WriteLine("1 Creat contact \n2 Display Contact \n3 Edit Contact \n4 Delete Contact");
                int option=Convert.ToInt32(Console.ReadLine()); 
                switch(option) 
                {
                    case 1:
                        addressbook.CreatContact();
                        break;
                    case 2:
                        addressbook.DisplayContact();
                        break;
                        case 3:
                        addressbook.EditContact();
                        break;
                    case 4:
                        addressbook.RemoveContact();
                        break;
                    default:
                        Console.WriteLine("Enter Valid option");    
                        break;
                }
                
            }


        }
    }
}