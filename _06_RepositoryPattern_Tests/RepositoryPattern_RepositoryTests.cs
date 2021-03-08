using System;
using System.Collections.Generic;
using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class RepositoryPattern_RepositoryTests
    {
        private StreamingContentRepository _testRepo = new StreamingContentRepository();
        
        [TestMethod]
        public void GetContentByTitleTest()
        {
            // Arrange
            SeedContentList();
            string trueTitle = "Sharknado";
            string falseTitle = "Shaft";

            StreamingContent trueResultContent, falseResultContent;

            // Act 
            trueResultContent = _testRepo.GetContentByTitle(trueTitle);
            falseResultContent = _testRepo.GetContentByTitle(falseTitle);

            // Assert
            Assert.IsNotNull(trueResultContent);
            Assert.IsNull(falseResultContent);
        }

        // Seed method
        private void SeedContentList()
        {
            StreamingContent sharknado = new StreamingContent("Sharknado", "Tornadoes, but with sharks", "TV-14", 3.3, true, GenreType.Action);
            StreamingContent theRoom = new StreamingContent("The Room", "Banker's life gets turned upside down", "R", 3.7, false, GenreType.Drama);
            StreamingContent rubber = new StreamingContent("Rubber", "Car tire comes to life and goes on killing spree", "R", 5.8, false, GenreType.Documentary);

            _testRepo.AddContentToList(sharknado);
            _testRepo.AddContentToList(theRoom);
            _testRepo.AddContentToList(rubber);
        }

        [TestMethod]
        public void AddContentToListTest()
        {
            // Arrange
            SeedContentList();
            string titleToAdd = "Shaft";
            
            StreamingContent resultContent;

            // Act 
            resultContent = _testRepo.GetContentByTitle(titleToAdd);
            if(resultContent != null)
            {
                Assert.Fail("Title already exists in repository.");
            }
            else
            {
                _testRepo.AddContentToList(new StreamingContent { Title = "Shaft", Description = "shut your mouth", MaturityRating = "R", StarRating = 3.5, IsFamilyFriendly = true, TypeOfGenre = GenreType.Action });
            }

            resultContent = _testRepo.GetContentByTitle(titleToAdd);

            // Assert
            Assert.IsNotNull(resultContent);
        }

        [TestMethod]
        public void GetContentListTest()
        {
            // Arrange
            SeedContentList();
            List<StreamingContent> retrievedList;

            // Act 
            retrievedList = _testRepo.GetContentList();
            int count = retrievedList.Count;

            // Assert
            Assert.AreEqual(3, count);
        }

        [TestMethod]
        public void UpdateExistingContentTest()
        {

        }

        [TestMethod]
        public void RemoveContentFromListTest()
        {

        }
    }
}
