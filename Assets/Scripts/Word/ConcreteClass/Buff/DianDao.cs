using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// buff���ߵ�
/// </summary>
public class DianDao : AbstractBuff
{
    override protected void Awake()
    {
        base.Awake();
        buffName = "�ߵ�";
        description = "������ǰ�Ĺ������;��񣬽�����ָ�";
        book = BookNameEnum.allBooks;
        float record = chara.atk;
        chara.atk = chara.psy;
        chara.psy = record;
        upup = 1;
        isBad = true;
    }


    private void OnDestroy()
    {
        float record = chara.atk;
        chara.atk = chara.psy;
        chara.psy = record;
    }
}
