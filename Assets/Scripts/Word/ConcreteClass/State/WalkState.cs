using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AI
{
    /// <summary>
    /// ×ßÂ·×´Ì¬
    /// </summary>
    class WalkState :AbstractState
    {

        override public void Awake()
        {
            base.Awake();
            id = StateID.walk;
            triggers.Add(gameObject.AddComponent<WalkToIdleTrigger>());
            map.Add(TriggerID.WalkToIdle,StateID.idle);
            triggers.Add(gameObject.AddComponent<IntoAttackTrigger>());
            map.Add(TriggerID.IntoAttack, StateID.attack);
        }
        public override void Action(MyState0 myState)
        {
            if (myState.aim != null)
            {
                if (myState.character.walkAudio != null)
                {
                    myState.character.source.clip = myState.character.walkAudio;
                    myState.character.source.loop = true;
                    myState.character.source.Play();
                }
                //ÒÆ¶¯
                myState.character.transform.position = Vector3.MoveTowards(myState.transform.position, myState.aim.transform.position, myState.speed * Time.deltaTime);
            }
        }


        public override void EnterState(MyState0 myState)
        {
            myState.character.charaAnim.Play(AnimEnum.walk);
        }

        public override void Exit(MyState0 myState)
        {
            myState.character.source.loop = false;
        }
    }

}