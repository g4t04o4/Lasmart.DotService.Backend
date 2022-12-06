namespace Lasmart.DotService.Backend;

public class Dot
{
    public Int32 Id { get; set; }
    public Int32 X { get; set; }
    public Int32 Y { get; set; }
    public Int32 Radius { get; set; }
    public String? Color { get; set; }
    public List<Comment>? Comments { get; set; }
}