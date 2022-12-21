string [] array = {"hello","2","world",":-)"};

int n = array.Length;
int L = 0;

for(int i =0;i<n;i++)
{
    if(array[i].Length <= 3)
    {
        L++;
    }
}

string [] newArray = new string[L];
L = 0;

for(int j =0;j<n;j++)
{
    if(array[j].Length <= 3)
    {
        newArray[L] = array[j];
        L++;
    }
}

PrintArray(newArray);



void PrintArray(string[] array){
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write("]");
}