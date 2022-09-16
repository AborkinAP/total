Console.Clear();
void ArrayLessFourElements(string[] array)
{
    int countChar = 3;
    int sizeArray = 0;
    string text = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        text = array[i];
        if (text.Length <= countChar)
        {
            sizeArray++;
        }
    }
    
    string[] stringArray = new string[sizeArray];
    int numElementArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        text = array[i];
        if (text.Length <= countChar)
        {
            stringArray[numElementArray] = array[i];
            numElementArray++;
        }
    }
    Console.WriteLine($"[{string.Join(", ", stringArray)}]");
}

string[] array1 = new string[4] { "Hello", "2", "world", ":-)" };
ArrayLessFourElements(array1);
string[] array2 = new string[] { "1234", "1567", "-2", "computer scince" };
ArrayLessFourElements(array2);
string[] array3 = new string[] { "Russia", "Denmark", "Kazan" };
ArrayLessFourElements(array3);
