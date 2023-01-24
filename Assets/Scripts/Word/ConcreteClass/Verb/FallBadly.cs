using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 摔
/// </summary>
class FallBadly : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.verb;
        skillID = 4;
        wordName = "摔";
        bookName = BookNameEnum.HongLouMeng;
        description = "学会摔，造成150%攻击力的伤害，晕眩1.5秒。";
        nickname.Add("砸");
        nickname.Add("甩");
        nickname.Add("投掷");
        skillMode = gameObject.AddComponent<DamageMode>();
        skillMode.attackRange = new SingleSelector();
        attackDistance = 6;
        skillTime = 0;
        skillEffectsTime = 1.5f;
        cd=0;
        maxCD=6;
        prepareTime = 0.5f;
        afterTime = 0;
    }

    /// <summary>
    /// 造成150%攻击力的伤害
    /// </summary>
    /// <param name="useCharacter">施法者</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        foreach (AbstractCharacter aim in aims)
        {
           skillMode.UseMode(useCharacter, useCharacter.atk  *(1-aim.def/(aim.def+20)), aim);
        }
        SpecialAbility(useCharacter);
    }
    /// <summary>
    /// 晕眩1.5秒
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        foreach(AbstractCharacter aim in aims)
        {
            aim.dizzyTime = skillEffectsTime;
            aim.AddBuff(5);
        }
    }
    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return  character.wordName + "胡乱捡起东西砸了出去。";

    }
}
