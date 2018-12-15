using Microsoft.VisualStudio.TestTools.UnitTesting;
using Samplelibrly;

namespace SampleLibliry.Tests
{
    [TestClass]
    public class EvenDiscriminatorTest
    {
        [TestMethod]
        [DataRow(2,true)]
        [DataRow(3, true)]
        [DataRow(10, true)]
        [DataRow(11, true)]
        public void DiscriminateTest(int num,bool expected)
        {
            var actual = EvenDiscriminator.Discriminate(num);
            Assert.AreEqual(expected,actual);
        }
    }
}
