using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 攻击力改变
/// </summary>
class ChangeATKMode : AbstractSkillMode
{
    public void Awake()
    {
        skillModeID = 3;
        skillModeName = "提升攻击";
    }
    public override void UseMode(int value, AbstractCharacter character)
    {
        character.atk += value;

    }
    /// <summary>
    /// 再次计算锁定的目标
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
        return a;
    }
}
