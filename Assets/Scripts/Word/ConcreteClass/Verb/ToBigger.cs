using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class ToBigger : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 16;
        wordName = "变大";
        bookName = BookNameEnum.allBooks;
        description = "学会心碎，造成150%精神力的魔法伤害，并让目标沮丧。";
        nickname.Add( "刺痛");
        skillMode = gameObject.AddComponent<SelfMode>();
        skillMode.attackRange = new SingleSelector();
        skillEffectsTime = Mathf.Infinity;
        rarity = 1;
        needCD=3;
    }

    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        SpecialAbility(useCharacter);
    }

    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        useCharacter.maxHP += 20;
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return character.wordName + "的心爱之人对其说：“闻君有两意，故来相决绝”，因而悲痛欲绝。";

    }

}
