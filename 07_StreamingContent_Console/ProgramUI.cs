using _06_RepositoryPattern_Repository;
using _07_StreamingContent_Console.Consoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Console
{
    public class ProgramUI
    {
        private StreamingContentRepository _repo = new StreamingContentRepository();
        private readonly IConsole _console;

        public ProgramUI(IConsole console)
        {
            _console = console;
        }
        public void Run()
        {
            SeedData();

            RunMenu();
        }

        private void RunMenu()
        {
            //Create a menu with options matching up to my Repository

            bool isRunning = true;
            while (isRunning)
            {
                _console.Clear();

                _console.WriteLine
                    (
                    "Enter the number of your selection:\n" +
                    "1. Create new streaming content\n" +
                    "2. Show all streaming content\n" +
                    "3. Find streaming content by title\n" +
                    "4. Update Content by title\n" +
                    "5. Remove Content\n" +
                    "6. Exit"
                    );

                string userInput = _console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        //Creat new content
                        CreatNewContent();
                        break;
                    case "2":
                        //Show all Content
                        ShowAllContent();
                        break;
                    case "3":
                        //Show content By Title
                        ShowContentTitle();
                        break;
                    case "4":
                        //Update content
                        break;
                    case "5":
                        //Delete Content
                        break;
                    case "6":
                        isRunning = false;
                        //Exit
                        break;
                    default:
                        _console.WriteLine("Enter a valid number between 1 and 6\n" +
                            "Press any key to continue");
                        _console.ReadLine();
                        _console.ReadKey();
                        break;

                }
            }
        }
            //Creating Content
            private void CreatNewContent()
            {
                _console.Clear();

                StreamingContent content = new StreamingContent();

            //Title
            _console.WriteLine("Please enter a title");
            content.Title = _console.ReadLine();

            //Description
            _console.WriteLine("Please enter a description");
            content.Description = _console.ReadLine();

            //Runtime
            _console.WriteLine("Please enter a runtime of the content");
            content.RunTime = Convert.ToDouble(_console.ReadLine());

            //Review Rating
            _console.WriteLine("What is the review score (0 - 10");
            content.ReviewRating = double.Parse(_console.ReadLine());

            //Maturity Rating
            _console.WriteLine("Select a maturity rating:\n" +
                "1.G\n" +
                "2.PG\n" +
                "3.TV Y\n" +
                "4.TV Y7\n" +
                "5.PG13\n" +
                "6.R\n" +
                "7.NC17\n" +
                "8.NR\n" +
                "9.TV MA");

                string maturityRatingString = _console.ReadLine();
                int maturityRatingId = int.Parse(maturityRatingString);
                content.RatingOfMaturity = (MaturityRatingEnum)maturityRatingId;

                
                //Genre
                _console.WriteLine("what is the genre:");
                content.Genre = _console.ReadLine();

                _repo.AddContentToDirectory(content);
            }

            //Getting all Content
            private void ShowAllContent()
            {
                //Clean slate to start with
                _console.Clear();

                List<StreamingContent> listOfContent = _repo.GetContents();
                
                foreach(StreamingContent content in listOfContent)
                {
                    //Using helper method
                    DisplayContent(content);
                }

                _console.WriteLine("Press any key to continue");
                _console.ReadKey();
            }

            //Getting specific Content (By Title)
            private void ShowContentTitle()
            {
                _console.Clear();

                _console.WriteLine("What Title are you looking for?");
                string title = _console.ReadLine();

                StreamingContent content = _repo.GetContentByTitle(title);
                //Verify that content is in our repository
                //Using helper method
                DisplayContent(content);
                _console.WriteLine("Press any key to continue");
                _console.ReadKey();

        }

            //Update Content
            //Delete Content

            //Helper Methods
            private void DisplayContent(StreamingContent content)
            {
                _console.WriteLine(
                    $"Title: { content.Title}\n" +
                    $"Description:{content.Description}\n" +
                    $"RunTime: {content.RunTime}\n" +
                    $"Review Score: {content.ReviewRating}\n" +
                    $"Family Friendly:{content.IsFamilyFriendly}\n" +
                    $"Maturity Rating:{content.RatingOfMaturity}\n" +
                    $"Genre: {content.Genre}\n\n");
             }
            //Exit ////Set up earlier

        private void SeedData()
        {
            StreamingContent starwars = new StreamingContent("Star Wars", "Space Opera", 2.5, 7, "SciFi", MaturityRatingEnum.PG13);
            StreamingContent theMatrix = new StreamingContent("The Matrix", "mind bending and set in future", 2.25, 8, "SciFi", MaturityRatingEnum.PG13);
            StreamingContent toyStory = new StreamingContent("Toy Story", "what really goes bump in the night", 1.75, 8.5, "Animation", MaturityRatingEnum.PG);

            _repo.AddContentToDirectory(starwars);
            _repo.AddContentToDirectory(theMatrix);
            _repo.AddContentToDirectory(toyStory);
        }
    }
}
