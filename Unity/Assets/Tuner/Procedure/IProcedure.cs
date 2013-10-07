namespace Tuner.Procedure
{
		public interface IProcedure
		{
				void onEnter ();

				void onExit ();

				string GetProcedureName ();
				
				void Update ();
		}
}

