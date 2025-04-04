
namespace IdentifiableObject
{
    public class Tests
    {
        private Item _shield;
        private Item _shovel;

        [SetUp]
        public void Setup()
        {
            _shield = new Item(new string[] { "shield" }, "a shield", "Shield level 1");
            _shovel = new Item(new string[] { "shovel" }, "a shovel", "Shovel level 2");
        }

        [Test]
        public void TestItemIdentifiable()
        {
            Assert.IsTrue(_shield.AreYou("shield"));
        }

        [Test]
        public void TestShortDescription()
        {
            Assert.AreEqual(_shield.ShortDescription, "a shield (shield)");
        }

        [Test]
        public void TestFullDescription()
        {
            Assert.AreEqual(_shovel.FullDescription, "Shovel level 2");
        }

        [Test]
        public void TestPrivilegeEscalarion()
        {
            _shield.PrivilegeEscalation("6473");
            Assert.AreEqual(_shield.FirstId, "6473");
        }
    }
}