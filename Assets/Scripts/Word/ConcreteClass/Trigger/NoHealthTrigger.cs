using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AI
{
    /// <summary>
    /// 生命值为0
    /// </summary>
    class NoHealthTrigger : AbstractTrigger
    {
        override public void Awake()
        {
            base.Awake();
            id = TriggerID.NoHealth;
        }

        public delegate void Live();
        public event Live OnLive;

        public override bool Satisfy(MyState0 myState)
        {
            if (myState.character.hp <= 0)
            {
                if (myState.character.reLifes>0)//复活
                {
                    myState.character.hp = myState.character.MaxHP;
                    myState.character.reLifes--;
                    if (OnLive != null) OnLive();
                    return false;
                }
                else//死亡
                    return true;
            }
            else//hp>0
                return false;
        }
    }
}
