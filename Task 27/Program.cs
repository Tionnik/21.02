int sum(int X)
{
int S=0;
if (X<0) X=-1*X;
while (X>0)
{
    S=S+X%10;   
    X=X/10;
}
return S;
}


Console.Clear();
Console.WriteLine("Введите число");
int X =  int.Parse(Console.ReadLine());
Console.WriteLine(sum(X));