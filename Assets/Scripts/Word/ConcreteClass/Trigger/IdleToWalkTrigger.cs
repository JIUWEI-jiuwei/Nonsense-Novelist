using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AI
{
    /// <summary>
    /// 开始走路
    /// </summary>
    class IdleToWalkTrigger : AbstractTrigger
    {
        override public void Awake()
        {
            base.Awake();
            id = TriggerID.IdleToWalk;
        }
        public override bool Satisfy(MyState0 myState)
        {
            if (myState.aim != null)
            {
                return true;
            }
            else 
                return false;
        }
    }
}
