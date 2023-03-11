namespace ppt23.Client.ViewModels;

public class VybaveniVM
{
    public string Name { get; set; } = "";
    public DateTime BoughtDateTime { get; set; }
    public DateTime LastRevision { get; set; }
    public bool IsRevisionNeeded;

    public VybaveniVM(string name, DateTime boughtDateTime, DateTime lastRevision)
    {
        Name = name;
        BoughtDateTime = boughtDateTime;
        LastRevision = lastRevision;
        IsRevisionNeeded = IsRevisionOld(LastRevision);
	}

	public static bool IsRevisionOld(DateTime lastRevision)
	{
		DateTime currentDate = DateTime.Now;

		if (lastRevision < currentDate.AddYears(-2)) return true;

		else return false;
	}

/*	
	public static List<VybaveniVM> ReturnRandomList(int number)
    {
        return new List<VybaveniVM> { new VybaveniVM() { Name = "" }};
    }
*/

}
