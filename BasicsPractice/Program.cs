using CRUX.Indexers;

//Custom indexers
//Indexers are used to find an element based on the index
namespace CRUX.Indexers
{
    class Sentence
    {
        string words;

        public Sentence(string s)
        {

            this.words = s;

        }

        public string this[int index,string str]
        {
            get { return words[index]+str; }
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Sentence s = new Sentence("Ramya sri");
        Console.WriteLine(s[0,"Sanaboina"]);
        Console.ReadLine();
    }
}