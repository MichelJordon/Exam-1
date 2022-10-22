int n,max;
n = Convert.ToInt32(Console.ReadLine());

var a = new int[n];

for(int i=0; i<a.Length; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
}
for ( int i=0; i<a.Length-1; i+=2 ){
    if ( a[i] < a[i + 1] ){
        int req = a[i];
        a[i] = a[i + 1];
        a[i + 1] = req;
    }
}
foreach (var item in a)
{
    System.Console.Write($"{item} ");
}