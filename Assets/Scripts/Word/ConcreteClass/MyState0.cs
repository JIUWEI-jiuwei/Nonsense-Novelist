using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AI
{
    /// <summary>
    /// �Լ�״̬�������ɫ�ű�����ʱ���˽ű��Զ����Ź��ϣ�
    /// </summary>
    class MyState0 : MonoBehaviour
    {
        /// <summary>��ɫ</summary>
        [HideInInspector] public AbstractCharacter character;
        /// <summary>ӵ�е�����״̬</summary>
        public List<AbstractState> allState = new List<AbstractState>();
        /// <summary>��ǰ״̬</summary>
         public AbstractState nowState;
        /// <summary>Ĭ��״̬</summary>
        [HideInInspector] public AbstractState defaultState;


        /// <summary>��ע��Ŀ��</summary>
        public AbstractCharacter aim;
        /// <summary>�������������ڵ������з�����</summary>
        public SectorAttackSelector sectorSearch = new SectorAttackSelector();
        /// <summary>����</summary>
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
            //aim = FindAim();ÿ��һ��ʱ������Ѱ��Ŀ��+++++++++++++++++++++++++++++++++
        }
        /// <summary>
        /// Ѱ��Ŀ��
        /// </summary>
        public AbstractCharacter FindAim()
        {
            //����Ŀ��
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
        /// ״̬�л�
        /// </summary> 
        public void ChangeActiveState(StateID stateID)
        {
            nowState.Exit(this);
            nowState=allState.Find(p=>p.id == stateID);
            nowState.EnterState(this);
        }
    }

}
