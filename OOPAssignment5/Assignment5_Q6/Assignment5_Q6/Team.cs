using System;
using System.Collections;
using System.Text;

namespace Assignment5_Q6
{
    public class Team: IEnumerable
    {
        public Player[] player;
        public Team(Player[] players)
        {
            player = new Player[players.Length];
            for(int i = 0; i < players.Length; i++)
            {
                player[i] = players[i];
            }
        }
        //Ienumerable implementation
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public TeamEnum GetEnumerator()
        {
            return new TeamEnum(player);
        }
    }

    public class TeamEnum : IEnumerator
    {
        public Player[] player;
        public int pos = -1;
        public TeamEnum(Player[] p)
        {
            player = p;
        }
        public bool MoveNext()
        {
            pos++;
            return (pos < player.Length);
        }
        public void Reset()
        {
            pos = -1;
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public Player Current
        {
            get
            {
                try
                {
                    return player[pos];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
