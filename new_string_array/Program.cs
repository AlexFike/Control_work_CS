int MaxCountCharInArray(string[] array, int maxCountChar)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item.Length <= maxCountChar) count++;
    }
    return count;
}

string[] CreateNewArrayOfElementSpecLength(string[] array, int maxCountChar)
{
    int sizeNewArray = MaxCountCharInArray(array, maxCountChar);

    string[] newArray = new string[sizeNewArray];

    if (sizeNewArray > 0)
    {
        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (array[i].Length <= maxCountChar)
            {
                newArray[j] = array[i];
                j++;
            }
        }
    }

    return newArray;
}


// string[] testArray = { "hello", "2", "world", ":-)" };

// string[] testArray2 = CreateNewArrayOfElementSpecLength(testArray, 3);

// Console.WriteLine(String.Join(" ", testArray2));