using Website.Interfaces;
using Website.Models;

namespace Website;

public static class TestDataGenerator
{
    public static void InjectTestData(IServiceProvider serviceProvider)
    {
        IBookHandler bookHandler = serviceProvider.GetService<IBookHandler>()!;
        foreach (Book book in GetBooks())
        {
            bookHandler.AddBook(book);
        }

        IVideoHandler videoHandler = serviceProvider.GetService<IVideoHandler>()!;
        foreach (Video video in GetVideos())
        {
            videoHandler.AddVideo(video);
        }

        IProblemHandler problemHandler = serviceProvider.GetService<IProblemHandler>()!;
        foreach (Problem problem in GetProblems())
        {
            problemHandler.AddProblem(problem);
        }
    }

    private static IEnumerable<Book> GetBooks()
    {
        return new List<Book>
        {
            new Book
            {
                Name = "Designing Data-Intensive Applications"
            },
        };
    }

    private static IEnumerable<Video> GetVideos()
    {
        return new List<Video>
        {
            new Video
            {
                Name = "A deep-dive on Linux signal handling",
                Url = "https://www.youtube.com/embed/d0gS5TXarXc",
            },
            new Video
            {
                Name = "A short introduction to the internet",
                Url = "https://www.youtube.com/embed/jjKFXlFNR4E",
            },
            new Video
            {
                Name = "Fibonacci Heaps or \"How to invent an extremly clever data structure\"",
                Url = "https://www.youtube.com/embed/6JxvKfSV9Ns",
            },
            new Video
            {
                Name = "Essence of Linear Algebra",
                Url = "https://www.youtube.com/embed/fNk_zzaMoSs?list=PLZHQObOWTQDPD3MizzM2xVFitgF8hE_ab",
            },
        };
    }

    private static IEnumerable<Problem> GetProblems()
    {
        return new List<Problem>
        {
            new Problem
            {
                Name = "Thomaesche Funktion"
            },
            new Problem
            {
                Name = "Night of the Profs"
            },
            new Problem
            {
                Name = "Navigating the Grid"
            },
            new Problem
            {
                Name = "The Penguin Problem"
            },
            new Problem
            {
                Name = "Dislo-Bijektion"
            },
        };
    }
}
