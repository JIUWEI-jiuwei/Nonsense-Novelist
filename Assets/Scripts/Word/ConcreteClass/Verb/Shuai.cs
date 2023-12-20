using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 动词：摔
/// </summary>
class Shuai : AbstractVerbs
{
    static public string s_description = "使敌人<color=#dd7d0e>晕眩</color>3s";
    static public string s_wordName = "摔";
    public override void Awake()
    {
        base.Awake();
        skillID = 15;
        wordName = "摔";
        bookName = BookNameEnum.allBooks;

<<<<<<< HEAD
        description = "使敌人<color=#dd7d0e>晕眩</color>3s";
=======
        description = "使敌人晕眩3s";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
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
    override public string[] DetailLable()
    {
        string[] _s = new string[1];
        _s[0] = "Dizzy";
        return _s;
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
