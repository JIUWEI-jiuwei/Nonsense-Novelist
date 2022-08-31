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
        attackRange = new SingleSelector();
    }
    public override void UseMode(AbstractCharacter useCharacter, float value, AbstractCharacter aimCharacter)
    {

    }
    /// <summary>
    /// 全选（射程999）
    /// </summary>
    /// <param name="attackDistance"></param>
    /// <returns></returns>
    override public AbstractCharacter[] CalculateAgain(int attackDistance, AbstractCharacter character)
    {
        AbstractCharacter[] a = attackRange.CaculateRange(attackDistance, character.situation, NeedCampEnum.all);
        return a;
    }
}
