int n;
double cmd = 0;
n = Convert.ToInt32(Console.ReadLine());

var a = new int[n];

for(int i=0; i<a.Length; i++)
{
    cmd += Math.Pow( 2, i );
}

System.Console.WriteLine(cmd);
