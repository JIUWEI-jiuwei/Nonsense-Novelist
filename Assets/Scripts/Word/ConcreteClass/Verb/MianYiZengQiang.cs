using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class MianYiZengQiang : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 12;
        wordName = "免疫增强";
        bookName = BookNameEnum.FluStudy;
        description = "使队友回血”";
        skillMode = gameObject.AddComponent<CureMode>();
        skillMode.attackRange =  new SingleSelector();
        skillEffectsTime = Mathf.Infinity;
        rarity = 2;
        needCD =3;

    }
    /// <summary>
    /// 复活
    /// </summary>
    /// <param name="useCharacter">施法者</param>
    public override void UseVerb(AbstractCharacter useCharacter)
    {
        base.UseVerb(useCharacter);
        BasicAbility(useCharacter);
    }

    public override void BasicAbility(AbstractCharacter useCharacter)
    {
       AbstractCharacter aim= skillMode.CalculateAgain(attackDistance,useCharacter)[0];
        aim.hp += 30;
        aim.maxHp += 20;
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        //if (character == null || aimState==null)
            //return null;

        return character.wordName + "拿起小刀，将腹部开出一个小缺口，并将香脂油灌满其中。再将树脂填入名字2的头颅，防止头部的变形。接下来将他整个埋于碱粉中一个月，这样就可以做到肉体不被腐朽所困扰了。";

    }
}
