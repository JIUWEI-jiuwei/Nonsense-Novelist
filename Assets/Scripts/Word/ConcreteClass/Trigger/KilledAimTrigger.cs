using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AI
{
    /// <summary>
    /// »÷É±µôÄ¿±ê
    /// </summary>
    class KilledAimTrigger : AbstractTrigger
    {
        override public void Awake()
        {
            base.Awake();
            id = TriggerID.KilledAim;
        }
        public override bool Satisfy(MyState0 myState)
        {
            return (myState.aim.hp<=0);
        }
    }
}
