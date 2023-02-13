using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XinShenJiDang : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        adjID = 10;
        wordName = "ÐÄÉñ¼¤µ´µÄ";
        bookName = BookNameEnum.Salome;
        skillMode = gameObject.AddComponent<SelfMode>();
        skillEffectsTime = 10;
        rarity = 2;
        wordCollisionShoots.Add(gameObject.AddComponent<ChongNeng>());
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        buffs.Add(aimCharacter.gameObject.AddComponent<DianDao>());
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
