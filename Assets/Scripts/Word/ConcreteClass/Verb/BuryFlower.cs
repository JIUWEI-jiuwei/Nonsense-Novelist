using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �Ứ
/// </summary>
class BuryFlower : AbstractVerbs
{
    public BuryFlower()
    {
        wordName = "�Ứ";
        bookName = BookNameEnum.HongLouMeng;
        description = "����";
        nickname = "ƽ���Ứɱ�ˣ������仨�����㣬����������֮����";
        skillMode = new StatusUp();
        //����ǿ�ȸ���
        attackDistance = 0;
        skillTime = 7;
        comsumeSP = 15;
        prepareTime = 1f;
        afterTime = 0;
        allowInterrupt = true;
        possibility = 0;
    }
    public override void Ability()
    {

    }
}
