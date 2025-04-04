namespace CounterClassUnitTest
{
    public class Tests
    {
        private Counter _cnt_test;
        [SetUp]
        public void Setup()
        {
            _cnt_test = new Counter("Test Counter");
        }

        [Test]
        public void TestCounterStart()
        {
            Assert.IsTrue(_cnt_test.Ticks==0);
        }

        [Test]
        public void TestIncrement()
        {
            _cnt_test.Increment();
            Assert.AreEqual(_cnt_test.Ticks, 1);
        }

        [TestCase(20)]
        public void TestMultipleIncrease(int count)
        {
            for(int i=0; i<count; i++)
            {
                _cnt_test.Increment();
            }
            Assert.AreEqual(_cnt_test.Ticks, count);
        }

        [Test]
        public void TestReset()
        {
            _cnt_test.Increment();
            _cnt_test.Reset();
            Assert.AreEqual(_cnt_test.Ticks, 0);
        }
    }
}