using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            char DNA = 'Y';
            while(DNA == 'Y')
            {
                string Letters = Console.ReadLine();
                bool Rep = true;
                Rep = IsValidSequence(Letters);

                if (Rep == true)
                {
                    Console.WriteLine("Current half DNA sequence : " + Letters);
                    char Y_N = 'Y';
                    Y_N = Confirm(Y_N);

                    while (Y_N != 'Y' && Y_N != 'N')
                    {
                        while (Y_N != 'Y' && Y_N != 'N')
                        {
                            Console.WriteLine("Please input Y or N.");
                            Y_N = Confirm(Y_N);
                        }
                        if (Y_N == 'Y')
                        {
                            string Rep2;
                            Rep2 = ReplicateSeqeunce(Letters);
                            Console.WriteLine("Replicated half DNA sequence : " + Rep2);
                            Y_N = 'Y';
                            Y_N = Confirm(Y_N);
                        }
                        if(Y_N == 'N')
                        {
                            Y_N = 'N';
                        }
                    }
                    if (Y_N == 'Y')
                    {
                        string Rep2;
                        Rep2 = ReplicateSeqeunce(Letters);
                        Console.WriteLine("Replicated half DNA sequence : " + Rep2);
                    }
                }
                if (Rep == false)
                {
                    Console.WriteLine("That half DNA sequence is invalid.");
                }
                char DNA2 = 'Y';
                DNA2 = Confirm2(DNA2);

                while (DNA2 != 'Y' && DNA2 != 'N')
                {
                    Console.WriteLine("Please input Y or N.");
                    DNA2 = Confirm2(DNA2);
                }
                if (DNA2 == 'N')
                {
                    DNA = 'N';
                }
            } while (DNA == 'Y');
        }
        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }
        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }
        static char Confirm(char Y_N)
        {
            Console.WriteLine("Do you want to replicate it ? (Y/N) :");
            char Y_NDNA = char.Parse(Console.ReadLine());
            return Y_NDNA;
        }
        static char Confirm2(char DNA2)
        {
            Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
            char DNA2_ = char.Parse(Console.ReadLine());
            return DNA2_;
        }
    }
}
