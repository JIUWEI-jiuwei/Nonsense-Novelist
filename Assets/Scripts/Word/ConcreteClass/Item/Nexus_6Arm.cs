using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///名词: Nexus-6型手臂
/// </summary>
class Nexus_6Arm : AbstractItems
{
<<<<<<< HEAD
    static public string s_description = "<sprite name=\"atk\">+5，获得<color=#dd7d0e>改造</color>*3";
    static public string s_wordName = "Nexus-6型手臂";
=======

>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
    public override void Awake()
    {
        base.Awake();
        itemID = 13;
        wordName = "Nexus-6型手臂";
        bookName = BookNameEnum.ElectronicGoal;
<<<<<<< HEAD
        description = "<sprite name=\"atk\">+5，获得<color=#dd7d0e>改造</color>*3";
=======
        description = "攻击+5，获得改造*3";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
        VoiceEnum = MaterialVoiceEnum.Meat;

        rarity = 3;
    }
    override public string[] DetailLable()
    {
        string[] _s = new string[1];
        _s[0] = "GaiZao";
        return _s;
    }

    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        chara.atk += 5;
        buffs.Add(gameObject.AddComponent<GaiZao>());
        buffs[0].maxTime = Mathf.Infinity;
    }

    public override void UseVerb()
    {
        base.UseVerb();
    }

    public override void End()
    {
        base.End();
        aim.atk -= 5;
    }
}
