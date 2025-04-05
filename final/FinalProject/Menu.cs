public class Menu
{
    // This console program is to help modivate with ADHD. 
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
    protected static void selection(string activity)
    {
        Console.WriteLine($"Thank you for selecting {activity}, now launching");
        
    }
}