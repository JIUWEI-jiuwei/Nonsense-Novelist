using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// buff:��ʴ
/// </summary>
public class FuShi: AbstractBuff
{
    static public string s_description = "����1 < sprite name=\"def\">+30���ɵ���";
    static public string s_wordName = "��ʴ";

    override protected void Awake()
    {
        base.Awake();
        buffName = "��ʴ";
        description = "����1<sprite name=\"def\">+30���ɵ���";
        
        book = BookNameEnum.allBooks;
        chara.def -= 2;
        isBad = true;
    }

    private void OnDestroy()
    {
        chara.def -= 1;
    }

}
