using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// buff:����
/// </summary>
public class ReLife : AbstractBuff
{
    override protected void Awake()
    {
        base.Awake();
        buffName = "����";
        description = "���ܵ������˺�ʱ�ָ�����������ħ����������и���״̬";
        book = BookNameEnum.EgyptMyth;
        chara.reLifes ++;
        //������и���״̬
    }

    private void OnDestroy()
    {
        chara.reLifes --;
    }
}
