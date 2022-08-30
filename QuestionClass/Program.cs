
public static class QuestionClass
{
    static void Main()
    {
        Names();

    }
    static List<string> NamesList = new List<string>()
 {
 "Jimmy",
 "Jeffrey",
 "John",
 };

    public static void Names()
    {
        string names = string.Join(", ", NamesList);
        Console.WriteLine(names);
    }

}




//Iterate through namesList with   public static void Names()

//this does Write out the names when i used a different console app cant get to pop up terminal because of error with main program 
