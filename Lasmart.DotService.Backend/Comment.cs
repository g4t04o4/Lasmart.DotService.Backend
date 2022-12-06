namespace Lasmart.DotService.Backend;

public class Comment
{
    public Int32 Id { get; set; }
    public String? Text { get; set; }
    public String? Color { get; set; }
    public Dot Dot { get; set; }
}