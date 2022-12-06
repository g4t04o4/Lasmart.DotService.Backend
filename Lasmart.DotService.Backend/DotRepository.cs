using Microsoft.EntityFrameworkCore;

namespace Lasmart.DotService.Backend;

public class DotRepository : IDotRepository
{
    public DotRepository()
    {
        using var context = new DotContext();
        var dots = new List<Dot>
        {
            new Dot
            {
                X = 30,
                Y = 30,
                Radius = 5,
                Color = "Black",
                Comments = new List<Comment>()
                {
                    new Comment
                    {
                        Text = "Real",
                        Color = "White"
                    },
                    new Comment
                    {
                        Text = "talk",
                        Color = "Grey"
                    },
                    new Comment
                    {
                        Text = "now",
                        Color = "White"
                    }
                }
            },
            new Dot
            {
                X = 190,
                Y = 100,
                Radius = 10,
                Color = "Red",
                Comments = new List<Comment>()
                {
                    new Comment
                    {
                        Text = "It goes faster",
                        Color = "White"
                    }
                }
            },
            new Dot
            {
                X = 150,
                Y = 300,
                Radius = 15,
                Color = "Green"
            },
            new Dot
            {
                X = 400,
                Y = 190,
                Radius = 20,
                Color = "Yellow",
                Comments = new List<Comment>()
                {
                    new Comment
                    {
                        Text = "Kidney stone",
                        Color = "Yellow"
                    }
                }
            },
            new Dot
            {
                X = 500,
                Y = 500,
                Radius = 18,
                Color = "Black"
            },
            new Dot
            {
                X = 100,
                Y = 550,
                Radius = 50,
                Color = "Magenta",
                Comments = new List<Comment>()
                {
                    new Comment
                    {
                        Text = "Big chungus",
                        Color = "Cyan"
                    }
                }
            }
        };

        context.Dots.AddRange(dots);
        context.SaveChanges();
    }

    public List<Dot> GetDots()
    {
        using var context = new DotContext();
        var list = context.Dots
            .Include(dot => dot.Comments)
            .ToList();
        return list;
    }
}