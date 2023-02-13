using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AI
{
    /// <summary>
    /// 攻击状态
    /// </summary>
    class AttackState :AbstractState
    {
        /// <summary>是否是物理伤害</summary>
        public bool isPhysics=true;
        override public void Awake()
        {
            base.Awake();
            id = StateID.attack;
            triggers.Add(gameObject.AddComponent<OutAttackTrigger>());  
            map.Add(TriggerID.OutAttack,StateID.idle);
            triggers.Add(gameObject.AddComponent<KilledAimTrigger>());
            map.Add(TriggerID.KilledAim, StateID.idle);

            attackA = gameObject.AddComponent<DamageMode>();//平A是伤害类型
            attackA.attackRange = new SingleSelector();

        }
        private void Update()
        {
           // print(attackA);
        }

        /// <summary>平A模式</summary>
        public AbstractSkillMode attackA;
        /// <summary>平A计时器（累加）</summary>
        [HideInInspector]public float attackAtime;
        public override void Action(MyState0 myState)
        {
            attackAtime += Time.deltaTime;
            
            foreach(AbstractVerbs skill in myState.character.skills)
            {
                //如果能量已满&&有目标,使用技能
                if(skill.CalculateCD()&& skill.skillMode.CalculateAgain(skill.attackDistance, myState.character)!=null)
                {
                    myState.character.charaAnim.Play(AnimEnum.attack);
                    skill.UseVerbs(myState.character); 
                }
            }
            //如果没有技能在使用&&平A冷却完毕
            if ( canA(myState) && attackAtime >= myState.character.attackInterval)
            {
                myState.character.AttackA();
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
                    attackA.UseMode(myState.character, myState.character.atk * (1 - myState.aim.def / (myState.aim.def + 20)), myState.aim);
                }
            }
        }

        /// <summary>
        /// 是否能平A（没有技能在使用）
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
            myState.character.charaAnim.Play(AnimEnum.attack);
        }

        public override void Exit(MyState0 myState)
        {
        }
    }

}