using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// buff:����
/// </summary>
public class QiWu : AbstractBuff
{
    private float record;
    override protected void Awake()
    {
        base.Awake();
        buffName = "����";
        description = "��ͨ�����������е��ˣ��˺�����70%����������Ч��";
        book = BookNameEnum.allBooks;

    }


    private void OnDestroy()
    {
    }
}
