using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 心碎
/// </summary>
class HeartBroken : AbstractVerbs
{
    public HeartBroken()
    {
        wordName = "心碎";
        bookName = BookNameEnum.allBooks;
        description = "令目标心如刀绞。";
        nickname = "刺痛";
        skillMode = new Damage();
        //技能强度搁置
        attackDistance = Mathf.Infinity;
        skillTime = 0;
        skillEffectsTime = 3;
        cd=0;
        maxCD=5;
        comsumeSP = 5;
        prepareTime = 0.5f;
        afterTime = 1;
        allowInterrupt = false;
        possibility = 0;
    }
    public override void Ability()
    {
        
    }
}
