using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class CureMode : AbstractSkillMode
{
    public CureMode()
    {
        skillModeID = 1;
        skillModeName = "治疗技能";
    }
    public override void UseMode(int value, AbstractCharacter character)
    {
        character.hp += value;
    }
    /// <summary>
    /// 再次计算锁定的目标(低血量友方）
    /// </summary>
    /// <param name="character">施法者</param>
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
