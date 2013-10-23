namespace EasySnake
{
		public class Body:Cell
		{
				public	Body (int x, int y, E_Cell_Direction direction):base(x,y)
				{
						mDirection = direction;
						mlastX = x;
						mlastY = y;
				}

				public int mlastX;
				public int mlastY;
				
		}
}