using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///超敏反应
/// </summary>
class ChaoMinFanYing : AbstractAdjectives
{
    private AbstractCharacter aimState;//如果挂在角色身上时，获取的抽象角色
    public override void Awake()
    {
        base.Awake();
        adjID = 7;
        wordName = "超敏反应";
        bookName = BookNameEnum.Epidemiology;
        chooseWay = ChooseWayEnum.canChoose;
        banAim.Add(gameObject.AddComponent<Biology>());
        skillMode=gameObject.AddComponent<DamageMode>();
        percentage = 15;
        skillEffectsTime = 1;
        useAtFirst = false;
        description = "是指机体受到某些抗原刺激，如吸入性颗粒、药物、酶类物质等，出现如生理功能紊乱的异常适应性免疫应答。";
    }


    /// <summary>
    /// 15固定物理伤害
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

        return "突然"+character.wordName + "不知是吸入了什么花粉或是其他颗粒物，开始变得全身起红疹子，并嘶喊着将自己抓至血肉模糊。";

    }
}
