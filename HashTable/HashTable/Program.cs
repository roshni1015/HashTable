// See https://aka.ms/new-console-template for more information
using HashTable;

Console.WriteLine("Welcome to HashTable Operation!");
while (true)
{
    Console.WriteLine("Please choose the option :\n1)Finding Frequency \n2)Finding Frequency of Words in a Large Paragraph \n3)Remove avoidable word");
    int option = Convert.ToInt16(Console.ReadLine());
    switch (option)
    {
        case 1:
            HashTable<string, int> hash = new HashTable<string, int>(5);
            string Words = "To be or not to be";
            string[] array = Words.Split(' ');
            LinkedList<string> checkForDuplicationS = new LinkedList<string>();
            foreach (string element in array)
            {
                int count = 0;
                foreach (string match in array)
                {
                    if (element == match)
                    {
                        count++;
                        if (checkForDuplicationS.Contains(element))
                        {
                            break;
                        }
                    }
                }
                if (!checkForDuplicationS.Contains(element))
                {
                    checkForDuplicationS.AddLast(element);
                    hash.Add(element, count);
                }
            }
            hash.Display();
            break;
        case 2:
            HashTable<string, int> hash2 = new HashTable<string, int>(5);
            string Words2 = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] array2 = Words2.Split(' ');
            LinkedList<string> checkForDuplication2 = new LinkedList<string>();
            foreach (string element in array2)
            {
                int count = 0;
                foreach (string match in array2)
                {
                    if (element == match)
                    {
                        count++;
                        if (checkForDuplication2.Contains(element))
                        {
                            break;
                        }
                    }
                }
                if (!checkForDuplication2.Contains(element))
                {
                    checkForDuplication2.AddLast(element);
                    hash2.Add(element, count);
                }
            }
            hash2.Display();
            break;
        case 3:
            HashTable<string, int> hash3 = new HashTable<string, int>(5);
            string Words3 = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] array3 = Words3.Split(' ');
            LinkedList<string> checkForDuplication3 = new LinkedList<string>();
            foreach (string element in array3)
            {
                int count = 0;
                foreach (string match in array3)
                {
                    if (element == match)
                    {
                        count++;
                        if (checkForDuplication3.Contains(element))
                        {
                            break;
                        }
                    }
                }
                if (!checkForDuplication3.Contains(element))
                {
                    checkForDuplication3.AddLast(element);
                    hash3.Add(element, count);
                }
            }
            hash3.Display();
            Console.WriteLine("**************************\nPlease enter the word u want to remove :");
            string WordToRemove = Console.ReadLine();
            hash3.Remove(WordToRemove);
            hash3.Display();
            break;
        default:
            Console.WriteLine("Please choose the correct option!");
            break;
    }
}
