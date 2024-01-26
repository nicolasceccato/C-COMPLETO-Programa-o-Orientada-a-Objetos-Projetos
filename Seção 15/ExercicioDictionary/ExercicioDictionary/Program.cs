using System;

namespace ExercicioDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file full path:");
            string path = Console.ReadLine();

            Dictionary<string, int> votes = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(",");
                        string candidate = line[0];
                        int quantityOfVotes = Convert.ToInt32(line[1]);

                        if (votes.ContainsKey(candidate))
                        {
                            votes[candidate] += quantityOfVotes;
                        }
                        else
                        {
                            votes[candidate] = quantityOfVotes;
                        }
                    }
                }

                foreach (KeyValuePair<string, int> vote in votes)
                {
                    Console.WriteLine(vote.Key + ": " + vote.Value);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}