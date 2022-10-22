int N, cmd = 0;
N = Convert.ToInt32(Console.ReadLine());
var a = new int[N + 1];
for ( int i=0; i<a.Length - 1; i++ ){
    a[i] = Convert.ToInt32(Console.ReadLine());
}
for ( int i=0; i<a.Length-1; i++ ){
    if ( a[i] != a[i + 1] ){
        cmd ++;
    }
}
System.Console.WriteLine(cmd);