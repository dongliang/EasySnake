using System.Collections.Generic;

namespace EasySnake
{
		public class Grid
		{
				public int width;
				public int height;
				public int mSnakeBodyNum_Current = 0;
				public int mSnakeBodyNumber_Default = 3;
				public List<Wall> mWalls = new List<Wall> ();
				public Snake mSnake = null;

				public Grid (int width, int height)
				{
						this.width = width;
						this.height = height;
				}

				public void initBoderWall ()
				{
						//create walls.
				}

				public void Update ()
				{
						mSnake.Update ();
				}

				public void initSnake ()
				{
						mSnakeBodyNum_Current = mSnakeBodyNumber_Default;
						//chorse head pos.
						int y = height / 2;
						int x = mSnakeBodyNum_Current + 1;
						mSnake = new Snake (x, y, mSnakeBodyNum_Current);
				}
		}
}