namespace IdentifiableObject
{
    public class Tests
    {
        private Bag _b1;
        private Bag _b2;
        private Item _shield;
        private Item _shovel;

        [SetUp]
        public void Setup()
        {
            _b1 = new Bag(new string[] {"104776473"}, "Thang's bag", "student");
            _b2 = new Bag(new string[] {"1"}, "bag 2", "this is a bag");
            _shield = new Item(new string[] { "shield" }, "a shield", "Shield level 1");
            _shovel = new Item(new string[] { "shovel" }, "a shovel", "Shovel level 2");
        }

        [Test]
        public void TestBagLocatesItems()
        {
            _b1.Inventory.Put(_shield);
            Assert.AreEqual(_b1.Locate("shield"), _shield);
        }

        [Test]
        public void TestBagLocatesItself()
        {
            Assert.AreEqual(_b1.Locate("104776473"), _b1);
        }

        [Test]
        public void TestBagLocateNothing()
        {
            Assert.AreEqual(_b1.Locate("pizza"), null);
        }

        [Test]
        public void TestBagFullDescription()
        {
            _b1.Inventory.Put(_shield);
            _b1.Inventory.Put(_shovel);
            Assert.AreEqual(_b1.FullDescription, "In the Thang's bag you can see:\na shield (shield)\na shovel (shovel)\n");
        }

        [Test]
        public void TestBagInBag()
        {
            _b1.Inventory.Put(_b2);
            _b2.Inventory.Put(_shield);
            Assert.AreEqual(_b1.Locate(_b2.FirstId), _b2);
            Assert.AreEqual(_b1.Locate(_shovel.FirstId), null);
        }

        [Test]
        public void TestBagInBag_PrivilegedItem()
        {
            _b1.Inventory.Put(_b2);
            _b2.PrivilegeEscalation("2024");
            Assert.AreEqual(_b1.Locate("2024"), null);
        }
    }
}