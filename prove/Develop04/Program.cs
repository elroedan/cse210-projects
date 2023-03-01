using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Menu _menu = new Menu();
        int _choice = -1;
        
        while (_choice!=4) 
        {
        _choice = _menu.DisplayMenu();
        Console.Clear();
        
        Breathing breathingActivity = new Breathing();
        Reflecting reflectingActivity = new Reflecting();
        Listing listingActivity = new Listing();
        switch(_choice) {
            case 1:
                breathingActivity.StartBreathingActivity();
                Console.Clear();
                
                break;

            case 2:
                reflectingActivity.StartReflectingActivity();
                Console.Clear();
                break;

            case 3:
                listingActivity.StartListingActivity();
                Console.Clear();
                break;
        }
        }
    }
}