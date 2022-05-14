// See https://aka.ms/new-console-template for more information
using HashTable;

while (true)
{
    Console.WriteLine("Please choose the option :\n1)Finding Frequency \n2)Finding Frequency of Words in a Large Paragraph");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            HashTable<string, int> hashTable = new(6);
            hashTable.Insert("To", 1);
            hashTable.Insert("be", 2);
            hashTable.Insert("or", 3);
            hashTable.Insert("not", 4);
            hashTable.Insert("to", 5);
            hashTable.Insert("be", 6);
            Console.WriteLine("Value of key 'not' is: " + hashTable.GetValue("not"));
            break;
        case 2:
            string GivenPara = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] WordsInArray = GivenPara.Split(" ");
            int tableSize = WordsInArray.Length;
            HashTable<int, string> hashTable1 = new(tableSize);
            int Index = 0;
            foreach (string words in WordsInArray)
            {
                hashTable1.Insert(Index, words);
                Index++;
            }
            for (Index = 0; Index < tableSize; Index++)
            {
                string word = hashTable1.GetValue(Index);
                Console.WriteLine(word + "-->" + Index);

            }
            break;
        default:
            Console.WriteLine("Please choose the correct option!");
            break;

    }
}
