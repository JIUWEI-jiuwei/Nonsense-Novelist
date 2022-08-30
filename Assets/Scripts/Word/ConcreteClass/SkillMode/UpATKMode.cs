using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 攻击力提升
/// </summary>
class UpATKMode : AbstractSkillMode
{
    public void Awake()
    {
        skillModeID = 2;
        skillModeName = "状态提升";
    }
    public override void UseMode(AbstractCharacter useCharacter, float value, AbstractCharacter aimCharacter)
    {
        aimCharacter.atk += value;

    }
    /// <summary>
    /// 再次计算锁定的目标
    /// </summary>
    /// <param name="character">施法者</param>
    /// <returns></returns>
    override public GameObject[] CalculateAgain(float attackDistance, GameObject character)
    {
        CampEnum camp = character.GetComponent<AbstractCharacter>().camp;
        GameObject[] a = base.CalculateAgain(attackDistance, character);
        if (a != null)
        {
                a = CollectionHelper.FindAll<GameObject>(a, p => p.GetComponent<AbstractCharacter>().camp == camp);
        }
        return a;
    }
}
