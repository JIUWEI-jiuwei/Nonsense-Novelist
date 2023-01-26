using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class CHOOHShoot : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 13;
        wordName = "蚁酸喷射";
        bookName = BookNameEnum.PHXTwist;
        description = "学会蚁酸喷射，造成150%攻击力的伤害，减少2点防御力。";
        skillMode = gameObject.AddComponent<DamageMode>();
        (skillMode as DamageMode).isPhysics= true;
        skillMode.attackRange = new SingleSelector();
        skillEffectsTime = 12;
        rarity = 1;
        needCD = 1;
        description = "以全力将毒腺挤压，喷射出的毒液可以腐蚀护甲。";
    }


    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        buffs.Add(skillMode.CalculateAgain(attackDistance, useCharacter)[0].gameObject.AddComponent<FuShi>());
        buffs[0].maxTime = skillEffectsTime;
        SpecialAbility(useCharacter);
    }

    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        AbstractCharacter aim = skillMode.CalculateAgain(attackDistance, useCharacter)[0];
        skillMode.UseMode(useCharacter, useCharacter.atk*0.25f * (1 - aim.def / (aim.def + 20)), aim);
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return character.wordName + "鼓动着自己腹部的腺体，突然收缩腹部，喷射出了一道酸性的液体，正好命中了名字2的脸部。";

    }
}
