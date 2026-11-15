string path = @"C:\Users\student\Documents\soooo sleepy rn.txt";

//Movies movies= new Movies(1, "KOG", "danna terrance", new DateTime(2026, 01, 26));

//Console.WriteLine(movies);


using (StreamWriter writer = new StreamWriter(path, append: false))
{
    writer.WriteLine("hello");

}

using (StreamReader reader = new StreamReader(path))
{

    string? Line;
    while ((Line = reader.ReadLine()) != null)
    {
        Console.WriteLine(Line);
    }


}
