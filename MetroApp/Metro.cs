using MetroApp;

Console.WriteLine("Pražské metro");

List<string> linkaA = new List<string>
{ "Nemocnice Motol", "Petřiny", "Nádraží Veleslavín", "Bořislavka", "Dejvická", "Hradčanská",
    "Malostranská", "Staroměstská", "Muzeum", "Můstek", "Náměstí Míru", "Jiřího z Poděbrad",
    "Flora", "Želivského", "STRAŠNICKÁ", "Skalka", "Depo Hostivař"
};
List<string> linkaD = new List<string>
{ "Náměstí Míru", "Náměstí Bratří Synků","Pankrác","Olbrachtova",
  "Nádraží Krč","Nemocnice Krč","Nové Dvory","Libuš","Písnice","Depo Písnice"
};

Console.WriteLine("Chcete Linku D nebo A ?");
string linky = Console.ReadLine();
Console.Clear();

if (linky == "A")
{
    LinkaMetra linkaMetroA = new LinkaMetra(linkaA);
    linkaMetroA.VypisPrvni();
    linkaMetroA.VypisPosledni();
    Console.WriteLine("----------");

    linkaMetroA.VypisStanice();
    Console.WriteLine("----------");

    Console.WriteLine("Zadej název stanice odejzdu a poté název cíle stanice");
    string prvniStanice = Console.ReadLine();
    string druhaStanice = Console.ReadLine();
    int cas = linkaMetroA.ZjistiCas(prvniStanice, druhaStanice);
    Console.Clear();
    if (cas == 0)
    {
        Console.WriteLine("Chybně zadána stanice");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Cesta z {prvniStanice} do {druhaStanice} bude trvat {cas} minut lmao :D");
        Console.ResetColor();
    }
}
else if (linky == "D")
{
    LinkaMetraD linkaMetraD = new LinkaMetraD(linkaD);
    linkaMetraD.VypisPrvniD();
    linkaMetraD.VypisPosledni();
    Console.WriteLine("______");

    linkaMetraD.VypisStaniceD();
    Console.WriteLine("_______");

    Console.WriteLine("Zadej název stanice odejzdu a poté název cíle stanice");
    string prvniStaniceD = Console.ReadLine();
    string druhaStaniceD = Console.ReadLine();
    int cas2 = linkaMetraD.ZjistiCas1(prvniStaniceD, druhaStaniceD);
    Console.Clear();
    if (cas2 == 0)
    {
        Console.WriteLine("Chybně zadána stanice");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Cesta z {prvniStaniceD} do {druhaStaniceD} bude trvat {cas2} minut lmao :D");
        Console.ResetColor();
    }
}
else if(linky != "D" && linky != "A")
{
    Console.WriteLine("Taková stanice nefunguje");
}