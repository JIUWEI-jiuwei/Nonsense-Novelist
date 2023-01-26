using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouAnQuanGan : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        adjID = 8;
        wordName = "有安全感的";
        bookName = BookNameEnum.ZooManual;
        skillMode = gameObject.AddComponent<SelfMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 1;
        time = skillEffectsTime;
    }

    public override void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        SpecialAbility(aimCharacter);
    }
    public override void SpecialAbility(AbstractCharacter aimCharacter)
    {
        
    }

    float time;
    
    protected override void Update()
    {
        base.Update();
        if(nowTime<time)
        {
            time--;
            if (aim != null)
                aim.hp += 5;
        }
    }

    public override void End()
    {
        base.End();
        aim.reLifes--;
    }

}
