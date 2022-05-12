using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AI
{
    /// <summary>
    /// ����״̬
    /// </summary>
    class AttackState :AbstractState
    {

        override public void Awake()
        {
            base.Awake();
            id = StateID.attack;
            triggers.Add(gameObject.AddComponent<OutAttackTrigger>());  
            map.Add(TriggerID.OutAttack,StateID.walk);
            triggers.Add(gameObject.AddComponent<KilledAimTrigger>());
            map.Add(TriggerID.KilledAim, StateID.walk);

            attackA = gameObject.AddComponent<DamageMode>();//ƽA���˺�����
            attackA.attackRange = new SectorAttackSelector();
            
        }

        /// <summary>ƽAģʽ</summary>
        private AbstractSkillMode attackA;
        /// <summary>ƽA��ʱ�����ۼӣ�</summary>
        [HideInInspector]public float attackAtime;
        public override void Action(MyState0 myState)
        {
            attackA.extra = myState.character.attackAngle;

            attackAtime += Time.deltaTime;
            
            foreach(AbstractVerbs skill in myState.character.skills)
            {
                //�����������&&��Ŀ��,ʹ�ü���
                if(skill.CalculateCD()&& skill.skillMode.CalculateAgain(skill.attackDistance, myState.character.gameObject)!=null)
                {
                    skill.UseVerbs(myState.character); 
                }
            }
            //���û�м�����ʹ��&&ƽA��ȴ���
            if ( canA(myState) && attackAtime >= myState.character.attackInterval)
            {
                attackAtime = 0;
                if (myState.aim != null)
                {
                    attackA.UseMode(myState.character, myState.character.atk * (1 - myState.aim.san / (myState.aim.san + 20)), myState.aim);
                }
            }
        }
        /// <summary>
        /// �Ƿ���ƽA
        /// </summary>
        /// <returns></returns>
        private bool canA(MyState0 myState)
        {
            foreach (AbstractVerbs skill in myState.character.skills)
            {
                if (skill.isUsing)
                    return false;
            }
            return true;
        }


        public override void EnterState(MyState0 myState)
        {
            
        }

        public override void Exit(MyState0 myState)
        {
            
        }
    }

}