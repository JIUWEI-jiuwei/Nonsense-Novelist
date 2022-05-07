using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AI
{
    /// <summary>
    /// ��ʼ��·
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
            return (myState.aim!=null);
        }
    }
}