using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 动词：赋诗
/// </summary>
class WritePoem : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 1;
        wordName = "赋诗";
        bookName = BookNameEnum.HongLouMeng;
        description = "使友方获得诗情，持续10s";

       // nickname.Add("作诗");
       
        skillMode = gameObject.AddComponent<UpPSYMode>();

        skillEffectsTime = 10;
        rarity = 1;
        needCD=4;
    }


    public override void UseVerb(AbstractCharacter useCharacter)
    {
        base.UseVerb(useCharacter);
        //优先四维之和最高的
        buffs.Add(skillMode.CalculateAgain(attackDistance, useCharacter)[0].gameObject.AddComponent<ShiQing>());
        buffs[0].maxTime = skillEffectsTime;
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return character.wordName + "被身边的美景所震撼，不由得诗性大发，颂唱起了诗歌“登山则情满于山，观海则情溢于海，吟咏之间，吐纳珠玉之声”。";

    }
}
