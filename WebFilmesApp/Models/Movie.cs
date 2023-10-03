namespace WebFilmes.Models;

public class Movie
{
	public int Id { get; set; }
	public string Title { get; set; }
	public int ReleaseYear { get; set; }
	public string Genre { get; set; }
	public string Director { get; set; }
	public string Synopsis { get; set; }
	// public List<string> Cast { get; set; }

	// public Movie()
	// {
	//	 Cast = new List<string>();
	// }

	public override string ToString()
	{
		return $"{Title} ({ReleaseYear}) - {Genre} - Directed by {Director}";
	}
}