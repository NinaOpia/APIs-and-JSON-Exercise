namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;

            do
            {
                RonVSKanyeAPI.KanyeQuote();
                RonVSKanyeAPI.RonQuote();

                Console.WriteLine("Continue? Y or N?");
                var response = Console.ReadLine().ToLower();

                cont = (response == "n") ? false : true;

            } while (cont);
        }
    }
}
