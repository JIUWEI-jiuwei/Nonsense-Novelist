using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���ݴʣ���ǣ���ӵ�
/// </summary>
public class HunQianMengYing : AbstractAdjectives
{
    static public string s_description = "<color=#dd7d0e>����</color>��ɫ����������7s";
    static public string s_wordName = "��ǣ���ӵ�";

    public override void Awake()
    {
        adjID = 0;
        wordName = "��ǣ���ӵ�";
        bookName = BookNameEnum.Salome;
<<<<<<< HEAD
        description = "<color=#dd7d0e>����</color>��ɫ����������7s";
=======
        description = "�����ɫ����������7s";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454

        skillMode = gameObject.AddComponent<DamageMode>();

        skillEffectsTime = 7;
        rarity = 0;
        base.Awake();
    }
    override public string[] DetailLable()
    {
        string[] _s = new string[1];
        _s[0] = "FuHuo";
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
