using UpworkDemo.Enums;

namespace UpworkDemo.Models;

public class Job
{
	public string Id { get; set; }
	public string Title { get; set; }
	public string Description { get; set; }
	public List<string> Tags { get; set; }
	public bool IsClientPaymentVerified { get; set; }
	public double Price { get; set; }
	public double ClientRating { get; set; }
	public int ClientSpent { get; set; }
	public string Location { get; set; }
	public int ProposalCount { get; set; }
	public DateTime CreatedDate { get; set; }
	public WorkTypeEnums WorkType { get; set; }
	public DeveloperLevelEnums Level { get; set; }
	public bool ShowClientSpent { get; set; }
}

