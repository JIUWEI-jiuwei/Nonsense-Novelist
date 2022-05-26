using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AI
{
    /// <summary>
    /// Àë¿ª¹¥»÷·¶Î§
    /// </summary>
    class OutAttackTrigger : AbstractTrigger
    {
        override public void Awake()
        {
            base.Awake();
            id = TriggerID.OutAttack;
        }
        public override bool Satisfy(MyState0 myState)
        {
           if(myState.aim==null ||
                Vector3.Distance(myState.transform.position, myState.aim.transform.position) > myState.character.attackDistance)
                return true;
           else return false;
        }
    }
}
