using _06_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Console
{
    class ProgramUI
    {
        private StreamingContentRepository _contentRepo = new StreamingContentRepository();

        // Method that runs/starts the application
        public void Run()
        {
            SeedContentList();
            Menu();
        }

        // Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                // Display our options to the user
                Console.WriteLine("Select a menu option:\n" +
                    "1) Create new content\n" +
                    "2) View all content\n" +
                    "3) View content by title\n" +
                    "4) Update existing content\n" +
                    "5) Delete existing contenet\n" +
                    "6) Exit");

                // Get the user's input
                string input = Console.ReadLine();

                // Evaluate the user's input and act accordingly
                switch (input)
                {
                    case "1":
                        // Create new content
                        CreateNewContent();
                        break;
                    case "2":
                        // View all content
                        DisplayAllContent();
                        break;
                    case "3":
                        // View content by title
                        DisplayContentByTitle();
                        break;
                    case "4":
                        // Update existing content
                        UpdateExistingContent();
                        break;
                    case "5":
                        // Delete existing content
                        DeleteExistingContent();
                        break;
                    case "6":
                        // Exit
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }

                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // Create new StreamingContent
        private void CreateNewContent()
        {
            Console.Clear();
            StreamingContent newContent = new StreamingContent();

            // Gather properties
            Console.WriteLine("Enter the title for the content:");
            newContent.Title = Console.ReadLine();
            Console.WriteLine("Enter the description for the content:");
            newContent.Description = Console.ReadLine();
            Console.WriteLine("Enter the rating for the content (G, PG, PG-13, etc):");
            newContent.MaturityRating = Console.ReadLine();
            Console.WriteLine("Enter the star count for the content:");
            string starAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starAsString);
            Console.WriteLine("Is this content family friendly? (y/n)");
            string familyFriendlyString = Console.ReadLine().ToLower();

            if(familyFriendlyString == "y")
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }

            Console.WriteLine("Enter the Genre Number:\n" +
                "1) Horror\n" +
                "2) RomCom\n" +
                "3) SciFi\n" +
                "4) Documentary\n" +
                "5) Bromance\n" +
                "6) Drama\n" +
                "7) Action");
            
            string genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            _contentRepo.AddContentToList(newContent);
        }

        // View current StreamingContent that is saved
        private void DisplayAllContent()
        {
            Console.Clear();
            List<StreamingContent> listOfContent = _contentRepo.GetContentList();

            foreach(StreamingContent content in listOfContent)
            {
                Console.WriteLine($"Title: {content.Title}\n" +
                    $" Description: {content.Description}");
            }
        }

        // View existing Content by title
        private void DisplayContentByTitle()
        {
            Console.Clear();
            // Prompt the user to give me a title
            Console.WriteLine("Enter the title of the content you would like to see:");

            // Get the user's input
            string title = Console.ReadLine();
            
            // Find the content by that title
            StreamingContent content = _contentRepo.GetContentByTitle(title);

            // Display said content if it isn't null
            if(content != null)
            {
                Console.WriteLine($"Title: {content.Title}\n" +
                    $" Description: {content.Description}\n" +
                    $"Marturity Rating: {content.MaturityRating}\n" +
                    $"Stars: {content.StarRating}\n" +
                    $"Is Family Friendly: {content.IsFamilyFriendly}\n" +
                    $"Genre: {content.TypeOfGenre}");
            }
            else
            {
                Console.WriteLine("No content by that title.");
            }
        }

        // Update existing content
        private void UpdateExistingContent()
        {
            // Display all content
            DisplayAllContent();

            // Ask for title of content to update
            Console.WriteLine("Enter the title of the content you'd like to update: ");

            // Get that title
            string oldTitle = Console.ReadLine();

            // We will build a new object
            StreamingContent newContent = new StreamingContent();

            // Gather properties
            Console.WriteLine("Enter the title for the content:");
            newContent.Title = Console.ReadLine();
            Console.WriteLine("Enter the description for the content:");
            newContent.Description = Console.ReadLine();
            Console.WriteLine("Enter the rating for the content (G, PG, PG-13, etc):");
            newContent.MaturityRating = Console.ReadLine();
            Console.WriteLine("Enter the star count for the content:");
            string starAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starAsString);
            Console.WriteLine("Is this content family friendly? (y/n)");
            string familyFriendlyString = Console.ReadLine().ToLower();

            if (familyFriendlyString == "y")
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }

            Console.WriteLine("Enter the Genre Number:\n" +
                "1) Horror\n" +
                "2) RomCom\n" +
                "3) SciFi\n" +
                "4) Documentary\n" +
                "5) Bromance\n" +
                "6) Drama\n" +
                "7) Action");

            string genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            // Verify the update worked
            bool wasUpdated = _contentRepo.UpdateExistingContent(oldTitle, newContent);

            if (wasUpdated)
            {
                Console.WriteLine("Content successfully updated.");
            }
            else
            {
                Console.WriteLine("Could not update content.");
            }
        }

        // Delete existing content
        private void DeleteExistingContent()
        {
            DisplayAllContent();

            // Get the title to delete
            Console.WriteLine("\nEnter the title of the content you'd like to removed:");

            string input = Console.ReadLine();

            // Call the delete method
            bool wasDeleted = _contentRepo.RemoveContentFromList(input);

            // If content was deleted, say so
            // Otherwise, state that it could not be deleted
            if (wasDeleted)
            {
                Console.WriteLine("The content was successfully deleted");
            }
            else
            {
                Console.WriteLine("The content could not be deleted.");
            }
        }

        // Seed method
        private void SeedContentList()
        {
            StreamingContent sharknado = new StreamingContent("Sharknado", "Tornadoes, but with sharks", "TV-14", 3.3, true, GenreType.Action);
            StreamingContent theRoom = new StreamingContent("The Room", "Banker's life gets turned upside down", "R", 3.7, false, GenreType.Drama);
            StreamingContent rubber = new StreamingContent("Rubber", "Car tire comes to life and goes on killing spree", "R", 5.8, false, GenreType.Documentary);

            _contentRepo.AddContentToList(sharknado);
            _contentRepo.AddContentToList(theRoom);
            _contentRepo.AddContentToList(rubber);
        }
    }
}
