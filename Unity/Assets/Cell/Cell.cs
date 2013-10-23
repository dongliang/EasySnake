namespace EasySnake
{
	public enum E_Cell_Direction
		{
				up,
				right,
				down,
				left
		}

		public class Cell
		{
				public int x;
				public int y;
				public E_Cell_Direction mDirection = E_Cell_Direction.up;
			
				public Cell (int x, int y)
				{
						this.x = x;
						this.y = y;
				}
		
				public void Destory ()
				{
			
				}
		}


}