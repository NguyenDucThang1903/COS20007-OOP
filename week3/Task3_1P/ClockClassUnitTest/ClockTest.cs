namespace ClockClassUnitTest
{
    public class Tests
    {
        Clock _clock_test;

        [SetUp]
        public void Setup()
        {
            _clock_test = new Clock();
        }

        [Test]
        public void TestClockStart()
        {
            Assert.AreEqual("00:00:00", _clock_test.ClockTime);
        }

        [Test]
        public void TestTick()
        {
            _clock_test.Tick();
            Assert.AreEqual("00:00:01", _clock_test.ClockTime);
        }

        [Test]
        public void TestReset()
        {
            _clock_test.Tick();
            _clock_test.Reset();
            Assert.AreEqual("00:00:00", _clock_test.ClockTime);
        }

        [TestCase(60)]
        public void TestFormat(int times)
        {
            for(int i=0; i<times; i++)
            {
                _clock_test.Tick();
            }
            Assert.AreEqual("00:01:00", _clock_test.ClockTime);
        }
    }
}