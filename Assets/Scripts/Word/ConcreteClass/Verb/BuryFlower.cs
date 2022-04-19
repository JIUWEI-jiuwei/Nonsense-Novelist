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
        skillMode = new DamageMode();  
        //����ǿ�ȸ���
        attackDistance = 0;
        skillTime = 7;
        skillEffectsTime = 0;
        cd=0;
        maxCD=40;
        comsumeSP = 15;
        prepareTime = 1f;
        afterTime = 0;
        allowInterrupt = true;
        possibility = 0;

        isFirst = true;
        b_CdCooled = false;
    }
    public override void Ability()
    {

    }
    override public void CDTime(float cd, float maxCD, bool isFirst, bool b_CDCooled)//ֻ�п���ҡ����ʱ��isFirst=true������ʱ��Ϊfalse
    {
        this.cd = cd;
        this.maxCD = maxCD;
        this.isFirst = isFirst;
        this.b_CdCooled = b_CDCooled;
        
        //����
        if (isFirst) b_CDCooled = true;

        //����
        else
        {
            b_CDCooled = false;
            cd += Time.deltaTime;

            //CD�Ѻ�
            if (cd == maxCD)
            {
                b_CDCooled = true;

            }
        }
    }
}
