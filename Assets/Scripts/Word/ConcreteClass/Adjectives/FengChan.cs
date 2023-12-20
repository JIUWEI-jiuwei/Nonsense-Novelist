using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 形容词：丰产的
/// </summary>
public class FengChan : AbstractAdjectives
{
    static public string s_description = " < sprite name=\"hpmax\">+30";
    static public string s_wordName = "丰产的";
    public override void Awake()
    {
        
        adjID = 6;
        wordName = "丰产的";
        bookName = BookNameEnum.EgyptMyth;
<<<<<<< HEAD
        description = "<sprite name=\"hpmax\">+30";
=======
        description = "生命上限+30";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
        skillMode = gameObject.AddComponent<CureMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 1;
        
        base.Awake();
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
        {
            wordCollisionShoots[0] = gameObject.AddComponent<SanShe>();

        }
    }
    override public string[] DetailLable()
    {
        string[] _s = new string[1];
        _s[0] = "SanShe";
        return _s;
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        BasicAbility(aimCharacter);
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
        aimCharacter.maxHp += 30;

    }

    

    public override void End()
    {
        base.End();
        aim.maxHp -= 30;
    }

}
