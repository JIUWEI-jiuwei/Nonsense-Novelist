using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouAnQuanGan : AbstractAdjectives
{
    public override void Awake()
    {
        adjID = 4;
        wordName = "有安全感的";
        bookName = BookNameEnum.ZooManual;
        description = "恢复+8，持续20s";
        skillMode = gameObject.AddComponent<SelfMode>();
        skillEffectsTime = 20;
        rarity = 1;

        base.Awake();

    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        BasicAbility(aimCharacter);
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
        //恢复加8
    }

    float time;
    
    protected override void Update()
    {
        base.Update();
      
    }

    public override void End()
    {
        base.End();
    
    }

}
