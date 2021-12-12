using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buku_ninja_menu_3_dan_4
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            List<string> scrolls = new List<string>() { "Book of Peace", "Scroll of Swords", "Silence Guide Book" };          
            var statusporgram = 0;
            Console.WriteLine("3. Search scroll");
            Console.WriteLine("4. Remove scroll");
            Console.WriteLine("Choose what to do");
            var milih = Convert.ToInt32(Console.ReadLine());
                if (milih == 3)
                {
                    Console.WriteLine("Insert scroll name");
                    var search = Console.ReadLine();
                    for (int i = 0; i < scrolls.Count; i++)
                    {
                        bool search1 = (search.Equals(scrolls[i], StringComparison.InvariantCultureIgnoreCase));
                        if (search1 == true)
                        {
                            scrolls.RemoveAt(i);
                            Console.WriteLine("Book Found. Queue number :" + (i + 1));                           
                        }
                        else 
                        Console.WriteLine("Book not found");
                }              
            }
                else if (milih == 4)
                {

                    while (true)
                    {
                        Console.WriteLine("Remove from list by scroll name? (Y/N): ");
                        var remove = Console.ReadLine();
                    
                        if (remove == "Y" || remove == "y")
                        {
                            Console.WriteLine("Input scroll name :");
                            var inputScroll = Console.ReadLine();

                            if (scrolls.Contains(inputScroll))
                            {
                                scrolls.Remove(inputScroll);
                                Console.WriteLine("Book Removed!");
                                Console.WriteLine("");
                                foreach (var scroll in scrolls)
                                {
                                    Console.WriteLine(scroll);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Book not found");

                                Console.WriteLine("Remove from list by scroll name? (Y/N): ");
                                var remove1 = Console.ReadLine();
                            }

                            break;
                        }
                        else if (remove == "N" || remove == "n")

                        {

                            int x = 0;
                            while (x == 0)
                            {
                                Console.WriteLine("Input scroll queue :");
                                var queue = int.Parse(Console.ReadLine());
                                queue--;
                                for (int i = 0; i < scrolls.Count; i++)
                                {
                                    if (i == queue)
                                    {
                                        scrolls.RemoveAt(i);
                                        Console.WriteLine("Book Removed!");
                                        x = 1;
                                        break;
                                    }

                                }
                                if (queue > scrolls.Count)
                                {
                                    Console.WriteLine("Queue not found");

                                }
                            }
                            break;
                        }
                    }
                }



                






            }
            
        }
        

    }

