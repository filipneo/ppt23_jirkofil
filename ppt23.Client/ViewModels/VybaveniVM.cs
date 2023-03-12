using System.Collections.Generic;
using System.Text;

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
        DateTime since = new DateTime(2018, 01, 01);

		Name = GetRandomName(random.Next(4,10));
        BoughtDateTime = GetRandomDate(since);
        LastRevision = GetRandomDate(BoughtDateTime);
	}

    public string GetRandomName(int len)
    {
        Random random = new Random();
        StringBuilder name = new StringBuilder();

        for (int i = 0; i < len; i++)
        {
            char letter = (char)random.Next('a', 'z' + 1);
            name.Append(letter);
        }

        return name.ToString();
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

        for (int i = 0; i < random.Next(4, 16); i++)
        {
            VybaveniVM vybaveni = new();
            vybaveniList.Add(vybaveni);
        }

        return vybaveniList;
    }

}
