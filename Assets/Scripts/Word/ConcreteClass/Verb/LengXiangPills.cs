using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ������
/// </summary>
class LengXiangPills : AbstractVerbs
{
    public LengXiangPills()
    {
        wordName = "������";
        bookName = BookNameEnum.HongLouMeng;
        description = "����";
        nickname = "����";
        skillMode = new ReturnBlood();
        //����ǿ�ȸ���
        attackDistance = 2;
        skillTime = 0f;
        skillEffectsTime = 0;
        comsumeSP = 0;
        prepareTime = 0.5f;
        afterTime = 0;
        allowInterrupt = false;
        possibility = 0;
    }
    public override void Ability()
    {

    }
}
