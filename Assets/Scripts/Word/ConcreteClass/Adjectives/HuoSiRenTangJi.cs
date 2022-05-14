using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ����������
/// </summary>
class HuoSiRenTangJi : AbstractAdjectives
{
    public void Awake()
    {
        adjID = 2;
        wordName = "����������";
        description = "���»����������������ܹ����������»��һ������������������øɿݡ�";
        chooseWay = ChooseWayEnum.canChoose;
        skillMode = gameObject.AddComponent<SpecialMode>();
        useAtFirst = false;
    }

    /// <summary>
    /// ����
    /// </summary>
    override public void SpecialAbility()
    {
        
    }

    override public void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        SpecialAbility();
    }


}
