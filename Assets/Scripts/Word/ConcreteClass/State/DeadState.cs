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
            triggers.Add(gameObject.AddComponent<ReLifeTrigger>());
            map.Add(TriggerID.ReLife, StateID.idle);
        }
        public override void Action(MyState0 myState)
        {
            //�����궯��������
            Destroy(this.gameObject);
        }


        public override void EnterState(MyState0 myState)
        {
            myState.character.charaAnim.Play(AnimEnum.dead);
            if (myState.character.camp == CampEnum.enemy)
            {
                UIManager.isEnd();
            }
            
        }

        public override void Exit(MyState0 myState)
        {
            
        }
    }

}