using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///名词: Nexus-6型手臂
/// </summary>
class Nexus_6Arm : AbstractItems
{

    public override void Awake()
    {
        base.Awake();
        itemID = 13;
        wordName = "Nexus-6型手臂";
        bookName = BookNameEnum.ElectronicGoal;
        description = "攻击+5，获得改造*3";
        VoiceEnum = MaterialVoiceEnum.Meat;

        rarity = 3;
    }

    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        chara.atk += 5;
        buffs.Add(gameObject.AddComponent<GaiZao>());
        buffs[0].maxTime = Mathf.Infinity;
    }

    public override void UseVerb()
    {
        base.UseVerb();
    }

    public override void End()
    {
        base.End();
        aim.atk -= 5;
    }
}
