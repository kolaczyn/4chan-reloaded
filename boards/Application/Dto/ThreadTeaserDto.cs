namespace boards.Application.Dto;

public class ThreadTeaserDto
{
    public required int Id { get; set; }
    public required string Message { get; set; }
    public required int RepliesCount { get; set; }
}