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
        public SingleSelector sectorSearch = new SingleSelector();
        /// <summary>����</summary>
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

            StartCoroutine(Every1Seconds());
            StartCoroutine(EveryZeroOne());
        }

        public void FixedUpdate()
        {
            nowState.Action(this);
        }
        IEnumerator EveryZeroOne()
        {
            while (true)
            {
                nowState.CheckTrigger(this);//����״̬
                yield return new WaitForSeconds(0.1f);
            }

        }
        IEnumerator Every1Seconds()
        {
            while (true)
            {
                aim = FindAim();//����Ѱ�Ҹ����ĵ���
                yield return new WaitForSeconds(1);
            }
        }
        /// <summary>
        /// Ѱ��Ŀ��
        /// </summary>
        public AbstractCharacter FindAim()
        {
            //����Ŀ��
            AbstractCharacter[] a = sectorSearch.CaculateRange(character.attackDistance, character.situation,NeedCampEnum.enemy);
            return a[0];
        }
        /// <summary>
        /// ״̬�л�
        /// </summary> 
        public void ChangeActiveState(StateID stateID)
        {
            nowState.Exit(this);
            nowState = allState.Find(p => p.id == stateID);
            nowState.EnterState(this);
        }
    }

}
