using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomNameChooser;

namespace RandomNameChooserTest
{
    [TestClass]
    public class InputValidatorTest
    {
        private readonly InputValidator inputValidator = new InputValidator();

        string[] names;

        [TestMethod]
        public void ValidateWithCorrectInputShouldGiveBack()
        {
            Assert.AreEqual(expected: ValidationResult.Valid, actual: inputValidator.Validate("Test1\nTest2\nTest3", ref names));
        }

        [TestMethod]
        public void ValidateWithOnlyOneStringShouldGiveBack()
        {
            Assert.AreEqual(expected: ValidationResult.InsufficientData, actual: inputValidator.Validate("Test1", ref names));
        }

        [TestMethod]
        public void ValidateWithNoTextShouldGiveBack()
        {
            Assert.AreEqual(expected: ValidationResult.NoData, actual: inputValidator.Validate("", ref names));
        }

        [TestMethod]
        public void ValidateWithEmptySubstringShouldGiveBack()
        {
            Assert.AreEqual(expected: ValidationResult.EmptyStringDetected, actual: inputValidator.Validate("Test1\n\nTest3", ref names));
        }
    }
}
