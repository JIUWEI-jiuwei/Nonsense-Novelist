using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 回血
/// </summary>
class CureMode : AbstractSkillMode
{
    public void Awake()
    {
        skillModeID = 3;
        skillModeName = "回血";
    }
    public override void UseMode(AbstractCharacter useCharacter,float value, AbstractCharacter aimCharacter)
    {
        if (value > 0)
        {
            aimCharacter.hp += (int)value;
        }
    }
    /// <summary>
    /// 再次计算锁定的目标(低血量友方）
    /// </summary>
    /// <param name="character">施法者</param>
    /// <returns></returns>
    override public AbstractCharacter[] CalculateAgain(int attackDistance, AbstractCharacter character)
    {
        AbstractCharacter[] a = attackRange.CaculateRange(attackDistance, character.situation,NeedCampEnum.friend);
        
        CollectionHelper.OrderBy<AbstractCharacter, float>(a, p => p.GetComponent<AbstractCharacter>().hp);

        return a;
    }
}
