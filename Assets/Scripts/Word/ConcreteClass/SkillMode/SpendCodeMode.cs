using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ���Ľ��
/// </summary>
class SpendCodeMode : AbstractSkillMode
{
    public void Awake()
    {
        skillModeID = 5;
        skillModeName = "���Ľ��";
    }
    public override void UseMode(AbstractCharacter useCharacter, float value, AbstractCharacter aimCharacter)
    {
        
    }
    /// <summary>
    /// �ٴμ���������Ŀ��
    /// </summary>
    /// <param name="character">ʩ����</param>
    /// <returns></returns>
    override public GameObject[] CalculateAgain(float attackDistance, GameObject character)
    {
        CampEnum camp = character.GetComponent<AbstractCharacter>().camp;
        GameObject[] a = base.CalculateAgain(attackDistance, character);
        if (a != null)
        {
            if (camp == CampEnum.enemy)
            {
                a = CollectionHelper.FindAll<GameObject>(a, p => p.GetComponent<AbstractCharacter>().camp == CampEnum.friend);
            }
            else if (camp == CampEnum.friend)
            {
                a = CollectionHelper.FindAll<GameObject>(a, p => p.GetComponent<AbstractCharacter>().camp == CampEnum.enemy);
            }
        }
        return a;
    }
}
