using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 消耗金币
/// </summary>
class SpendCodeMode : AbstractSkillMode
{
    public void Awake()
    {
        skillModeID = 5;
        skillModeName = "消耗金币";
    }
    public override void UseMode(int value, AbstractCharacter character)
    {
        character.hp -= value - (int)(character.def * 0.6f);
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
