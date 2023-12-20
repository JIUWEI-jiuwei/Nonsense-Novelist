using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 形容词：婚飞的
/// </summary>
public class HunFei : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        adjID = 17;
        wordName = "婚飞的";
        bookName = BookNameEnum.PHXTwist;
        description = "散射，获得虫卵，持续10s";

        skillMode = gameObject.AddComponent<CureMode>();

        skillEffectsTime = 10;
        rarity = 1;

        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
        {   
            wordCollisionShoots[0]=gameObject.AddComponent<SanShe>();
        }
           
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        //BasicAbility(aimCharacter);
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
        //aimCharacter.CreateFloatWord(
        //    skillMode.UseMode(null,30,aimCharacter)
        //    , FloatWordColor.heal, true);
    }

    

    public override void End()
    {
        base.End();
    }

}
