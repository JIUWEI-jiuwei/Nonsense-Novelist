using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ˤ
/// </summary>
class FallBadly : AbstractVerbs
{
    public FallBadly()
    {
        wordName = "ˤ";
        bookName = BookNameEnum.HongLouMeng;
        description = "������������ˤ��Է�";
        nickname = "�ң�˦��Ͷ��";
        skillMode = new Damage();
        //����ǿ�ȸ���
        attackDistance = 6;
        skillTime = 1.5f;
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
