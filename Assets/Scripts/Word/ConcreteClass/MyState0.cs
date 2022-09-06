using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AI
{
    /// <summary>
    /// 自己状态（抽象角色脚本挂上时，此脚本自动跟着挂上）
    /// </summary>
    class MyState0 : MonoBehaviour
    {
        /// <summary>角色</summary>
        [HideInInspector] public AbstractCharacter character;
        /// <summary>拥有的所有状态</summary>
        public List<AbstractState> allState = new List<AbstractState>();
        /// <summary>当前状态</summary>
        public AbstractState nowState;
        /// <summary>默认状态</summary>
        [HideInInspector] public AbstractState defaultState;


        /// <summary>关注的目标</summary>
        public AbstractCharacter aim;
        /// <summary>扇形搜索（用于调用其中方法）</summary>
        public SingleSelector sectorSearch = new SingleSelector();
        /// <summary>移速</summary>
        public float speed = 0.1f;

        public void Awake()
        {
            allState.Add(gameObject.AddComponent<IdleState>());
            allState.Add(gameObject.AddComponent<AttackState>());
            allState.Add(gameObject.AddComponent<DeadState>());
            allState.Add(gameObject.AddComponent<DizzyState>());
        }
        public void Start()
        {
            character = this.GetComponent<AbstractCharacter>();
            nowState = defaultState = allState.Find(p => p.id == StateID.idle);
            nowState.EnterState(this);

            aim = FindAim();
            StartCoroutine(Every1Seconds());
        }


        public void FixedUpdate()
        {
            nowState.Action(this);
            nowState.CheckTrigger(this);
        }
        IEnumerator Every1Seconds()
        {
            while (true)
            {
                aim = FindAim();//不断寻找更近的敌人
                yield return new WaitForSeconds(1);
            }
        }
        /// <summary>
        /// 寻找目标
        /// </summary>
        public AbstractCharacter FindAim()
        {
            //所有目标
            AbstractCharacter[] a = sectorSearch.CaculateRange(999, character.situation,NeedCampEnum.enemy);
            return a[0];
        }
        /// <summary>
        /// 状态切换
        /// </summary> 
        public void ChangeActiveState(StateID stateID)
        {
            nowState.Exit(this);
            nowState = allState.Find(p => p.id == stateID);
            nowState.EnterState(this);
        }
    }

}
