Random rand = new Random();
//int N = int.Parse(Console.ReadLine());
int N = 10;
int[] Array = new int[N];

for (int i = 0; i<Array.Length; i++)
{
    Array[i] = rand.Next(1, 6);
}

int[] newArray = new int[Array.Length];
for (int i = 0; i<Array.Length; i++)
{
     Console.Write(Array[i] + " ");
}
Console.WriteLine();

int counter = 0;
for (int i = 0; i<Array.Length; i++)
{
   if (!Exists(Array[i], newArray))
   {
     newArray[i] = Array[counter];
     counter += 1;
   }
}


for (int i = 0; i<newArray.Length; i++)
{
     Console.Write(newArray[i] + " ");
}


bool Exists(int value, int[] array)
{
    for (int i = 0; i<array.Length; i++)
    {
        if(array[i] == value)
        {
           return true;
        }
    }
    return false;
}