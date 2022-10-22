public class Justnames{
    public string title;
    public string description;
    public DateTime DateTime;
    public List<string> comments;
    public bool isPublished;
    public int like; 
    public Justnames()
    {
        comments = new List<string>();
    }
    public void PostPublished(){
        System.Console.WriteLine("The Post is Published!");
        DateTime = DateTime.Now;
        isPublished = true;
    }
    public void Comment( string fullname ){
        comments.Add( fullname );
    }
}