using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ͵������
/// </summary>
class TaiXuHuanJing : AbstractAdjectives
{
    public void Awake()
    {
        adjID = 3;
        wordName = "̫��þ�";
        description = "����̫��þ�";
        chooseWay = ChooseWayEnum.allChoose;
        skillMode = new PlatformMode();
        attackDistance = 999;
        skillEffectsTime = 10;
        useAtFirst = true;
    }
    /// <summary>
    /// �鵽ʱ��ȫ������̫��þ�����ͨ�����Ծ���������־�����м���
    /// </summary>
    override public void SpecialAbility()
    {

    }

    override public void UseVerbs(GameObject character)
    {
        base.UseVerbs(character);
        foreach (GameObject aim in aims)
        {
            
        }
            SpecialAbility();
    }
}
