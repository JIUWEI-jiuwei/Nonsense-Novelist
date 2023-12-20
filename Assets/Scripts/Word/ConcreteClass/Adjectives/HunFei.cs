using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 形容词：婚飞的
/// </summary>
public class HunFei : AbstractAdjectives
{

    static public string s_description = "散射，获得<color=#dd7d0e>虫卵</color>，持续10s";
    static public string s_wordName = "婚飞的";

    public override void Awake()
    {
        base.Awake();
        adjID = 17;
        wordName = "婚飞的";
        bookName = BookNameEnum.PHXTwist;
<<<<<<< HEAD
        description = "散射，获得<color=#dd7d0e>虫卵</color>，持续10s";
=======
        description = "散射，获得虫卵，持续10s";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454

        skillMode = gameObject.AddComponent<CureMode>();

        skillEffectsTime = 10;
        rarity = 1;

        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
        {   
            wordCollisionShoots[0]=gameObject.AddComponent<SanShe>();
        }
           
<<<<<<< HEAD
    }
    override public string[] DetailLable()
    {
        string[] _s = new string[2];
        _s[0] = "SanShe";
        _s[1] = "SanShe";
        return _s;
=======
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
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
