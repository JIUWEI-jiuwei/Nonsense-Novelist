using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///������Ӧ
/// </summary>
class ChaoMinFanYing : AbstractAdjectives
{
    private AbstractCharacter aimState;//������ڽ�ɫ����ʱ����ȡ�ĳ����ɫ
    public override void Awake()
    {
        base.Awake();
        adjID = 7;
        wordName = "������Ӧ";
        bookName = BookNameEnum.Epidemiology;
        chooseWay = ChooseWayEnum.canChoose;
        banAim.Add(gameObject.AddComponent<Biology>());
        skillMode=gameObject.AddComponent<DamageMode>();
        percentage = 15;
        skillEffectsTime = 1;
        useAtFirst = false;

    }


    /// <summary>
    /// 15�̶������˺�
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
