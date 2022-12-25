namespace StackOverFlowPost
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter The Title of Your post:");
            string Title1 = Console.ReadLine();
            Console.Write("Descripe Your Topic: ");
            string Description1 = Console.ReadLine();

            Post post = new Post(Title1, Description1);
            post.VotesUp();
            post.VotesUp();
            post.VotesUp();
            post.VotesUp();
            post.VotesDown();
            post.VotesDown();
     

            Console.Write("Enter The Title of Your post:");
            string Title2 = Console.ReadLine();
            Console.Write("Descripe Your Topic: ");
            string Description2 = Console.ReadLine();

            Post post2 = new Post(Title2, Description2);
            post2.VotesUp();
            post2.VotesUp();
            post2.VotesUp();
            post2.VotesDown();

            Console.WriteLine();
            Console.WriteLine("Post 1: ");
            Console.WriteLine(post.ShowPost());
            Console.WriteLine();
            Console.WriteLine("Post 2: ");
            Console.WriteLine(post2.ShowPost());
            Console.WriteLine();


        }
    }
}