Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Yellow;
string koval = "";
string Dödadraken = "";
string Dödaträsk = "";


Console.WriteLine("Skriv start för att börja spelet");
string start = Console.ReadLine();

if (start == "Start" || start == "start")
{
    System.Console.WriteLine(@"Du vandrar genom en mörk skog i narnia och kommer plötsligt till en korsning, du kan antingen välja mellan att gå till draknästet eller att gå till den förtrollade dungen.
Vilken väg ska du ta?");

    koval = Console.ReadLine();

    if (koval == "draknästet" || koval == "Draknästet")
    {
        System.Console.WriteLine("Du väljer att gå mot draknästet för att dräpa draken och sälja dess ägg");

        System.Console.WriteLine(@"Du går fram till draken och funderar på hur du ska slå mitt svärdet.
Ska du gå för halsen eller ögonen?");

        Dödadraken = Console.ReadLine();


    }
    else if (koval == "Den förtrollade dungen" || koval == "den förtrollade dungen")
    {
        System.Console.WriteLine("Du väljer att gå vidare till den förtrollade dungen för att dräpa träskmonstret och ta dess hjärta");

          System.Console.WriteLine("Du går fram till tränskmonstret i dungen redo för att strida. Ska du gå för hjärtat direkt eller för armen?");

          Dödaträsk = Console.ReadLine();

    }
}







if (Dödadraken == "halsen" | Dödadraken == "Halsen")
{
    System.Console.WriteLine("Du skär upp drakens hals och syra rinner ut. Du dör");
    System.Console.WriteLine("Sad");
}
else if (Dödadraken == "Ögonen" || Dödadraken == "ögonen")
{
    System.Console.WriteLine("Du dödar draken genom att trycka in ditt svärd i dess öga. Du går därifrån levande med äggen i handen");
    System.Console.WriteLine("Happy");
}


if (Dödaträsk == "hjärtat" || Dödaträsk == "hjärtat")
{
    System.Console.WriteLine("du hugger för hjärtat och träffar det precis så att besten dör. Du går iväg från träsket levande och med hjärtat");
    System.Console.WriteLine("Happy");
}
else if (Dödaträsk == "armen" || Dödaträsk == "Armen")
{
    System.Console.WriteLine("Du skär av monstrets arm men det skär av ditt huvud med den andra, Du dör. ");
    System.Console.WriteLine("Sad");
}
Dödaträsk = Console.ReadLine();

