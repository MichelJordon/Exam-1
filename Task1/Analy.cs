public class Analy
{
    public int FindMinimum(int a, int b, int c, int d){
        int minn = a;
        if ( minn > b ){
            minn = b;
        }
        if ( minn > c ){
            minn = c;
        }
        if ( minn > d ){
            minn = d;
        }
        return minn;
    }
}