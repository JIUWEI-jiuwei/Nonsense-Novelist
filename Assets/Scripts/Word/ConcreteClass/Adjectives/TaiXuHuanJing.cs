using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ̫��þ�
/// </summary>
class TaiXuHuanJing : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.adj;
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
