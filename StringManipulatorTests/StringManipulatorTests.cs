using StringManipulator;

namespace StringManipulatorTests
{
    public class StringManipulatorTests
    {
        //Metodo
        private readonly StringManipulator.StringManipulator stringManipulator;


        //Constructor
        public StringManipulatorTests()
        {
            this.stringManipulator = new StringManipulator.StringManipulator();
        }

        //Test voltear palabra simple
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

        //Test voltear palabra multiple
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

        //Test contar palabra simple
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


        //Test contar palabra simple

        [Theory]
        [InlineData("Ian es un hinchapelotas.",4)]
        //[InlineData("Hola", "aloH")]

        public void Theory_CountWords_WhenCalled_ReturnsNumberOfWords(string sentence, int drow)
        {
            // Arrange
            string input = sentence;

            // Act
            int result = stringManipulator.CountWords(input);

            // Assert
            Assert.Equal(drow,result);


        }


        //Test contar espacios vacios simple
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

        //Test contar palabra excepcion null simple
        [Fact]
        public void CountWords_WithNullInput_ThrowsNullReferenceException()
        {
            // Arrange
            string input = null;

            // Act & Assert
            Assert.Throws<NullReferenceException>(() => stringManipulator.CountWords(input));
        }

        //Test contar palabra excepcion cero caracteres x linea simple
        [Fact]
        public void CountWords_WithSubZeroCharactersPerLine_ThrowsArgumentException()
        {
            // Arrange
            string input = "Hola";
            int charsByLine = 0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => stringManipulator.CountLines(input, charsByLine));
        }

        //Test contar palabra excepcion cero caracteres x linea simple
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

        [Theory]
        [InlineData("Ian es un hinchapelotas",20)]
        public void CountCharsWithoutSpace(string sentence, int drow)
        {

            // Arrange
            string input = sentence;

            // Act

            int result = stringManipulator.CountCharsWithoutSpace(input);

            // Assert
            Assert.Equal(drow, result);
        }
            

               
    }
}