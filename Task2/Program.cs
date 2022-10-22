int n;
n = Convert.ToInt32(Console.ReadLine());

var a = new string[n];

for(int i=0; i<a.Length; i++)
{
    a[i] = Console.ReadLine();
}
foreach (var item in a)
{
    System.Console.Write($"Name: ");
    System.Console.WriteLine(item);
}