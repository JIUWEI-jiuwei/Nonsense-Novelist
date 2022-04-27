using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 场地
/// </summary>
class PlatformMode : AbstractSkillMode
{
    public void Awake()
    {
        skillModeID = 6;
        skillModeName = "场地魔法";
    }
    public override void UseMode(AbstractCharacter useCharacter, float value, AbstractCharacter aimCharacter)
    {

    }
    /// <summary>
    /// 全选（射程999）
    /// </summary>
    /// <param name="attackDistance">射程填0即可</param>
    /// <returns></returns>
    override public GameObject[] CalculateAgain(float attackDistance, GameObject character)
    {
        GameObject[] a = attackRange.AttackRange(999, character.transform, extra);
        return a;
    }
}
