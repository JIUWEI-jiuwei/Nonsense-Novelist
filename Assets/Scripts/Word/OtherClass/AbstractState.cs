using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AI
{
    /// <summary>
    /// 抽象状态（目前只用于角色）
    /// </summary>
    abstract class AbstractState : MonoBehaviour
    {
        [HideInInspector] public StateID id;
        /// <summary>触发条件对应关系</summary>
        protected List<AbstractTrigger> triggers=new List<AbstractTrigger>();
        /// <summary>触发条件对应关系</summary>
        protected Dictionary<TriggerID,StateID> map=new Dictionary<TriggerID, StateID>();

        virtual public void Awake()
        {
            triggers.Add(gameObject.AddComponent<NoHealthTrigger>());
            map.Add(TriggerID.NoHealth, StateID.dead);
            triggers.Add(gameObject.AddComponent<BeDizzyTrigger>());
            map.Add(TriggerID.BeDizzy, StateID.dizzy);
        }

        /// <summary>
        /// 进入该状态时
        /// </summary>
        public abstract void EnterState(MyState0 myState);
        /// <summary>
        /// 退出该状态时
        /// </summary>
        public abstract void Exit(MyState0 myState);
        /// <summary>
        /// 在该状态期间持续操作
        /// </summary>
        public abstract void Action(MyState0 myState);
        /// <summary>
        /// 检查是否满足条件
        /// </summary>
        public virtual void CheckTrigger(MyState0 myState)
        {
            for(int i=0;i<map.Count;i++)
            {
                if(triggers[i].Satisfy(myState))
                {
                    myState.ChangeActiveState(map[triggers[i].id]);
                }
            }
        }

    }
}
