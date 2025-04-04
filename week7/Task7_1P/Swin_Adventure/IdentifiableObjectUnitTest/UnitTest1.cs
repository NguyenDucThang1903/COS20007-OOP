
namespace IdentifiableObject
{
    public class Tests
    {
        private IdentifiableObject _id;
        private IdentifiableObject _id_blank;

        [SetUp]
        public void Setup()
        {
            _id = new IdentifiableObject(new string[] { "104776473", "Thang", "Nguyen" });
            _id_blank = new IdentifiableObject(new string[] {});
        }

        [Test]
        public void TestAreYou()
        {
            Assert.IsTrue(_id.AreYou("104776473"));
            Assert.IsTrue(_id.AreYou("Thang"));
            Assert.IsTrue(_id.AreYou("Nguyen"));
        }

        [Test]
        public void TestNotAreYou()
        {
            Assert.IsFalse(_id.AreYou("1O4776473"));
        }

        [Test]
        public void TestCaseSensitive()
        {
            Assert.IsTrue(_id.AreYou("THaNg"));
            Assert.IsTrue(_id.AreYou("nGUYEn"));
        }

        [Test]
        public void TestFirstID()
        {
            Assert.IsTrue(_id.FirstId=="104776473");
        }

        [Test]
        public void TestFirstIDWithNoIDs()
        {
            Assert.IsTrue(_id_blank.FirstId == "");
        }

        [Test]
        public void TestAddID()
        {
            _id.AddIdentifier("Shinab");
            _id.AddIdentifier("Faust");
            Assert.IsTrue(_id.AreYou("Shinab"));
            Assert.IsTrue(_id.AreYou("Faust"));
        }

        [Test]
        public void TestPrivilegeEscalation()
        {
            _id.PrivilegeEscalation("6473");
            Assert.IsTrue(_id.FirstId == "6473");
        }
    }
}