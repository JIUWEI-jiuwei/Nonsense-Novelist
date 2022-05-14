using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 冷香丸
/// </summary>
class LengXiangPillSkill : AbstractVerbs
{
    public void Awake()
    {
        skillID = 5;
        wordName = "冷香丸";
        bookName = BookNameEnum.HongLouMeng;
        banUse.Add(gameObject.AddComponent<Biology>());
        skillMode = gameObject.AddComponent<CureMode>();
        skillMode.attackRange = new CircleAttackSelector();//
        percentage = Mathf.Infinity;//回满(不用此变量）
        attackDistance = 2;
        skillTime = 0;
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
    /// <param name="useCharacter">施法者</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        foreach (GameObject aim in aims)
        {
            AbstractCharacter aimState= aim.GetComponent<AbstractCharacter>();
            aimState.hp = aimState.maxHP;
        }
        SpecialAbility(useCharacter);
    }
    /// <summary>
    /// 解除所有负面状态
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        useCharacter.dizzyTime = 0;
    }

    Dictionary<string, int> a;
    
}
