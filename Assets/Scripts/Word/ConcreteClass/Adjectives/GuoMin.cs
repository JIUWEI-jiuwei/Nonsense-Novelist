using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 形容词：过敏的
/// </summary>
public class GuoMin : AbstractAdjectives,IChongNeng
{
    private float dizzyAdd;

    public override void Awake()
    {        
        base.Awake();
        adjID = 14;
        wordName = "过敏的";
        bookName = BookNameEnum.FluStudy;
        description = "充能，每次弹射“晕眩”0.5s”";

        skillMode = gameObject.AddComponent<SelfMode>();

        skillEffectsTime = 0;
        rarity = 1;


        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0] = gameObject.AddComponent<ChongNeng>();
    }
    public void ChongNeng(int times)
    {
        dizzyAdd += 0.5f*times;
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);

        buffs.Add(aimCharacter.gameObject.AddComponent<Dizzy>());
        buffs[0].maxTime = skillEffectsTime + dizzyAdd;
        
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
    }
    

    public override void End()
    {
        base.End();
    }

    
}
