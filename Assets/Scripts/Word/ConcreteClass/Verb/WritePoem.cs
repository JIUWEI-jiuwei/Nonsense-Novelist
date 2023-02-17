using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 赋诗
/// </summary>
class WritePoem : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 1;
        wordName = "赋诗";
        bookName = BookNameEnum.HongLouMeng;
        description = "";
        nickname.Add("作诗");
        skillMode = gameObject.AddComponent<UpPSYMode>();
        skillEffectsTime = 7;
        rarity = 1;
        needCD=4;
    }


    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
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
