int n,min;
n = Convert.ToInt32(Console.ReadLine());

var a = new int[n];

for(int i=0; i<a.Length; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
}
min=a[0];
for(int i=0; i<a.Length; i++)
{
     if(a[i]<min) min=a[i];
}
bool tools = false;
for ( int i=0; i<a.Length; i ++ ){
    if ( min == a[i] ){
        if ( tools == false ){
            System.Console.Write($"{min} ");
            tools = true;
        }
        for ( int j=i+1; j<a.Length; j++ ){
            if ( min < a[j] ){
                min = a[j];
                System.Console.Write($"{min} ");
            }
            else{
                return;
            }
        }
    }
}
