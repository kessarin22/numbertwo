using System;

class Program
{
    static bool IsValidSequence(string sequence)
    {
        foreach (char basePair in sequence)
        {
            if (basePair != 'A' && basePair != 'T' && basePair != 'C' && basePair != 'G')
            {
                return false;
            }
        }
        return true;
    }

    static string ReplicateSequence(string sequence)
    {
        string replicatedSequence = "";
        foreach (char basePair in sequence)
        {
            if (basePair == 'A')
            {
                replicatedSequence += "T";
            }
            else if (basePair == 'T')
            {
                replicatedSequence += "A";
            }
            else if (basePair == 'C')
            {
                replicatedSequence += "G";
            }
            else if (basePair == 'G')
            {
                replicatedSequence += "C";
            }
        }
        return replicatedSequence;
    }

    static void Main()
    {
        bool continueProgram = true;
        while (continueProgram)
        {
            Console.Write("Enter half DNA sequence: ");
            string halfSequence = Console.ReadLine();

            if (IsValidSequence(halfSequence))
            {
                Console.WriteLine("Current half DNA sequence: " + halfSequence);
                Console.Write("Do you want to replicate it? (Y/N): ");
                string choice = Console.ReadLine();

                if (choice == "Y")
                {
                    string replicatedSequence = ReplicateSequence(halfSequence);
                    Console.WriteLine("Replicated half DNA sequence: " + replicatedSequence);
                }
                else if (choice != "N")
                {
                    Console.WriteLine("Please input Y or N.");
                    continue;
                }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }

            Console.Write("Do you want to process another sequence? (Y/N): ");
            string restartChoice = Console.ReadLine();

            if (restartChoice == "N")
            {
                continueProgram = false;
            }
            else if (restartChoice != "Y")
            {
                Console.WriteLine("Please input Y or N.");
            }
        }
    }
}

