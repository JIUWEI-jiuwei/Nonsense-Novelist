using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunQianMengYing : AbstractAdjectives
{
    public override void Awake()
    {
        adjID = 0;
        wordName = "魂牵梦萦的";
        bookName = BookNameEnum.Salome;
        description = "使角色获得“俘虏”，攻击队友";
        skillMode = gameObject.AddComponent<SelfMode>();
        skillEffectsTime = 15;
        rarity = 1;
        base.Awake();
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
