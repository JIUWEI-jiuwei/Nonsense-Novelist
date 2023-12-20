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
        }

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
<<<<<<< HEAD
                    print("使用技能：" + skill.wordName);
=======
                    print("使用技能消耗为" + skill.CalculateCD() + "的技能：" + skill.wordName);
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
                    myState.character.charaAnim.Play(AnimEnum.attack);
                    skill.UseVerb(myState.character); 
                }
            }
            //如果没有技能在使用&&平A冷却完毕
            if ( canA(myState) && attackAtime >= myState.character.attackInterval)
            {
                if (myState.character.AttackA())
                    
                    attackAtime = 0;
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
                    //tt：策划的意思是动词和平A能同时用？
                     //return true;
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