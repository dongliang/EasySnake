using UnityEngine;

namespace BaberSnake
{
    public class Produce_Racing:Tuner.Singleton<Produce_Racing>,Tuner.Procedure.IProcedure
    {

        public void onEnter()
        {
            Debug.Log("racing start.");
        }
        
        public void onExit()
        {

        }
        
        public string GetProcedureName()
        {
            return "Produce_Racing";
        }
        
        public void Update()
        {
        }
    }
}


