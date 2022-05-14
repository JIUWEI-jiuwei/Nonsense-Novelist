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
        description = "��Ů��͵�飬�����������ȥ�����¶�������";
        chooseWay = ChooseWayEnum.canChoose;
        banAim.Add(gameObject.AddComponent<Girl>());
        skillMode=gameObject.AddComponent<DamageMode>();
        useAtFirst = false;
    }

    
    
    override public void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        skillMode.UseMode(null, 20 *(1- aimCharacter.san/(aimCharacter.san+20)), aimCharacter);
        SpecialAbility();
    }
}
