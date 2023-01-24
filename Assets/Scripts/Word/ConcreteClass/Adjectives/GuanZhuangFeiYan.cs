using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///冠状肺炎
/// </summary>
class GuanZhuangFeiYan : AbstractAdjectives
{

    public override void Awake()
    {
        base.Awake();
        adjID = 8;
        wordName = "冠状肺炎";
        nickname.Add("肺炎");
        bookName = BookNameEnum.FluStudy;
        chooseWay = ChooseWayEnum.canChoose;
        banAim.Add(gameObject.AddComponent<Biology>());
        skillMode=gameObject.AddComponent<DamageMode>();
        percentage = 25;
        skillEffectsTime = 7;
        useAtFirst = true;
        description = "造成25点伤害";
    }


    /// <summary>
    /// 25固定物理伤害
    /// </summary>
    /// <param name="aimCharacter"></param>
    override public void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        aimCharacter.hp-=(int)percentage; 
    }

    public override void SpecialAbility(AbstractCharacter aimCharacter)
    {
       
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "一场突如其来的疫病突然降临到了" + character.wordName + "身上，他开始呼吸衰竭，身体的各方面功能也都急剧下降。";

    }
}
