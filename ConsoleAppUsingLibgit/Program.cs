using System;
using System.Linq;
using LibGit2Sharp;

namespace ConsoleAppUsingLibgit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This app uses LibGit2Sharp");
            try
            {
                using (var repo = new Repository("./"))
                {
                    var latestCommit = repo.Commits.First();
                    Console.WriteLine($"Latest commit: {latestCommit.Message}");
                }
            }
            catch (LibGit2Sharp.RepositoryNotFoundException)
            {
                Console.WriteLine("Oops, this is not a git repo.");
            }

        }
    }
}
