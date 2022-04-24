using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ͵������
/// </summary>
class TouXiangQieYu : AbstractAdjectives
{
    public void Awake()
    {
        adjID = 1;
        wordName = "͵������";
        chooseWay = ChooseWayEnum.canChoose;
        banAim.Add(new Girl());
        skillMode=new DamageMode();
        useAtFirst = false;
    }

    
    override public void UseVerbs(GameObject character)
    {
        base.UseVerbs(character);
        character.GetComponent<AbstractCharacter>().psy -= 20;
        SpecialAbility();
    }
}
