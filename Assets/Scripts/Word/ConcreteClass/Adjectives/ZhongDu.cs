using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class ZhongDu : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        adjID = 20;
        wordName = "ÖÐ¶¾µÄ";
        bookName = BookNameEnum.allBooks;
        skillMode = gameObject.AddComponent<DamageMode>();
        skillEffectsTime = 10;
        rarity = 2;
    }

    public override void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        buffs.Add(aimCharacter.gameObject.AddComponent<Toxic>());
        buffs.Add(aimCharacter.gameObject.AddComponent<DianDao>());
        foreach(AbstractBuff buff in buffs)
        {
            buff.maxTime = skillEffectsTime;
        }
        
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
    }

    

    public override void End()
    {
        base.End();
    }

}
