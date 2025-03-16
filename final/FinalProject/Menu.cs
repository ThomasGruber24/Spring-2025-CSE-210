public class Menu
{
    public void entry()
    {
        Console.WriteLine("Please Select what you would like to do");
        Console.WriteLine("Menu:");
        int userSelected = int.Parse(Console.ReadLine());
        if (userSelected == 1)
        {   
            string activity = "";
            selection(activity);
        }
    }
    protected static void selection(activity)
    {
        Console.WriteLine($"Thank you for selecting {activity}, now launching");
        
    }
}