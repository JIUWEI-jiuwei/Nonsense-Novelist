using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///��״����
/// </summary>
class GuanZhuangFeiYan : AbstractAdjectives
{
    
    public void Awake()
    {
        adjID = 8;
        wordName = "��״����";
        bookName = BookNameEnum.Epidemiology;
        chooseWay = ChooseWayEnum.canChoose;
        banAim.Add(gameObject.AddComponent<Biology>());
        skillMode=gameObject.AddComponent<DamageMode>();
        percentage = 25;
        skillEffectsTime = 7;
        useAtFirst = true;

    }


    /// <summary>
    /// 25�̶������˺�
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
