using System;

class Book
{
    public string Title;
    public int Pages;
}

class Program
{
    static void Main()
    {
        #region q1 q2
        Book b = new Book();
        b.Title = "idk";
        b.Pages = 100;

        object o = b;
        Console.WriteLine(o);
        Console.WriteLine(b.ToString());
        Console.WriteLine(b.Equals(b));
        Console.WriteLine(b.GetHashCode());
        Console.WriteLine(b.GetType());
        #endregion

        #region q3 q4
        // q3: compile error bc "464" is a string
        int pages = int.Parse("464");

        // q4
        int z = 0;
        try
        {
            int a = 10 / z;
        }
        catch
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("Done");
        }
        #endregion

        #region q5 q6
        int p = 300;
        double d = p;

        double price = 49.99;
        int x = (int)price;
        #endregion

        #region q7 q8 q9
        string pagesText = "464";
        int p2 = Convert.ToInt32(pagesText);

        string yearText = "2023";
        int y = int.Parse(yearText);

        string badText = "abc";
        if (!int.TryParse(badText, out int n))
        {
            Console.WriteLine("Invalid number");
        }

        int p3 = 464;
        string s = p3.ToString();
        Console.WriteLine(s.GetType());
        #endregion

        #region q10
        int copies = 100;
        object box = copies;
        int unbox = (int)box;
        Console.WriteLine(box);
        Console.WriteLine(unbox);
        #endregion
    }
}