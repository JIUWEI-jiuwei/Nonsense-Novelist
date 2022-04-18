using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ChangeATKMode : AbstractSkillMode
{
    public ChangeATKMode()
    {
        skillModeID = 3;
        skillModeName = "ÌáÉý¹¥»÷";
    }
    public override void UseMode(int value, AbstractCharacter character)
    {
        character.atk+=value;
        
    }
    /// <summary>
    /// ?????????
    /// </summary>
    /// <param name="character">?????</param>
    /// <returns></returns>
    override public GameObject[] CaculateAgain(float attackDistance,Transform ownTrans,CampEnum camp)
    {
        GameObject[] a=attackRange.AttackRange(attackDistance,ownTrans,extra);
        if(a!=null)
        {
        if(CampEnum.friend){
            a=CollectionHelper.FindAll<GameObject>(a,p=> p.GetComponent<AbstractCharacter>.CampEnum==CampEnum.friend);
        }
        else if(CampEnum.enemy){
            a=CollectionHelper.FindAll<GameObject>(a,p=>p.GetComponent<AbstractCharacter>.CampEnum==CampEnum.enemy);
        } 
        }
        return a;
    }
}
