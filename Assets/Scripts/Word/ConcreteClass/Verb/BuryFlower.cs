using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 葬花
/// </summary>
class BuryFlower : AbstractVerbs
{
    public BuryFlower()
    {
        wordName = "葬花";
        bookName = BookNameEnum.HongLouMeng;
        description = "……";
        nickname = "平生葬花杀人，我以落花剑葬你，不枉你异人之名。";
        skillMode = new StatusUp();
        //技能强度搁置
        attackDistance = 0;
        skillTime = 7;
        skillEffectsTime = 0;
        cd=0;
        maxCD=40;
        comsumeSP = 15;
        prepareTime = 1f;
        afterTime = 0;
        allowInterrupt = true;
        possibility = 0;
    }
    public override void Ability()
    {

    }
}
