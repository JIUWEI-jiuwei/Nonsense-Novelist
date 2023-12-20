using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 动词：摔
/// </summary>
class Shuai : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 15;
        wordName = "摔";
        bookName = BookNameEnum.allBooks;

        description = "使敌人晕眩3s";
        //nickname.Add("砸");
        //nickname.Add("甩");
        //nickname.Add("投掷");

        skillMode = gameObject.AddComponent<DamageMode>();
        //(skillMode as DamageMode).isPhysics = true;

        skillMode.attackRange = new SingleSelector();
        skillEffectsTime = 3f;

        rarity = 1;
        needCD=2;
    }

    public override void UseVerb(AbstractCharacter useCharacter)
    {
        base.UseVerb(useCharacter);
        buffs.Add(skillMode.CalculateAgain(attackDistance, useCharacter)[0].gameObject.AddComponent<Dizzy>());
        buffs[0].maxTime = skillEffectsTime;
        BasicAbility(useCharacter);
    }

    public override void BasicAbility(AbstractCharacter useCharacter)
    {
        //AbstractCharacter aim = skillMode.CalculateAgain(attackDistance, useCharacter)[0];
        //aim.CreateFloatWord(
        //skillMode.UseMode(useCharacter, useCharacter.atk*0.2f * (1 - aim.def / (aim.def + 20)), aim)
        //,FloatWordColor.physics,true);
    }
    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return  character.wordName + "胡乱捡起东西砸了出去。";

    }
}
