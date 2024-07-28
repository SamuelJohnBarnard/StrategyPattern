namespace StrategyPatternAnimalsCorrect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BlueWhale newBlueWhale = new BlueWhale();
            Console.WriteLine(newBlueWhale.Fly());
            Console.WriteLine(newBlueWhale.Walk());
            Console.WriteLine(newBlueWhale.Swim());
            newBlueWhale.Display();

            WanderingAlbatross newWanderingAlbatross = new WanderingAlbatross();
            Console.WriteLine(newWanderingAlbatross.Fly());
            Console.WriteLine(newWanderingAlbatross.Swim());
            Console.WriteLine(newWanderingAlbatross.Walk());
            newWanderingAlbatross.Display();

            EmperorPenguin newEmperorPenguin = new EmperorPenguin();
            Console.WriteLine(newEmperorPenguin.Fly());
            Console.WriteLine(newEmperorPenguin.Swim());
            Console.WriteLine(newEmperorPenguin.Walk());
            newEmperorPenguin.Display();
        }
    }
}