using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ChangeDEFMode : AbstractSkillMode
{
    public ChangeDEFMode()
    {
        skillModeID = 4;
        skillModeName = "ÌáÉý·ÀÓù";
    }
    public override void UseMode(int value, AbstractCharacter character)
    {
        character.def+=value;   
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
