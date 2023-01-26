using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 同频共振
/// </summary>
class TongPinGongZhen: AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 8;
        wordName = "同频共振";
        bookName = BookNameEnum.CrystalEnergy;
        description = "学会同频共振，让附近的敌人晕眩1.5秒。";
        skillMode = gameObject.AddComponent<UpATKMode>();
        skillMode.attackRange = new SingleSelector();
        skillEffectsTime = 30;
        rarity = 2;
        needCD=2;
        description = "通过磁场的共振让周围的敌人晕眩。";
    }

    /// <summary>
    /// 让所有友军回复5点SP
    /// </summary>
    /// <param name="useCharacter">施法者</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
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
