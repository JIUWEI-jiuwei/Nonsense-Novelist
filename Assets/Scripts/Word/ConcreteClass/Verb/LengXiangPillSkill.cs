using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 冷香丸
/// </summary>
class LengXiangPillSkill : AbstractVerbs
{
    public LengXiangPillSkill()
    {
        skillID = 5;
        wordName = "冷香丸";
        bookName = BookNameEnum.HongLouMeng;
        banUse.Add(new Biology());
        skillMode = new CureMode();
        percentage = Mathf.Infinity;//回满(不用此变量）
        attackDistance = 2;
        skillTime = 0f;
        skillEffectsTime = 0;
        cd=maxCD=6;
        comsumeSP = 0;
        prepareTime = 0.5f;
        afterTime = 0;
        allowInterrupt = false;
        possibility = 0;
    }
    /// <summary>
    /// 回满血
    /// </summary>
    /// <param name="character">施法者</param>
    public override void UseVerbs(GameObject character)
    {
        base.UseVerbs(character);
        foreach (GameObject aim in aims)
        {
            aim.GetComponent<AbstractCharacter>().hp = aim.GetComponent<AbstractCharacter>().maxHP;
        }
    }
    /// <summary>
    /// 解除所有负面状态
    /// </summary>
    public override void Ability()
    {

    }
}
