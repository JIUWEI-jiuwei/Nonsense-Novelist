using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// buff:��ʴ
/// </summary>
public class FuShi: AbstractBuff
{

    override protected void Awake()
    {
        base.Awake();
        buffName = "��ʴ";
        description = "����1���������ɵ���";
        
        book = BookNameEnum.allBooks;
        chara.def -= 2;
        isBad = true;
    }

    private void OnDestroy()
    {
        chara.def -= 1;
    }

}
