using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ���ݴʣ���Ӣ�ͷ׵�
/// </summary>
public class LuoYingBinFen : AbstractAdjectives
{

    static public string s_description = "���<color=#dd7d0e>����</color>";
    static public string s_wordName = "��Ӣ�ͷ׵�";
    public override void Awake()
    {
        adjID = 21;
        wordName = "��Ӣ�ͷ׵�";
        bookName = BookNameEnum.allBooks;
<<<<<<< HEAD
        description = "���<color=#dd7d0e>����</color>";
=======
        description = "��û���";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
        skillMode = gameObject.AddComponent<DamageMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 0;
        base.Awake();

        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0] = gameObject.AddComponent<SanShe>();
<<<<<<< HEAD
    }
    override public string[] DetailLable()
    {
        string[] _s = new string[2];
        _s[0] = "SanShe";
        _s[1] = "HuaBan";
        return _s;
=======
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        buffs.Add(aimCharacter.gameObject.AddComponent<HuaBan>());
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
