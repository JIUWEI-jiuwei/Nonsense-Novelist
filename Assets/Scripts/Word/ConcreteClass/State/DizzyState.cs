using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AI
{
    /// <summary>
    /// 被晕状态
    /// </summary>
    class DizzyState :AbstractState
    {

        override public void Awake()
        {
            base.Awake();
            id = StateID.dizzy;
            triggers.Add(gameObject.AddComponent<OutDizzyTrigger>());   
            map.Add(TriggerID.OutDizzy,StateID.idle);
        }
        public override void Action(MyState0 myState)
        {
        }


        public override void EnterState(MyState0 myState)
        {
            myState.character.charaAnim.Play(AnimEnum.beAttacked);
        }

        public override void Exit(MyState0 myState)
        {
            myState.character.dizzyTime = 0;
        }

        /// <summary>
        /// 播放眩晕动画（beAttacked播放完后调用此事件）
        /// </summary>
        public void PlayDizzyAnim()
        {
            //myState.character.charaAnim.Play(AnimEnum.dizzy);
        }
    }

}