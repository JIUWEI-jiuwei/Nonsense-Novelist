using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///超敏反应
/// </summary>
class ChaoMinFanYing : AbstractAdjectives
{
    private AbstractCharacter aimState;//如果挂在角色身上时，获取的抽象角色
    public void Awake()
    {
        adjID = 7;
        wordName = "超敏反应";
        bookName = BookNameEnum.Epidemiology;
        chooseWay = ChooseWayEnum.canChoose;
        banAim.Add(gameObject.AddComponent<Biology>());
        skillMode=gameObject.AddComponent<DamageMode>();
        percentage = 15;
        skillEffectsTime = 1;
        useAtFirst = false;

    }


    /// <summary>
    /// 15固定物理伤害
    /// </summary>
    /// <param name="aimCharacter"></param>
    override public void UseVerbs(AbstractCharacter aimCharacter)
    {
        aimCharacter.hp-=(int)percentage; 
    }

    public override void SpecialAbility(AbstractCharacter aimCharacter)
    {
       
    }

        
}
