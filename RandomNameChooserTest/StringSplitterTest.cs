using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomNameChooser;

namespace RandomNameChooserTest
{
    [TestClass]
    public class StringSplitterTest
    {
        private readonly StringSplitter stringSplitter = new StringSplitter();

        [TestMethod]
        public void StringSplitterShouldSplitStringOnNewline()
        {
            string[] strings = { "Test1", "Test2", "Test3" };
            CollectionAssert.AreEqual(expected: strings, actual: stringSplitter.SplitStringOnSplitter("Test1\nTest2\nTest3", "\n"));
        }

        [TestMethod]
        public void StringWithoutSplitterShouldReturn()
        {
            string[] strings = { "Test1" };
            CollectionAssert.AreEqual(expected: strings, actual: stringSplitter.SplitStringOnSplitter("Test1", "\n"));
        }
    }
}
