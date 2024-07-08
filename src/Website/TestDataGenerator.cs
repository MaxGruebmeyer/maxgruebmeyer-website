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

        IUtilLinkHandler utilLinkHandler = serviceProvider.GetService<IUtilLinkHandler>()!;
        foreach (UtilLink utilLink in GetUtilLinks())
        {
            utilLinkHandler.AddLink(utilLink);
        }
    }

    private static IEnumerable<Book> GetBooks()
    {
        return new List<Book>
        {
            new Book
            {
                Name = "Designing Data-Intensive Applications",
                Url = "https://dataintensive.net/",
                ImageUrl = "https://dataintensive.net/images/book-cover.png",
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
                Name = "Fibonacci Heaps explained",
                Url = "https://www.youtube.com/embed/6JxvKfSV9Ns",
            },
            new Video
            {
                Name = "The Essence of Linear Algebra",
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
                Name = "Thomaesche Funktion",
                Classification = ProblemClassification.RealAnalysis,
            },
            new Problem
            {
                Name = "Average of the sum of sequence links",
                Classification = ProblemClassification.RealAnalysis,
            },
            new Problem
            {
                Name = "Night of the Profs",
                Classification = ProblemClassification.Combinatorics,
            },
            new Problem
            {
                Name = "Navigating the Grid",
                Classification = ProblemClassification.Combinatorics,
            },
            new Problem
            {
                Name = "The Penguin Problem",
                Classification = ProblemClassification.DSA | ProblemClassification.DiscreteMath
            },
            new Problem
            {
                Name = "Dislo-Bijektion",
                Classification = ProblemClassification.DiscreteMath
            },
        };
    }

    private static IEnumerable<UtilLink> GetUtilLinks()
    {
        return new List<UtilLink>
        {
            new UtilLink
            {
                Name = "Binary Converter",
                Description = "Easily convert numbers between binary, decimal and hexadecimal",
                Target = "https://www.rapidtables.com/convert/number/hex-to-binary.html",
            },
            new UtilLink
            {
                Name = "Integralrechner",
                Description = "Calculate Integrals. Also explains its solution (german only)",
                Target = "https://www.integralrechner.de/",
            },
            new UtilLink
            {
                // TODO (GM): Write your own differential calculator... how hard can it be?
                Name = "Differentialrechner",
                Description = "Calculate Differentials. Also explains its solution (german only)",
                Target = "https://www.ableitungsrechner.net/",
            },
            new UtilLink
            {
                // TODO (GM): Write your own client-side text-compare for security reasons
                Name = "Text-Compare",
                Description = "Find the differences between two strings",
                Target = "https://text-compare.com/",
            },
        };
    }
}
