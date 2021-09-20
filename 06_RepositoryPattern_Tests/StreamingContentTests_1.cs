using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests_1
    {
        [TestMethod]
        public void SetTitle_ShouldCorrectString()
        {
            //Arrange
            StreamingContent content = new StreamingContent();

            //Acts
            content.Title = "Little Shop of Horrors";

            //Assert (did this test do what is was supposed to do?)
            string expected = "Little Shop of Horrors";
            string actual = content.Title;

            Assert.AreEqual(expected, actual);

        }

        [DataTestMethod] //Tests multiple data points
        [DataRow(MaturityRatingEnum.G, true)]
        [DataRow(MaturityRatingEnum.PG, true)]
        [DataRow(MaturityRatingEnum.PG13, false)]
        [DataRow(MaturityRatingEnum.R, false)]
        public void SetMaturityRating_ShouldGetCorrectRating(MaturityRatingEnum maturity, bool isFamilyFriendly)
        {
            //AAA
            //Arange
            //Using loaded constructor
            StreamingContent content = new StreamingContent("Title", "Description", 0.5, 99, "Animation", maturity, isFamilyFriendly);

            //Act
            MaturityRatingEnum actualMaturity = content.RatingOfMaturity;
            MaturityRatingEnum expectedMaturity = maturity;

            bool actualIsFamilyFriendly = content.IsFamilyFriendly;
            bool expectedIsFamilyFriendly = isFamilyFriendly;

            //Assert
            Assert.AreEqual(expectedMaturity, actualMaturity);
            Assert.AreEqual(expectedIsFamilyFriendly, actualIsFamilyFriendly);
        }
    }
}
