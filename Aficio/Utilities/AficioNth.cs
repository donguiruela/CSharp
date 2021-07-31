
using System.Collections.Generic;
using System.Linq;

namespace Aficio
{
    public class Participant
    {
        public int Som { get; set; }
        public string Name { get; set; }
    }

    public class AficioNth
    {
        //_names eg. "Lucas,Mario,Harold"
        //_weight eg. [1, 4, 2]
        //_winNumber 2
        public static string NthRank(string _names, int[] _weight, int _winNumber)
        {
            if (_names.Length == 0) return "NO PARTICIPANTS";
            if (_weight.Length < _winNumber || _winNumber - 1 < 0) return "NOT ENOUGH PARTICIPANTS";

            IList<Participant> Participants = new List<Participant>();
            string[] names = _names.Split(',');

            int index = 0;

            foreach (string name in names)
            {
                int som = name.Length;

                foreach (char letter in name.ToUpper())
                {
                    som += (int)letter - 64;
                }

                som *= _weight[index++];
                Participants.Add(new Participant { Som = som, Name = name });
            }

            var ReversedTickets = Participants.OrderByDescending(participant => participant.Som);
            int winner = ReversedTickets.ElementAt(_winNumber - 1).Som;
            var SortedWinners = ReversedTickets.Where(participant => participant.Som == winner).OrderBy(participant => participant.Name);
            return SortedWinners.ElementAt(0).Name.ToUpper();
        }
    }
}