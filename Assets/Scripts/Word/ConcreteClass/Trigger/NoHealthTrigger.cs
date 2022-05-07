using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AI
{
    /// <summary>
    /// ÉúÃüÖµÎª0
    /// </summary>
    class NoHealthTrigger : AbstractTrigger
    {
        override public void Awake()
        {
            base.Awake();
            id = TriggerID.NoHealth;
        }
        public override bool Satisfy(MyState0 myState)
        {
            return (myState.character.hp<=0);
        }
    }
}
