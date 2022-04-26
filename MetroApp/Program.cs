using MetroApp;

Console.WriteLine("Pražské metro");

List<string> linkaA = new List<string>
{ "Nemocnice Motol", "Petřiny", "Nádraží Veleslavín", "Bořislavka", "Dejvická", "Hradčanská",
    "Malostranská", "Staroměstská", "Muzeum", "Můstek", "Náměstí Míru", "Jiřího z Poděbrad",
    "Flora", "Želivského", "STRAŠNICKÁ", "Skalka", "Depo Hostivař"
};

LinkaMetra linkaMetroA = new LinkaMetra(linkaA);
linkaMetroA.VypisPrvni();
Console.WriteLine("----------");

linkaMetroA.VypisStanice();
Console.WriteLine("----------");

int cas = linkaMetroA.ZjistiCas("Nemocnice Motol", "Muzeum");
Console.WriteLine(cas);
