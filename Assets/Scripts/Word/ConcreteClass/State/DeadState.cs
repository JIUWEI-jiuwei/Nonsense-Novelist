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
        private UIManager uIManager;

        private void Start()
        {
            uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        }
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
            if (myState.character.camp == CampEnum.enemy&& UIManager.enemyParentF[uIManager.transAndCamera.guanQiaNum].transform.childCount <= 1)
            {
                if (uIManager.transAndCamera.guanQiaNum == 0)
                {
                    UIManager.charaTransAndCamera.BeginMove();
                    UIManager.nextQuanQia = true;
                    UIManager.WinEnd();
                    for (int i = 0; i < UIManager.enemyParentF[1].transform.childCount; i++)
                    {
                        UIManager.enemyParentF[1].transform.GetChild(i).gameObject.SetActive(true);
                    }
                }
                if(uIManager.transAndCamera.guanQiaNum == 1)
                {
                    UIManager.charaTransAndCamera.BeginMove();
                    UIManager.nextQuanQia = true;
                    UIManager.WinEnd();
                    for (int i = 0; i < UIManager.enemyParentF[2].transform.childCount; i++)
                    {
                        UIManager.enemyParentF[2].transform.GetChild(i).gameObject.SetActive(true);
                    }
                }
                if(uIManager.transAndCamera.guanQiaNum == 2)
                {
                    UIManager.WinEnd();
                }
            }
            else if (myState.character.camp == CampEnum.friend)
            {
                UIManager.LoseEnd();
            }
        }
        public override void Exit(MyState0 myState)
        {
            
        }
    }

}