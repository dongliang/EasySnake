using UnityEngine;

namespace EasySnake
{
		public class Produce_Racing:Tuner.Singleton<Produce_Racing>,Tuner.Procedure.IProcedure
		{
				public Grid mGrid = null;

				public void onEnter ()
				{
						Debug.Log ("racing start.");
						mGrid = new Grid (20, 20);
						mGrid.initSnake ();
				}
        
				public void onExit ()
				{
				
				}
        
				public string GetProcedureName ()
				{
						return "Produce_Racing";
				}
        
				public void Update ()
				{
						if (mGrid != null) {
								mGrid.Update ();
						}
				}
		}
}


