using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuicklyGrowing : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        adjID = 16;
        wordName = "快速成长的";
        bookName = BookNameEnum.allBooks;
        skillMode = gameObject.AddComponent<CureMode>();
        skillEffectsTime = 3;
        rarity = 0;
        time = skillEffectsTime;
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
    }

    float time;
    protected override void Update()
    {
        base.Update();
        if (nowTime < time)
        {
            time--;
            if (aim != null)
                aim.hp += 10;
        }
    }

    public override void End()
    {
        base.End();
    }

}
