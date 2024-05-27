namespace Infastructure.Models;

public class CourseDetailModel
{
    public string? Id { get; set; }
    public bool IsBestseller { get; set; }
    public string? ImageUri { get; set; }
    public string? Title { get; set; }
    public string? Ingress { get; set; }
    public string? Author { get; set; }
    public decimal CurrentPrice { get; set; }
    public decimal DiscountPrice { get; set; }
    public string? Hours { get; set; }
    public decimal StarRating { get; set; }
    public string? LikesInNumbers { get; set; }
    public string? ContentDescription { get; set; }
    public string? ContentIncludes { get; set; }
    public List<string>? ProgramId { get; set; }
    public List<string>? ProgramTitle { get; set; }
    public List<string>? ProgramDescription { get; set; }
}
