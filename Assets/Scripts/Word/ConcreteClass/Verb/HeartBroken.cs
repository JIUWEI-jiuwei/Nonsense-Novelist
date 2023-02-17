using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 心碎
/// </summary>
class HeartBroken : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 14;
        wordName = "心碎";
        bookName = BookNameEnum.allBooks;
        description = "使敌人获得“沮丧”";
        nickname.Add( "刺痛");
        skillMode = gameObject.AddComponent<SelfMode>();
        skillMode.attackRange = new SingleSelector();
        skillEffectsTime = 2;
        rarity = 1;
        needCD=2;
    }

    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        buffs.Add(gameObject.AddComponent<Upset>());
        buffs[0].maxTime = skillEffectsTime;
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return character.wordName + "的心爱之人对其说：“闻君有两意，故来相决绝”，因而悲痛欲绝。";

    }

}
