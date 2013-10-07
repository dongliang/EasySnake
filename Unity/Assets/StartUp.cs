using UnityEngine;
using System.Collections;

public class StartUp : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
				GameObject.DontDestroyOnLoad (gameObject);
				Tuner.Procedure.ProcedureMgr.Instance.Active (EasySnake.Produce_Racing.Instance);
		}
    
		// Update is called once per frame
		void Update ()
		{
				Tuner.Procedure.ProcedureMgr.Instance.Update ();
		}

		void OnLevelWasLoaded ()
		{
				Tuner.Procedure.ProcedureMgr.Instance.mLevelLoaded = true;
		}
}
