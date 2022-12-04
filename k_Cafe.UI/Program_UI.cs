using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



public class Program_UI
{
    private readonly MenuItem_Repository _mRepo = new MenuItem_Repository();

    public void Run()
    {
        RunApplication();
    }
    void RunApplication()
    {
        bool isRunnning = true;
        while(isRunnning==true)
        {
            Console.Clear();
            System.Console.WriteLine("welcome to Komodo Cafe\n"+
            "1. Add Menu Item\n"+
            "2. View All Menu Items\n"+
            "3. View Menu Item By Id\n"+
            "4. Update Menu Item\n"+
            "5. Delete Menu Item\n"+
            "0. Close Application\n");
            string userInput = Console.ReadLine();
        }
    }

}
