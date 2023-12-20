using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 形容词：人造的
/// </summary>
public class RenZao : AbstractAdjectives
{

    static public string s_description = "<sprite name=\"hpmax\">+20，获得<color=#dd7d0e>改造</color>";
    static public string s_wordName = "人造的";
    public override void Awake()
    {
        adjID = 12;
        wordName = "人造的";
        bookName = BookNameEnum.ElectronicGoal;
<<<<<<< HEAD
        description = "<sprite name=\"hpmax\">+20，获得<color=#dd7d0e>改造</color>";
=======
        description = "生命上限+20，获得改造";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
        skillMode = gameObject.AddComponent<CureMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 0;
        base.Awake();
    }
    override public string[] DetailLable()
    {
        string[] _s = new string[1];
        _s[0] = "GaiZao";
        return _s;
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        buffs.Add(aimCharacter.gameObject.AddComponent<GaiZao>());
        buffs[0] .maxTime = skillEffectsTime;
        BasicAbility(aimCharacter);
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
        aimCharacter.maxHp += 20;
    }

    

    public override void End()
    {
        base.End();
        aim.maxHp -= 20;
    }

}
