
int[] arry(int size)
{
    int[] arr = new int[size];
    for(int i=0; i<size; i++) arr[i]=new Random().Next(10, 51);
    return arr;
}



Console.Clear();
Console.WriteLine("Введите разрядность массива");
int size = int.Parse(Console.ReadLine());
int [] mass=arry(size);
Console.WriteLine($"[ {string.Join(" ", mass)} ]");
