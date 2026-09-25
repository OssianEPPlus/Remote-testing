namespace RemoteTesting
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var myNumber = 2;
            Assert.AreEqual(2, myNumber);
        }
    }
}
