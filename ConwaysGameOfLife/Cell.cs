using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    public class Cell
    {
        private int x;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        private int y;
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public Cell(int _x, int _y, bool _dead)
        {
            x = _x;
            y = _y;
            dead = _dead;
        }

        private bool dead;
        public bool Dead
        {
            get { return dead;  }
            set { dead = value; }
        }

        private Cell upLeft;
        public Cell UpLeft
        {
            get { return upLeft; }
            set { upLeft = new Cell(value.x - 1, value.y + 1, true); }
        }

        private Cell up;
        public Cell Up
        {
            get { return up; }
            set { up = new Cell(value.x, value.y + 1, true); }
        }

        private Cell upRight;
        public Cell UpRight
        {
            get { return upRight; }
            set { upRight = new Cell(value.x + 1, value.y + 1, true); }
        }

        private Cell left;
        public Cell Left
        {
            get { return left; }
            set { left = new Cell(value.x - 1, value.y, true); }
        }

        private Cell right;
        public Cell Right
        {
            get { return right; }
            set { right = new Cell(value.x + 1, value.y, true); }
        }

        private Cell downLeft;
        public Cell DownLeft
        {
            get { return downLeft; }
            set { downLeft = new Cell(value.x - 1, value.y - 1, true); }
        }

        private Cell down;
        public Cell Down
        {
            get { return down; }
            set { down = new Cell(value.x, value.y - 1, true); }
        }

        private Cell downRight;
        public Cell DownRight
        {
            get { return downRight; }
            set { downRight = new Cell(value.x + 1, value.y - 1, true); }
        }

        public void setUp()
        {
            Up = this;
            this.Y += 1;
            Up.Down = this;
            this.Y += -1;

            if (this.UpLeft == null)
            {
                this.UpLeft = this;
            }
            this.UpLeft.X += 1;
            Up.Left = this.UpLeft;
            this.UpLeft.X += -1;

            if(this.UpRight == null)
            {
                this.UpRight = this;
            }
            this.UpRight.X += -1;
            Up.Right = this.UpRight;
            this.UpRight.X += 1;
        }

        public void setUpLeft()
        {
            UpLeft = this;
            this.X += -1;
            this.Y += 1;
            UpLeft.DownRight = this;
            this.X += 1;
            this.Y += -1;
        }

        public void setUpRight()
        {
            UpRight = this;
            this.X += 1;
            this.Y += 1;
            UpRight.DownLeft = this;
            this.X += -1;
            this.Y += -1;
        }

        public void setLeft()
        {
            Left = this;
            this.X += -1;
            Left.Right = this;
            this.X += 1;
        }

        public void setRight()
        {
            Right = this;
            this.X += 1;
            Right.Left = this;
            this.X += -1;
        }
        public void setDown()
        {
            Down = this;
            this.Y += -1;
            Down.Up = this;
            this.Y += 1;
        }
        public void setDownLeft()
        {
            DownLeft = this;
            this.X += -1;
            this.Y += -1;
            DownLeft.UpRight = this;
            this.X += 1;
            this.Y += 1;
        }
        public void setDownRight()
        {
            DownRight = this;
            this.X += 1;
            this.Y += -1;
            DownRight.UpLeft = this;
            this.X += -1;
            this.Y += 1;
        }
        //public void setNeighbors()
        //{
        //    UpLeft = this;
        //    Up = this;
        //    UpRight = this;
        //    Left = this;
        //    Right = this;
        //    DownLeft = this;
        //    Down = this;
        //    DownRight = this;
        //}

        //if(Up!==null){create;}
    }
}