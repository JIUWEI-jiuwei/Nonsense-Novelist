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
        skillMode = gameObject.AddComponent<PlatformMode>();
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

    override public void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        foreach (GameObject aim in aims)
        {
            
        }
            SpecialAbility();
    }
}
