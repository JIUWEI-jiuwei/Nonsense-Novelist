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
        public SectorAttackSelector sectorSearch = new SectorAttackSelector();
        /// <summary>移速</summary>
        public float speed=0.1f;

        public void Awake()
        {
            allState.Add(gameObject.AddComponent<IdleState>());
            allState.Add(gameObject.AddComponent<AttackState>());
            allState.Add(gameObject.AddComponent<DeadState>());
            allState.Add(gameObject.AddComponent<DizzyState>());
            allState.Add(gameObject.AddComponent<WalkState>());
        }
        public void Start()
        {
            character = this.GetComponent<AbstractCharacter>();
            nowState = defaultState = allState.Find(p => p.id == StateID.idle);
            nowState.EnterState(this);


            aim = FindAim();
        }
        public void FixedUpdate()
        {
            nowState.Action(this);
            nowState.CheckTrigger(this);
            if (aim == null)
                aim=FindAim();
            //aim = FindAim();离开AttackState时重新寻找目标+++++++++++++++++++++++++++++++++
        }
        /// <summary>
        /// 寻找目标
        /// </summary>
        public AbstractCharacter FindAim()
        {
            //所有目标
            GameObject[] a = sectorSearch.AttackRange(999, character.transform, character.attackAngle);
            GameObject result;
            if (character.camp == CampEnum.friend)
            {
                result= CollectionHelper.Find<GameObject>(a, p => p.GetComponent<AbstractCharacter>().camp ==CampEnum.enemy|| p.GetComponent<AbstractCharacter>().camp == CampEnum.stranger);
                if (result != null)
                    return result.GetComponent<AbstractCharacter>();
                else
                    return null;
            }
            if (character.camp == CampEnum.enemy)
            {
                result = CollectionHelper.Find<GameObject>(a, p => p.GetComponent<AbstractCharacter>().camp == CampEnum.friend || p.GetComponent<AbstractCharacter>().camp == CampEnum.stranger);
                if (result != null)
                    return result.GetComponent<AbstractCharacter>();
                else
                    return null;
            }
            else
                return null;
        }
        /// <summary>
        /// 状态切换
        /// </summary> 
        public void ChangeActiveState(StateID stateID)
        {
            nowState.Exit(this);
            nowState=allState.Find(p=>p.id == stateID);
            nowState.EnterState(this);
        }
    }

}
