using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 防腐术
/// </summary>
class FangFuShu : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 5;
        wordName = "防腐";
        bookName = BookNameEnum.EgyptMyth;
        description = "使队友获得“复活”";
        skillMode = gameObject.AddComponent<CureMode>();
        skillMode.attackRange =  new SingleSelector();
        skillEffectsTime = 20;
        rarity = 1;
        needCD = 10;
        description = "通过复杂的工序，让肉体不会腐败，再次获得生存的机会。";

    }
    /// <summary>
    /// 复活
    /// </summary>
    /// <param name="useCharacter">施法者</param>
    public override void UseVerb(AbstractCharacter useCharacter)
    {
        base.UseVerb(useCharacter);
        buffs.Add(skillMode.CalculateAgain(attackDistance, useCharacter)[0].gameObject.AddComponent<ReLife>());
        buffs[0].maxTime = skillEffectsTime;
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        //if (character == null || aimState==null)
            //return null;

        return character.wordName + "拿起小刀，将腹部开出一个小缺口，并将香脂油灌满其中。再将树脂填入名字2的头颅，防止头部的变形。接下来将他整个埋于碱粉中一个月，这样就可以做到肉体不被腐朽所困扰了。";

    }
}
