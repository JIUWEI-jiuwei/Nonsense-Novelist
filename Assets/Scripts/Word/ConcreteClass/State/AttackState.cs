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
            map.Add(TriggerID.OutAttack,StateID.idle);
            triggers.Add(gameObject.AddComponent<KilledAimTrigger>());
            map.Add(TriggerID.KilledAim, StateID.idle);

            attackA = gameObject.AddComponent<DamageMode>();//ƽA���˺�����
            attackA.attackRange = new SingleSelector();

        }

        /// <summary>ƽAģʽ</summary>
        private AbstractSkillMode attackA;
        /// <summary>ƽA��ʱ�����ۼӣ�</summary>
        [HideInInspector]public float attackAtime;
        public override void Action(MyState0 myState)
        {
            attackA.extra = myState.character.attackAngle;

            attackAtime += Time.deltaTime;
            
            foreach(AbstractVerbs skill in myState.character.realSkills)
            {
                //�����������&&��Ŀ��,ʹ�ü���
                if(skill.CalculateCD()&& skill.skillMode.CalculateAgain(skill.attackDistance, myState.character)!=null)
                {
                    myState.character.charaAnim.Play(AnimEnum.attack);
                    skill.UseVerbs(myState.character); 
                }
            }
            //���û�м�����ʹ��&&ƽA��ȴ���
            if ( canA(myState) && attackAtime >= myState.character.attackInterval)
            {
                myState.character.CreateBullet(myState.aim.gameObject);
                attackAtime = 0;
                if (myState.aim != null)
                {
                    if (myState.character.aAttackAudio != null)
                    {
                        myState.character.source.clip = myState.character.aAttackAudio;
                        myState.character.source.Play();
                    }
                    myState.character.charaAnim.Play(AnimEnum.attack);
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
            foreach (AbstractVerbs skill in myState.character.realSkills)
            {
                if (!skill.isUsing)
                    return true;
            }
            return true;
        }


        public override void EnterState(MyState0 myState)
        {
            myState.character.charaAnim.Play(AnimEnum.attack);
        }

        public override void Exit(MyState0 myState)
        {
        }
    }

}