using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    public class StreamingContentRepository
    {
        private List<StreamingContent> _listOfContent = new List<StreamingContent>();

        // Create
        public void AddContentToList(StreamingContent content)
        {
            _listOfContent.Add(content);
        }

        // Read
        public List<StreamingContent> GetContentList()
        {
            return _listOfContent;
        }

        // Update
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            // Find the content
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            // Update the conent
            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.IsFamilyFriendly = newContent.IsFamilyFriendly;
                oldContent.StarRating = newContent.StarRating;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;

                return true;
            }
            else
            {
                return false;
            }
        }

        // Delete
        public bool RemoveContentFromList(string title)
        {
            StreamingContent content = GetContentByTitle(title);

            if (content == null)
            {
                return false;
            }

            int initialCount = _listOfContent.Count;
            _listOfContent.Remove(content);

            if(initialCount > _listOfContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Helper method
        public  StreamingContent GetContentByTitle(string title)
        {
            foreach(StreamingContent content in _listOfContent)
            {
                if(content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }

            return null;
        }
    }
}
