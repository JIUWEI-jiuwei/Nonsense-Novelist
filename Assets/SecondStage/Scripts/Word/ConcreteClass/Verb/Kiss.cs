using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class Kiss : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 7;
        wordName = "亲吻";
        bookName = BookNameEnum.Salome;
        description = "使敌人获得“俘虏”";
        skillMode = gameObject.AddComponent<DamageMode>();
        (skillMode as DamageMode).isPhysics = false;
        skillMode.attackRange =  new SingleSelector();
        skillEffectsTime = 10;
        rarity = 2;
        needCD = 6;

    }

    public override void UseVerb(AbstractCharacter useCharacter)
    {
        base.UseVerb(useCharacter);
        buffs.Add(skillMode.CalculateAgain(attackDistance, useCharacter)[0].gameObject.AddComponent<FuHuo>());
        buffs[0].maxTime = skillEffectsTime;
        BasicAbility(useCharacter);
    }

    public override void BasicAbility(AbstractCharacter useCharacter)
    {
        AbstractCharacter aim = skillMode.CalculateAgain(attackDistance, useCharacter)[0];
        aim.CreateFloatWord(
        skillMode.UseMode(useCharacter, useCharacter.psy * 2 * (1 - aim.san / (aim.san + 5)), aim)
        ,FloatWordColor.psychic,true);
    }
    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        //if (character == null || aimState==null)
            //return null;

        return character.wordName + "拿起小刀，将腹部开出一个小缺口，并将香脂油灌满其中。再将树脂填入名字2的头颅，防止头部的变形。接下来将他整个埋于碱粉中一个月，这样就可以做到肉体不被腐朽所困扰了。";

    }
}
