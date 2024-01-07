using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XinShenJiDang : AbstractAdjectives,IChongNeng
{
    private int psyAdd;

    public override void Awake()
    {
        adjID = 10;
        wordName = "心神激荡的";
        bookName = BookNameEnum.Salome;
        description = "获得精神，攻击精神交换（颠倒）";
        skillMode = gameObject.AddComponent<SelfMode>();
        skillEffectsTime = 10;
        rarity = 2;
        base.Awake();
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0] = gameObject.AddComponent<ChongNeng>();
    }
    public void ChongNeng(int times)
    {
        psyAdd += 5*times;
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        buffs.Add(aimCharacter.gameObject.AddComponent<DianDao>());
        buffs[0].maxTime = skillEffectsTime;
        BasicAbility(aimCharacter);

    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
        aimCharacter.psy += psyAdd;
    }

    public override void End()
    {
        aim.psy -= psyAdd;
        base.End();
    }
    
}
