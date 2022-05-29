using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AI
{
    /// <summary>
    /// 死亡状态
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
            //播放完动画后销毁
            Destroy(this.gameObject);
        }
        public override void EnterState(MyState0 myState)
        {
            myState.character.charaAnim.Play(AnimEnum.dead);
            if (myState.character.camp == CampEnum.enemy&& UIManager.enemyParentF[0].transform.childCount <= 1)
            {
                UIManager.charaTransAndCamera.BeginMove();
                UIManager.nextQuanQia = true;
                UIManager.WinEnd();
                for(int i=0;i< UIManager.enemyParentF[1].transform.childCount; i++)
                {
                    UIManager.enemyParentF[1].transform.GetChild(i).gameObject.SetActive(true);
                }
            }
            else if (myState.character.camp == CampEnum.enemy&& UIManager.enemyParentF[1].transform.childCount <= 1)
            {
                UIManager.charaTransAndCamera.BeginMove();
                UIManager.nextQuanQia = true;
                UIManager.WinEnd();
                for (int i = 0; i < UIManager.enemyParentF[2].transform.childCount; i++)
                {
                    UIManager.enemyParentF[2].transform.GetChild(i).gameObject.SetActive(true);
                }
            }
            else if (myState.character.camp == CampEnum.enemy&& UIManager.enemyParentF[2].transform.childCount <= 1)
            {
                UIManager.charaTransAndCamera.BeginMove();
                UIManager.nextQuanQia = true;
                UIManager.WinEnd();
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