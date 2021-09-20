using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests_2
    {
        //These fields were added later
        private StreamingContentRepository _repo;
        private StreamingContent _matrix;

        //TestInitialized added later
        [TestInitialize]
        public void Arrange()
        {
            _matrix = new StreamingContent("Matrix", "Mind bending scifi drama", 1.75, 8.7, "SciFi", MaturityRatingEnum.PG13);
            StreamingContent jurasicPark = new StreamingContent("Jurassic Park", "Rawr Dinos", 2, 10, "SciFi", MaturityRatingEnum.PG);
            StreamingContent oldboy = new StreamingContent("Oldboy", "blah blah blah", 2.1, 7, "Yes", MaturityRatingEnum.R);

            StreamingContentRepository repo = new StreamingContentRepository();


            _repo = new StreamingContentRepository();

            _repo.AddContentToDirectory(_matrix);
            _repo.AddContentToDirectory(jurasicPark);
            _repo.AddContentToDirectory(oldboy);

        }

        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //Arrange --Getting what we need to run our tests. "Making a book and a shelf"
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();


            //Act 
            bool success = repository.AddContentToDirectory(content);


            //Assert
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void GetAllStreamingContentsInDirectory_ShouldReturnAllStreamingContentInTheContentDirectory()
        {
            //Arrange
            StreamingContent matrix = new StreamingContent("Matrix", "Mind bending scifi drama", 1.75, 8.7, "SciFi", MaturityRatingEnum.PG13);
            StreamingContentRepository repo = new StreamingContentRepository();

            repo.AddContentToDirectory(matrix);
            //Act
            List<StreamingContent> movieList = repo.GetContents();

            bool success = movieList.Contains(matrix);

            //to print all of the movie titles in the list
            for (int i = 0; i < movieList.Count; i++)
            {
                Console.WriteLine(movieList[i].Title);
            }


            //Assert

            Assert.IsTrue(success);


        }

        [TestMethod]
        public void GetContentByTitle_ShouldReturnCorrectContent()
        {
            //Arange
            //Handled in Arrange Method

            //Act
            StreamingContent searchResult = _repo.GetContentByTitle("matrix");

            //Assert
            Assert.AreEqual(_matrix.Description, searchResult.Description);
        }

        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent contentToUpdate = _repo.GetContentByTitle("Matrix");
            StreamingContent newContent = new StreamingContent("The Matrix", "An epic mindbending SciFi Drama", 1.5, 8, "SciFi", MaturityRatingEnum.PG13);

            //Act
            bool updateresult = _repo.UpdateExistingContent(contentToUpdate, newContent);

            //Assert
            Assert.IsTrue(updateresult);
        }
        [TestMethod]
        public void DeleteContentByTitle_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent contentToDelete = _repo.GetContentByTitle("oldboy");
            //Act

            bool removeResult = _repo.DeleteContent(contentToDelete);

            //Assert
            Assert.IsTrue(removeResult);
        }
    }
}
