using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 伤害技能
/// </summary>
class DamageMode : AbstractSkillMode
{
   public DamageMode()
    {
        skillModeID = 2;
        skillModeName = "伤害技能";
    }
    public override void UseMode(int value, AbstractCharacter character)
    {
        character.hp-=value-(int)(character.def*0.6f);
        
    }
     /// <summary>
    /// 再次计算锁定的目标
    /// </summary>
    /// <param name="character">使用者位置</param>
    /// <returns></returns>
    override public GameObject[] CaculateAgain(float attackDistance,Transform ownTrans,CampEnum camp)
    {
        GameObject[] a=attackRange.AttackRange(attackDistance,ownTrans,extra);
        if(a!=null)
        {
        if(CampEnum.enemy){
            a=CollectionHelper.FindAll<GameObject>(a,p=> p.GetComponent<AbstractCharacter>.CampEnum==CampEnum.friend);
        }
        else if(CampEnum.friend){
            a=CollectionHelper.FindAll<GameObject>(a,p=>p.GetComponent<AbstractCharacter>.CampEnum==CampEnum.enemy);
        }
        }
        return a;
    }
}
