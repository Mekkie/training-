namespace _00_Hello
{
    public class Functions
    {
        public static string Hello(string Fred)
        {
            if (Fred == "") return "Hello";
            return "Hello" + ", " + Fred;
        }
    }
}