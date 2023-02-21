int degree(int X,int  n)
{
if (n<0) 
    {
    Console.WriteLine("Степерь не может быть отрицательной");
    return 0;
    }
int i = 0;
int Y =1;
for(; i<n; i++) Y=Y*X;
return Y;
}

Console.Clear();
Console.WriteLine("Введите число и ее степерь");
int X =  int.Parse(Console.ReadLine());
int n =  int.Parse(Console.ReadLine());
Console.WriteLine(degree(X, n));
