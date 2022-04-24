using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class CureMode : AbstractSkillMode
{
    public void Awake()
    {
        skillModeID = 1;
        skillModeName = "���Ƽ���";
    }
    public override void UseMode(int value, AbstractCharacter character)
    {
        character.hp += value;
    }
    /// <summary>
    /// �ٴμ���������Ŀ��(��Ѫ���ѷ���
    /// </summary>
    /// <param name="character">ʩ����</param>
    /// <returns></returns>
    override public GameObject[] CalculateAgain(float attackDistance, GameObject character)
    {
        CampEnum camp = character.GetComponent<AbstractCharacter>().camp;
        GameObject[] a = attackRange.AttackRange(attackDistance, character.transform, extra);
        if (a != null)
        {
            if (camp == CampEnum.friend)
            {
                a = CollectionHelper.FindAll<GameObject>(a, p => p.GetComponent<AbstractCharacter>().camp == CampEnum.friend);
            }
            else if (camp == CampEnum.enemy)
            {
                a = CollectionHelper.FindAll<GameObject>(a, p => p.GetComponent<AbstractCharacter>().camp == CampEnum.enemy);
            }
        }
        CollectionHelper.OrderBy<GameObject, int>(a, p => p.GetComponent<AbstractCharacter>().hp);

        return a;
    }
}
