using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 摔
/// </summary>
class FallBadly : AbstractVerbs
{
    public void Awake()
    {
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
        skillTime = 0f;
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
    /// <param name="character">施法者</param>
    public override void UseVerbs(AbstractCharacter character)
    {
        base.UseVerbs(character);
        foreach (GameObject aim in aims)
        {
            aimState = aim.GetComponent<AbstractCharacter>();
           skillMode.UseMode(character, character.atk * percentage *(1-aimState.def/(aimState.def+20)), aimState);
        }
        SpecialAbility();
    }
    /// <summary>
    /// 晕眩1.5秒
    /// </summary>
    public override void SpecialAbility()
    {

    }
}
