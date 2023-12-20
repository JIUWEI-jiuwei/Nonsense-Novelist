using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// buff:¸¯Ê´
/// </summary>
public class FuShi: AbstractBuff
{

    override protected void Awake()
    {
        base.Awake();
        buffName = "¸¯Ê´";
        description = "½µµÍ1·ÀÓùÁ¦£¬¿Éµþ¼Ó";
        
        book = BookNameEnum.allBooks;
        chara.def -= 2;
        isBad = true;
    }

    private void OnDestroy()
    {
        chara.def -= 1;
    }

}
