Console.Write("ededi daxil edin:");
string b = Console.ReadLine();
int a = int.Parse(b);
int counter = 0;
int cem = 0;
for (int i = 1; i <= a; i++)
{
    for(int j=1; j <= i; j++)
    {
        if (i % j == 0)
            counter++;
        
    }
    if (counter <= 2)
        cem = cem + i;
}
Console.WriteLine(cem);