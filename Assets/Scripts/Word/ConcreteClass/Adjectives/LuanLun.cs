using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 形容词：乱伦的
/// </summary>
public class LuanLun : AbstractAdjectives
{
    static public string s_description = "<color=#dd7d0e>俘获</color>一群角色，攻击队友7s";
    static public string s_wordName = "乱伦的";
    public override void Awake()
    {
        base.Awake();
        adjID = 8;
        wordName = "乱伦的";
        bookName = BookNameEnum.Salome;
<<<<<<< HEAD
        description = "<color=#dd7d0e>俘获</color>一群角色，攻击队友7s";
=======
        description = "俘获一群角色，攻击队友7s";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
        skillMode = gameObject.AddComponent<DamageMode>();
        skillEffectsTime =7;
        rarity = 1;

        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0] = gameObject.AddComponent<ChuanBoCollision>();

    }
    override public string[] DetailLable()
    {
        string[] _s = new string[2];
        _s[0] = "ChuanBoCollision";
        _s[1] = "FuHuo";
        return _s;
    }


    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        buffs.Add(aimCharacter.gameObject.AddComponent<FuHuo>());
            buffs[0].maxTime = skillEffectsTime;
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
    }

    

    public override void End()
    {
        base.End();
    }

}
