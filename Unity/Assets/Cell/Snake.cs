using System.Collections.Generic;
using UnityEngine;

namespace EasySnake
{
    public class Snake
    {
        public Body mHead = null;
        public List<Body> mBody = new List<Body>();
        public E_Cell_Direction mDirection_Default = E_Cell_Direction.right;
        public E_Cell_Direction mDirection_Current;

        public Snake(int x, int y, int bodyNum)
        {
            init(x, y, bodyNum);
        }
                
        public void Update()
        {
                    
        }
                
        public void init(int x, int y, int bodyNum)
        {
            Clear();
            mDirection_Current = mDirection_Default;
            mHead = new Body(x, y, mDirection_Current);
            initBodys(bodyNum);
            Debug.Log("init snake, head pos : " + mHead.x + "__" + mHead.y);
            foreach (Body item in mBody)
            {
                Debug.Log("init snake, body pos : " + item.x + "__" + item.y);
            }
        }

        public void initBodys(int number)
        {
            // 4 direction . but now ,just implement one. ------ right.
            for (int i = 1; i < number +1; i++)
            {
                Body temp = new Body(mHead.x - i, mHead.y, mHead.mDirection);
                mBody.Add(temp);
            }
        }

        public void Clear()
        {
            if (mHead != null)
            {
                mHead.Destory();        
                mHead = null;
            }
            foreach (Body item in mBody)
            {
                item.Destory();
            }
            mBody.Clear();
        }
    }
}