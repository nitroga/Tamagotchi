public class Tamagotchi
{
    int tick = 0;
    Random rnd = new Random();
    int hunger = 0;
    int boredom = 0;
    bool isAlive = true;
    List<String> words = new List<string>() {"Hi", "Hello"};
    public string name;
    public void Feed() {
        Console.WriteLine($"{name} eats and becomes less hungry");
        hunger -= 2;
        if (hunger < 0) {
            hunger = 0;
    
        }    
    }
    public void Hi() {
        int num = rnd.Next(words.Count);
        Console.WriteLine($"{name} says: {words[num]}");
        ReduceBoredom();
    }
    public void Teach(string word) {
        Console.WriteLine($"{name} learns {word}");
        words.Add(word);
        ReduceBoredom();
    }
    public void Tick() {
        hunger++;
        boredom++;
        tick++;
        if (hunger > 10 || boredom > 10) {
            isAlive = false;
        }
    }
    public void PrintStats() {
        Console.WriteLine($"Day {tick}");
        Console.WriteLine($"Tamagotchi Stats\nHunger: {hunger}/10\nBoredom: {boredom}/10\n");
    }
    public bool GetAlive() {
        return isAlive;
    }
    void ReduceBoredom() {
        boredom -= 2;
        if (boredom < 0) {
            boredom = 0;
        }        
    }
}
