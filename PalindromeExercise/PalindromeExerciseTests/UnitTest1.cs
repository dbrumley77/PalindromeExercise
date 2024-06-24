using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        
            [Theory]
            [InlineData("bob", true)]//Add test data <-------
            [InlineData("racecar", true)]
            
            public void IsAPalindromeTest(string word, bool expected)
            {
                //Start Step 3 here:

                //Arrange
                // create a Calculator object
                WordSmith wordTest = new WordSmith();

                //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                bool actual = wordTest.IsAPalindrome(word);


                //Assert
                //Assert.Equal(expected, actual);
                Assert.Equal(expected, actual);
            }



        

    }



}
