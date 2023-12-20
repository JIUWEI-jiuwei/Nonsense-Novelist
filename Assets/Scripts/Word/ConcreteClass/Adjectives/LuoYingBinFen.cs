using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ���ݴʣ���Ӣ�ͷ׵�
/// </summary>
public class LuoYingBinFen : AbstractAdjectives
{
    public override void Awake()
    {
        adjID = 21;
        wordName = "��Ӣ�ͷ׵�";
        bookName = BookNameEnum.allBooks;
        description = "��û���";
        skillMode = gameObject.AddComponent<DamageMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 0;
        base.Awake();

        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0] = gameObject.AddComponent<SanShe>();
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
