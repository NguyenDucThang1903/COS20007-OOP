
namespace IdentifiableObject
{
    public class Tests
    {
        private Item _shield;
        private Item _shovel;
        private Player _player;

        [SetUp]
        public void Setup()
        {
            _shield = new Item(new string[] { "shield" }, "a shield", "Shield level 1");
            _shovel = new Item(new string[] { "shovel" }, "a shovel", "Shovel level 2");
            _player = new Player("Duc Thang", "Student");
        }

        [Test]
        public void TestPlayerIdentifiable()
        {
            Assert.IsTrue(_player.AreYou("me") && _player.AreYou("inventory"));
        }

        [Test]
        public void TestPlayerLocateItem()
        {
            bool test = false;
            _player.Inventory.Put(_shield);
            var located_itm = _player.Locate("shield");
            if(located_itm == _shield)
            {
                test = true;
            }
            Assert.IsTrue(test);
        }

        [Test]
        public void TestPlayerLocateItself()
        {
            bool test = false;
            var myself = _player.Locate("me");
            var invent = _player.Locate("inventory");
            if (myself == _player || invent==_player)
            {
                test = true;
            }
            Assert.IsTrue(test);
        }

        [Test]
        public void TestPlayerLocateNothing()
        {
            Assert.IsNull(_player.Locate("shield"));
        }

        [Test]
        public void TestPlayerFullDescription()
        {
            _player.Inventory.Put(_shield);
            _player.Inventory.Put(_shovel);
            string output = "You are (Duc Thang), (Student). You are carrying:\n" + "a shield (shield)\n" + "a shovel (shovel)\n";
            Assert.AreEqual(_player.FullDescription, output);
        }
    }
}