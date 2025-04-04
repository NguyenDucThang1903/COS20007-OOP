namespace IdentifiableObject
{
    public class Tests
    {
        private Player _player;
        private Item _wand;
        private Item _scaff;
        private Locations _store;
        private Command _command;

        [SetUp]
        public void Setup()
        {
            _player = new Player("Thang", "104776473");
            _wand = new Item(new string[] { "wand" }, "a wand", "wand level 5");
            _scaff = new Item(new string[] { "scaff" }, "a scaff", "a blue scaff");
            _store = new Locations("store", "This is an item store");
            _command = new LookCommand();

        }

        [Test]
        public void TestLocationCanLocateItself()
        {
            Assert.IsTrue(_store.AreYou("location"));
        }

        [Test]
        public void TestLocationHaveItems()
        {
            _store.ItemInLocation.Put(_wand);
            _store.ItemInLocation.Put(_scaff);

            Assert.AreEqual(_wand, _store.Locate("wand"));
        }

        [Test]
        public void TestPlayerHaveLocation()
        {
            Assert.AreEqual(_player.Locate("location"), _player.Location);
        }

        [Test]
        public void TestLocationFullDescription()
        {
            _player.Location = _store;
            _store.ItemInLocation.Put(_wand);
            _store.ItemInLocation.Put(_scaff);
            Assert.AreEqual(_command.Execute(_player, new string[] {"look", "at", "location"}), $"{_store.FullDescription}");
        }
    }
}