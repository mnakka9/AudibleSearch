namespace AudibleSearch.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var SearchAudible = new AudibleSearch.SearchAudible();

            var book = SearchAudible.SearchAudiobookInAudible("Chrysalis (A Fantasy LitRPG): Beast Realms, Book 1", "jones");


            System.Console.Read();
        }
    }
}
