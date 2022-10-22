var justnames = new Justnames();
var list = new List<Justnames>();
for ( int i=0; i<3; i++ ){
    System.Console.WriteLine($"Person {i + 1}: ");
    System.Console.Write("Name: ");
    string name = Console.ReadLine();
    System.Console.Write("Surname: ");
    string surname = Console.ReadLine();
    System.Console.Write("Age: ");
    string inComments = Console.ReadLine();
    justnames.Comment( $"{name} {surname}");
    list.Add(justnames);
}
foreach (var item in list)
{
    foreach (var item1 in item.comments)
    {
        System.Console.Write("Hello! My name is ");
        System.Console.WriteLine(item1);
    }
    return;
}