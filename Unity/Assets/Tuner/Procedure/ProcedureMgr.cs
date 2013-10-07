using UnityEngine;

namespace Tuner.Procedure
{
		public class ProcedureMgr:Tuner.Singleton<ProcedureMgr>
		{
				
				IProcedure mCurrentProduce = null;
				public bool mLevelLoaded = false;
				bool mLoading = false;

				public void Active (IProcedure procedure)
				{
						if (mCurrentProduce != null) {
								mCurrentProduce.onExit ();
						}
						mCurrentProduce = procedure;
						mLoading = true;
						Application.LoadLevel (procedure.GetProcedureName ());
				}
				
				public void Update ()
				{
						if (mLevelLoaded) {
								if (mLoading) {
										mCurrentProduce.onEnter ();
										mLoading = false;
								}
								mLevelLoaded = false;
						} else if (mCurrentProduce != null) {
								mCurrentProduce.Update ();
						}
				}
		}
}
