using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// buff:¸¯Ê´
/// </summary>
public class FuShi: AbstractBuff
{
    static public string s_description = "½µµÍ1 < sprite name=\"def\">+30£¬¿Éµþ¼Ó";
    static public string s_wordName = "¸¯Ê´";

    override protected void Awake()
    {
        base.Awake();
        buffName = "¸¯Ê´";
<<<<<<< HEAD
        description = "½µµÍ1<sprite name=\"def\">+30£¬¿Éµþ¼Ó";
=======
        description = "½µµÍ1·ÀÓùÁ¦£¬¿Éµþ¼Ó";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
        
        book = BookNameEnum.allBooks;
        chara.def -= 2;
        isBad = true;
    }

    private void OnDestroy()
    {
        chara.def -= 1;
    }

}
