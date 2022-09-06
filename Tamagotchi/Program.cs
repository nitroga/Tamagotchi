Tamagotchi t = new Tamagotchi();
Console.WriteLine("What would you like to call your tamagotchi?");
t.name = Console.ReadLine();
if (t.name == null) {
    t.name = "Nameless";
}
Console.Clear();
Console.WriteLine($"Welcome: {t.name}");
while (t.GetAlive() == true) {
    t.PrintStats();
    Console.WriteLine("What would you like to do?\nType the appropiate number\nOptions:");
    Console.WriteLine($"(1) Feed\n(2) Talk to {t.name}\n(3) Teach {t.name} new word\n(4) Do nothing");
    string action = Console.ReadLine();
    Console.Clear();
    t.Tick();
    if (action == "1") {
        t.Feed();
    }
    if (action == "2") {
        t.Hi();
    }
    if (action == "3") {
        Console.WriteLine("What word?");
        string word = Console.ReadLine();
        if (word == null) {
            word = "Hi";
        }
        t.Teach(word);
    }
}
