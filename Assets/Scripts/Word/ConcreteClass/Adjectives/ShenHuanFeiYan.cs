using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShenHuanFeiYan : AbstractAdjectives
{
    static public string s_description = "<color=#dd7d0e>����</color>������20s";
    static public string s_wordName = "�����׵�";

    public override void Awake()
    {
        adjID = 13;
        wordName = "�����׵�";
        bookName = BookNameEnum.FluStudy;
<<<<<<< HEAD
        description = "<color=#dd7d0e>����</color>������20s";
=======
        description = "����������20s";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
        skillMode = gameObject.AddComponent<DamageMode>();

        skillEffectsTime = 20;
        rarity = 1;
        base.Awake();
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0] = gameObject.AddComponent<ChuanBoCollision>();
    }

    override public string[] DetailLable()
    {
        string[] _s = new string[2];
        _s[0] = "ChuanBoCollision";
        _s[1] = "HuanBing";
        return _s;
    }
    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        ////���ĵõ�����
        //buffs.Add(aimCharacter.gameObject.AddComponent<ChuanBo>());
        ////���ڵõ�����
        //AbstractCharacter[] neighbors = (buffs[0] as ChuanBo).GetNeighbor(aimCharacter);
        //foreach (AbstractCharacter n in neighbors)
        //{
        //    buffs.Add(n.gameObject.AddComponent<Ill>());
        //}
        ////���ĵõ�����
        buffs.Add(aimCharacter.gameObject.AddComponent<HuanBing>());
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
