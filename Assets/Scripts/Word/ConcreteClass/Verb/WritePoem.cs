using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��ʫ
/// </summary>
class WritePoem : AbstractVerbs
{
    public WritePoem ()
    {
        wordName = "��ʫ";
        bookName = BookNameEnum.HongLouMeng;
        description = "��ʫ���ԣ��ò����";
        nickname = "��ʫ";
        skillMode = new StatusUp();
        //����ǿ�ȸ���
        attackDistance = 5;
        skillTime = 0;
        skillEffectsTime = 5;
        comsumeSP = 10;
        prepareTime = 2;
        afterTime = 0;
        allowInterrupt = true;
        possibility = 0;
    }

    public override void Ability()
    {
       
    }
}
