using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 杂耍火球
/// </summary>
class FireBall : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.verb;
        skillID = 10;
        wordName = "杂耍火球";
        bookName = BookNameEnum.StudentOfWitch;
        description = "学会杂耍火球，造成150%精神力的伤害，晕眩0.3秒。";
        skillMode = gameObject.AddComponent<DamageMode>();
        skillMode.attackRange =new CircleAttackSelector();//
        percentage = 1.5f;
        attackDistance = 999;
        skillTime = 0;
        skillEffectsTime = 0.3f;
        cd=0;
        maxCD=5;
        comsumeSP = 5;
        prepareTime = 0.5f;
        afterTime = 0;
        allowInterrupt = false;
        possibility = 0;
        description = "花哨且伤害不俗的杂技把戏。";
    }

    private AbstractCharacter aimState;//目标的抽象角色类
    /// <summary>
    /// 造成150%攻击力的伤害
    /// </summary>
    /// <param name="useCharacter">施法者</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        foreach (GameObject aim in aims)
        {
            aimState = aim.GetComponent<AbstractCharacter>();
           skillMode.UseMode(useCharacter, useCharacter.atk * percentage *(1-aimState.def/(aimState.def+20)), aimState);
        }
        SpecialAbility(useCharacter);
    }
    /// <summary>
    /// 晕眩0.3秒
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        foreach(GameObject aim in aims)
        {
            AbstractCharacter a = aim.GetComponent<AbstractCharacter>();
            a.dizzyTime = skillEffectsTime;
            a.AddBuff(5);
        }
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null || aimState==null)
            return null;

        return character.wordName + "动了动手指，几个火球伴随着低声吟唱的咒语从之间跃出，以花哨的动作旋转着并朝"+aimState.wordName+"冲了过去。";

    }
}
