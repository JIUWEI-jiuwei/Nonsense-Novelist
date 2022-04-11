using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 摔
/// </summary>
class FallBadly : AbstractVerbs
{
    public FallBadly()
    {
        wordName = "摔";
        bookName = BookNameEnum.HongLouMeng;
        description = "将东西用力的摔向对方";
        nickname = "砸，甩，投掷";
        skillMode = new Damage();
        //技能强度搁置
        attackDistance = 6;
        skillTime = 0f;
        skillEffectsTime = 1.5f;
        comsumeSP = 0;
        prepareTime = 0.5f;
        afterTime = 0;
        allowInterrupt = false;
        possibility = 0;
    }
    public override void Ability()
    {

    }
}
