using System.Collections.Generic;

namespace ppt23.Client.ViewModels;

public class VybaveniVM
{
    public string Name { get; set; }
    public DateTime BoughtDateTime { get; set; }
    public DateTime LastRevision { get; set; }
    public bool IsRevisionNeeded { get => LastRevision < DateTime.Now.AddYears(-2); }

    public VybaveniVM()
    {
		Random random = new();
        DateTime since = new DateTime(2013, 01, 01);

		Name = GetRandomName(random.Next(4,10));
        BoughtDateTime = GetRandomDate(since);
        LastRevision = GetRandomDate(since);
	}

    public string GetRandomName(int len)
    {
        Random random = new();
        const string letters = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";

        return new string(Enumerable.Range(0, random.Next(len))
            .Select(x => letters[random.Next(letters.Length)])
            .ToArray());
	}

    public DateTime GetRandomDate(DateTime minDate)
    {
		Random random = new();

		TimeSpan timeSpan = DateTime.Now - minDate;
		TimeSpan randomSpan = new TimeSpan((long)(random.NextDouble() * timeSpan.Ticks));
		DateTime randomDate = minDate + randomSpan;

		return randomDate;
	}

	public static List<VybaveniVM> ReturnRandomList()
    {
        Random random = new();

        List<VybaveniVM> vybaveniList = new();

        for (int i = 0; i < random.Next(5, 15); i++)
        {
            VybaveniVM vybaveni = new();
            vybaveniList.Add(vybaveni);
        }

        return vybaveniList;
    }

}
