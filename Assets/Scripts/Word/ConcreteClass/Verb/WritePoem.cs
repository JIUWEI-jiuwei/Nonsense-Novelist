using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 赋诗
/// </summary>
class WritePoem : AbstractVerbs
{
    public WritePoem ()
    {
        wordName = "赋诗";
        bookName = BookNameEnum.HongLouMeng;
        description = "吟诗作对，好不快活";
        nickname = "作诗";
        skillMode = new ChangeATKMode();
        //技能强度搁置
        attackDistance = 5;
        skillTime = 0;
        skillEffectsTime = 5;
        cd=0;
        maxCD=18;
        comsumeSP = 10;
        prepareTime = 2;
        afterTime = 0;
        allowInterrupt = true;
        possibility = 0;
    }

    public override void Ability()
    {
       
    }
}
