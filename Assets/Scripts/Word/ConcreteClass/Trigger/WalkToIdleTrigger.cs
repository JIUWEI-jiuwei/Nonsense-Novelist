using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AI
{
    /// <summary>
    /// ½áÊø×ßÂ·
    /// </summary>
    class WalkToIdleTrigger : AbstractTrigger
    {
        override public void Awake()
        {
            base.Awake();
            id = TriggerID.WalkToIdle;
        }
        public override bool Satisfy(MyState0 myState)
        {
            return false;
        }
    }
}
