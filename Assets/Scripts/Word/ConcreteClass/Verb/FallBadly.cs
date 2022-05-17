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
        description = "将东西用力的摔向对方";
        nickname.Add("砸");
        nickname.Add("甩");
        nickname.Add("投掷");
        skillMode = gameObject.AddComponent<DamageMode>();
        skillMode.attackRange =new CircleAttackSelector();//
        percentage = 1.5f;
        attackDistance = 6;
        skillTime = 0;
        skillEffectsTime = 1.5f;
        cd=0;
        maxCD=6;
        comsumeSP = 0;
        prepareTime = 0.5f;
        afterTime = 0;
        allowInterrupt = false;
        possibility = 0;
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
    /// 晕眩1.5秒
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
    public override string PlaySentence()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return  character.wordName + "胡乱捡起东西砸了出去。";

    }
}
