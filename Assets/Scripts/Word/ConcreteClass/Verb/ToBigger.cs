using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 动词：变大
/// </summary>
class ToBigger : AbstractVerbs
{
    static public string s_description = "<sprite name=\"hpmax\">+20";
    static public string s_wordName = "变大";
    public override void Awake()
    {
        base.Awake();
        skillID = 16;
        wordName = "变大";
        bookName = BookNameEnum.allBooks;
<<<<<<< HEAD
        description = " <sprite name=\"hpmax\">+20";
=======
        description = "生命上限+20";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
       // nickname.Add( "刺痛");

        skillMode = gameObject.AddComponent<SelfMode>();
        skillMode.attackRange = new SingleSelector();
        skillEffectsTime = Mathf.Infinity;

        rarity = 1;
        needCD=3;
    }

    public override void UseVerb(AbstractCharacter useCharacter)
    {
        base.UseVerb(useCharacter);
        BasicAbility(useCharacter);
    }

    public override void BasicAbility(AbstractCharacter useCharacter)
    {
        useCharacter.maxHp += 20;
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return character.wordName + "的心爱之人对其说：“闻君有两意，故来相决绝”，因而悲痛欲绝。";

    }

}
