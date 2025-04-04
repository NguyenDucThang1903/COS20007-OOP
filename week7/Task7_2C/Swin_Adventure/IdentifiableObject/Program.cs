using IdentifiableObject;
using System;

class Program
{
    static void Main(string[] args)
    {
        string player_name, player_desc;
        Player player;
        Bag player_bag=new Bag(new string[]{"bag"}, "Thang's bag", "bag number 104776473");
        Command command = new LookCommand();
        Locations guild = new Locations("Guild", "This is the city's guild");

        Console.Write("Please enter your name: ");
        player_name = Console.ReadLine();
        Console.Write("Please enter your description: ");
        player_desc = Console.ReadLine();

        player = new Player(player_name, player_desc);

        Item shield = new Item(new string[] { "shield" }, "a shield", "Shield level 1");
        Item shovel = new Item(new string[] { "shovel" }, "a shovel", "Shovel level 2");

        player.Inventory.Put(shield);
        player.Inventory.Put(shovel);

        player.Inventory.Put(player_bag);

        Item blanket = new Item(new string[] { "blanket" }, "a blanket", "winter blanket");
        player_bag.Inventory.Put(blanket);

        player.Location = guild;

        Item sword = new Item(new string[] { "sword" }, "a sword", "Sword level 10");
        Item staff = new Item(new string[] { "staff" }, "a staff", "Staff level 20");
        guild.ItemInLocation.Put(sword);
        guild.ItemInLocation.Put(staff);

        Bag b2= new Bag(new string[]{ "b2"}, "bag2", "bag number 2");
        player_bag.Inventory.Put(b2);
        while (true)
        {
            Console.Write("Orders: ");
            string user_input = Console.ReadLine();

            Console.WriteLine(command.Execute(player, user_input.Split()));

        }
    }
}