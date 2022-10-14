Console.Write("write username: ");
string username = Console.ReadLine();

if(username.ToLower() == "maria")
{
    Console.WriteLine("Yup! It's Maria! WooHoo");
}
else
{
    Console.Write("Hello! ");
    Console.WriteLine(username);
}