using System;
using System.Windows.Input;

namespace IdentifiableObject
{
    public class Tests
    {
        string player_name, player_desc;
        Player player;
        Bag player_bag;
        Locations guild;
        Locations shop;
        Path guild_to_shop;
        Path shop_to_guild;
        Command _command;
        [SetUp]
        public void Setup()
        {
            
            player_bag = new Bag(new string[] { "bag" }, "Thang's bag", "bag number 104776473");
            _command = new CommandHandler();
            guild = new Locations("Guild", "This is the city's guild");

            shop = new Locations("equipment shop", "place to sell tools");
            guild_to_shop = new Path(new string[] { "south" }, "Guild's Door", "Cross through the door", guild, shop);
            shop_to_guild = new Path(new string[] { "north" }, "Shop's Door", "Cross through the door", shop, guild);
            guild.AddPath(guild_to_shop);
            shop.AddPath(shop_to_guild);
            _command = new CommandHandler();
            player = new Player("thang", "104776473");
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

            Bag b2 = new Bag(new string[] { "b2" }, "bag2", "bag number 2");
            player_bag.Inventory.Put(b2);

        }

        [Test]
        public void TestPath()
        {
            Assert.AreEqual(guild_to_shop.FullDescription, "Guild's Door");
        }

        [Test]
        public void TestMoveCommand()
        {
            Assert.AreEqual(_command.Execute(player, new string[] { "move", "south" }), "You go south\nWent through the Guild's Door\nArrived to the equipment shop");
        }

        [Test]
        public void TestLookCommand()
        {
            Assert.AreEqual(_command.Execute(player, new string[] { "look", "at", "shield" }), "Shield level 1");
        }
    }
}