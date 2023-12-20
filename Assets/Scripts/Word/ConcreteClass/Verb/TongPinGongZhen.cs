using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 动词：同频共振
/// </summary>
class TongPinGongZhen: AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 8;
        wordName = "同频共振";
        bookName = BookNameEnum.CrystalEnergy;
        description = "使友方获得共振，持续30s";

        skillMode = gameObject.AddComponent<UpATKMode>();
        skillMode.attackRange = new SingleSelector();
        skillEffectsTime = 30;

        rarity = 2;
        needCD=2;

    }


    public override void UseVerb(AbstractCharacter useCharacter)
    {
        base.UseVerb(useCharacter);
        buffs.Add(skillMode.CalculateAgain(attackDistance, useCharacter)[0].gameObject.AddComponent<GongZhen>());
        buffs[0].maxTime = skillEffectsTime;
    }


    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return character.wordName + "用手在水晶上以慢速滑动，手掌与水晶的摩擦产生了一种具有规律的振动，"+character.wordName+"通过控制这股振动慢慢地积蓄力量，最终让整个山体都颤动了起来。";

    }

}
