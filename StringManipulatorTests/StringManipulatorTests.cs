using StringManipulator;

namespace StringManipulatorTests
{
    public class StringManipulatorTests
    {
        private readonly StringManipulator.StringManipulator stringManipulator;

        public StringManipulatorTests()
        {
            this.stringManipulator = new StringManipulator.StringManipulator();
        }

        [Fact]
        public void ReverseString_WhenCalled_ReturnsReversedString()
        {
            // Arrange
            string input = "Hello World";

            // Act
            string result = stringManipulator.ReverseString(input);

            // Assert
            Assert.Equal("dlroW olleH", result);
        }

        [Theory]
        [InlineData("Chau", "uahC")]
        [InlineData("Hola", "aloH")]
        public void Theory_ReverseString_WhenCalled_ReturnsReversedString(string word, string drow)
        {
            // Arrange
            string input = word;

            // Act
            string result = stringManipulator.ReverseString(input);

            // Assert
            Assert.Equal(drow, result);
        }

        [Fact]
        public void CountWords_WhenCalled_ReturnsNumberOfWords()
        {
            // Arrange
            string input = "This is a sample sentence.";

            // Act
            int result = stringManipulator.CountWords(input);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void CountWords_WithEmptyString_ReturnsZero()
        {
            // Arrange
            string input = "";

            // Act
            int result = stringManipulator.CountWords(input);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void CountWords_WithNullInput_ThrowsNullReferenceException()
        {
            // Arrange
            string input = null;

            // Act & Assert
            Assert.Throws<NullReferenceException>(() => stringManipulator.CountWords(input));
        }

        [Fact]
        public void CountWords_WithSubZeroCharactersPerLine_ThrowsArgumentException()
        {
            // Arrange
            string input = "Hola";
            int charsByLine = 0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => stringManipulator.CountLines(input, charsByLine));
        }

        [Fact]
        public void CountWords_WithSubZeroCharactersPerLine_ThrowsArgumentException2()
        {
            // Arrange
            string input = "Hola";
            int charsByLine = 0;

            // Act & Assert
            try
            {
                stringManipulator.CountLines(input, charsByLine);
            } catch (ArgumentException ex)
            {
                Assert.True(true);
                return;
            }

            Assert.True(false);
        }
    }
}