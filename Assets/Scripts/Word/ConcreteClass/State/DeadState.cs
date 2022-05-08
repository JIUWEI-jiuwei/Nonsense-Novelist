using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AI
{
    /// <summary>
    /// ����״̬
    /// </summary>
    class DeadState :AbstractState
    {

        override public void Awake()
        {
            base.Awake();
            id = StateID.dead;
        }
        public override void Action(MyState0 myState)
        {
            
        }


        public override void EnterState(MyState0 myState)
        {
            myState.character.charaAnim.Play(AnimEnum.dead);
            Destroy(this.gameObject);
        }

        public override void Exit(MyState0 myState)
        {
            
        }
    }

}