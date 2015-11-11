using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    public class InfiniteBoard : Board
    {
        public List<Cell> Cells { get; set; }

        public InfiniteBoard()
        {
            Cells = new List<Cell>();
        }
        public void Tick()
        {
            throw new NotImplementedException();
        }

        public List<List<bool>> ToList()
        {
            throw new NotImplementedException();
        }

        public int CellCount()
        {
            return Cells.Count;
        }

        public void AddCell(int x, int y)
        {
            Cells.Add(new Cell { X = x, Y = y});
        }

        public int getNumberOfAliveNeighbors(int x, int y)
        {
            int nAlive = 0;

            for(int i=0; i<Cells.Count; i++)
            {
                if(Cells[i].X == x - 1 && Cells[i].Y == y + 1)
                {
                    nAlive++;
                }
                if (Cells[i].X == x && Cells[i].Y == y + 1)
                {
                    nAlive++;
                }
                if (Cells[i].X == x + 1 && Cells[i].Y == y + 1)
                {
                    nAlive++;
                }
                if (Cells[i].X == x - 1 && Cells[i].Y == y)
                {
                    nAlive++;
                }
                if (Cells[i].X == x + 1 && Cells[i].Y == y)
                {
                    nAlive++;
                }
                if (Cells[i].X == x - 1 && Cells[i].Y == y - 1)
                {
                    nAlive++;
                }
                if (Cells[i].X == x && Cells[i].Y == y - 1)
                {
                    nAlive++;
                }
                if (Cells[i].X == x + 1 && Cells[i].Y == y - 1)
                {
                    nAlive++;
                }
            }
            return nAlive;
        }

        public void RemoveCell(int x, int y)
        {
            for(int i=0; i<Cells.Count; i++)
            {
                if(Cells[i].X == x && Cells[i].Y == y)
                {
                    Cells.Remove(Cells[i]);
                }
            }
        }

        public bool CellDoesExist(int x, int y)
        {
            for (int i = 0; i < Cells.Count; i++)
            {
                if (Cells[i].X == x && Cells[i].Y == y)
                {
                    return true;
                }
            }
            return false;
        }

        public void AliveRule(int x, int y)
        {
            int nAlive = getNumberOfAliveNeighbors(x, y);
            if(nAlive == 2 || nAlive == 3)
            {

            }
            else
            {
                RemoveCell(x, y);
            }
        }
    }
}
