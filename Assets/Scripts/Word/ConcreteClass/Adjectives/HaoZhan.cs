using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 形容词：好战的
/// </summary>
public class HaoZhan : AbstractAdjectives
{

    static public string s_description = "快速攻击，持续5s";
    static public string s_wordName = "好战的";
    public override void Awake()
    {        
        base.Awake();
        adjID = 18;
        wordName = "好战的";
        bookName = BookNameEnum.PHXTwist;
        description = "快速攻击，持续5s";

        skillMode = gameObject.AddComponent<SelfMode>();
        skillEffectsTime = 5;

        rarity = 0;

    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        BasicAbility(aimCharacter);
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
        aimCharacter.attackInterval -= 1.2f;
    }

    

    public override void End()
    {
        base.End();
        aim.attackInterval += 1.2f;
    }

}
