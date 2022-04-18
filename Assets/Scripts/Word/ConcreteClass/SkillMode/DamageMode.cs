using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �˺�����
/// </summary>
class DamageMode : AbstractSkillMode
{
   public DamageMode()
    {
        skillModeID = 2;
        skillModeName = "�˺�����";
    }
    public override void UseMode(int value, AbstractCharacter character)
    {
        character.hp-=value-(int)(character.def*0.6f);
        
    }
     /// <summary>
    /// �ٴμ���������Ŀ��
    /// </summary>
    /// <param name="character">ʹ����λ��</param>
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
