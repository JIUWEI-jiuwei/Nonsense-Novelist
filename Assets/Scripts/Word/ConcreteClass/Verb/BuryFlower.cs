using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �Ứ
/// </summary>
class BuryFlower : AbstractVerbs
{
    public void Awake()
    {
        skillID = 3;
        wordName = "�Ứ";
        bookName = BookNameEnum.HongLouMeng;
        description = "ƽ���Ứɱ�ˣ������仨�����㣬����������֮��";
        skillMode = gameObject.AddComponent<UpPSYMode>();
        skillMode.attackRange = new CircleAttackSelector();//
        attackDistance = 0;
        skillTime = 7;
        skillEffectsTime = 0;
        cd=maxCD=40;
        comsumeSP = 15;
        prepareTime = 1f;
        afterTime = 0;
        allowInterrupt = true;
        possibility = 0;

    }

    public override void SpecialAbility()
    {

    }
    
}
