Console.WriteLine("Enter a number:");
int inputnum = int.Parse(Console.ReadLine());
for (int i =2;i<=inputnum;i++)
{
    int count=0;
    for (int j=2;j<i;j++)
    {
        if (i%j==0)
        {
           count =count+1;
            break;
        }
    }
    if (count==0)
    {
        Console.WriteLine(i);
    }
}