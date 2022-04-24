using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ������
/// </summary>
class HuaiJinDaoYu : AbstractAdjectives
{
    public void Awake()
    {
        adjID = 2;
        wordName = "������";
        description = "����ת˲���ţ���������ٻ�����";
        nickname.Add("������");
        chooseWay = ChooseWayEnum.canChoose;
        skillMode = new SpendCodeMode();
        percentage = 0.05f;
        useAtFirst = false;

    }

    /// <summary>
    /// ����
    /// </summary>
    override public void SpecialAbility()
    {

    }

    override public void UseVerbs(GameObject character)
    {
        base.UseVerbs(character);
        SpecialAbility();
    }


}
