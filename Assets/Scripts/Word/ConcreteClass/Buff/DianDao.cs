using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// buff���ߵ�
/// </summary>
public class DianDao : AbstractBuff
{
    static public string s_description = "������ǰ��<sprite name=\"atk\">��<sprite name=\"psy\">��������ָ�";
    static public string s_wordName = "�ߵ�";

    override protected void Awake()
    {
        base.Awake();
        buffName = "�ߵ�";
<<<<<<< HEAD
        description = "������ǰ��<sprite name=\"atk\">��<sprite name=\"psy\">��������ָ�";
=======
        description = "������ǰ�Ĺ������;��񣬽�����ָ�";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
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
