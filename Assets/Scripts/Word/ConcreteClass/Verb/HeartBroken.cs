using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ����
/// </summary>
class HeartBroken : AbstractVerbs
{
    public HeartBroken()
    {
        wordName = "����";
        bookName = BookNameEnum.allBooks;
        description = "��Ŀ�����絶�ʡ�";
        nickname = "��ʹ";
        skillMode = new Damage();
        //����ǿ�ȸ���
        attackDistance = Mathf.Infinity;
        skillTime = 0;
        skillEffectsTime = 3;
        cd=0;
        maxCD=5;
        comsumeSP = 5;
        prepareTime = 0.5f;
        afterTime = 1;
        allowInterrupt = false;
        possibility = 0;
    }
    public override void Ability()
    {
        
    }
}
