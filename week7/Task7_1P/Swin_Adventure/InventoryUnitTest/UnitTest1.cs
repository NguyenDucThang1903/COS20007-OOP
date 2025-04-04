
namespace IdentifiableObject
{
    public class Tests
    { 
        private Item _shield;
        private Item _shovel;
        private Inventory _my_invent;

        [SetUp]
        public void Setup()
        {
            _shield = new Item(new string[] { "shield" }, "a shield", "Shield level 1");
            _shovel = new Item(new string[] { "shovel" }, "a shovel", "Shovel level 2");
            _my_invent = new Inventory();
        }

        [Test]
        public void TestFindItem()
        {
            _my_invent.Put(_shield);
            Assert.IsTrue(_my_invent.HasItem(_shield.FirstId));
        }

        [Test]
        public void TestNoItemFind()
        {
            Assert.IsFalse(_my_invent.HasItem(_shield.FirstId));
        }

        [Test]
        public void TestFetchItem()
        {
            _my_invent.Put(_shovel);
            Item fetch_item = _my_invent.Fetch(_shovel.FirstId);

            Assert.AreEqual(fetch_item, _shovel);
            Assert.IsTrue(_my_invent.HasItem(_shovel.FirstId));
        }

        [Test]
        public void TestTakeItem()
        {
            _my_invent.Put(_shovel);
            _my_invent.Take(_shovel.FirstId);

            Assert.IsFalse(_my_invent.HasItem(_shovel.FirstId));
        }

        [Test]
        public void TestItemList()
        {
            _my_invent.Put(_shield);
            _my_invent.Put(_shovel);

            Assert.AreEqual(_my_invent.ItemList, "a shield (shield)\n" + "a shovel (shovel)\n");
        }
    }
}