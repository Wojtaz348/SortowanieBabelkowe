Console.WriteLine("Podaj długość tablicy");
int dlugosc = Convert.ToInt32(Console.ReadLine());

//sortowanie

int[] array = new int[dlugosc];
Random randow = new Random(); 


for (int i=0; i <dlugosc; i++)
{
    array[i] = randow.Next();
    Console.WriteLine(array[i]);
}

int temp;

for (int i = 0; i < dlugosc; i++) 
{
    for (int j = 1; j < dlugosc - i; j++) 
    {
        if (array[j - 1] == array[i])
        {
            temp = array[j - 1];
            array[j - 1] = array[i];
            array[j] = temp;
        }
    }
}
Console.WriteLine("\nPosortowana tablica");
for (int i = 0;i < dlugosc; i++)
{
    Console.WriteLine(array[i] + " ");
}