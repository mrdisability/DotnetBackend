using System;

public class Post
{
	public Guid Id { get; set; }
	public string Title { get; set; }
    public string Body { get; set; }
	public DateTime CreatedDate { get; set; }
    public string Tag { get; set; }
}
