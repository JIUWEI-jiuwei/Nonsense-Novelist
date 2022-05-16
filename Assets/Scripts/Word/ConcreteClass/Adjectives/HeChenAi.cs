using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �˳���
/// </summary>
class HeChenAi : AbstractAdjectives
{
    private AbstractCharacter aimState;//������ڽ�ɫ����ʱ����ȡ�ĳ����ɫ
    public void Awake()
    {
        adjID = 5;
        wordName = "�˳���";
        bookName = BookNameEnum.ElectronicGoal;
        chooseWay = ChooseWayEnum.canChoose;
        skillMode=gameObject.AddComponent<PlatformMode>();
        attackDistance = 999;
        percentage = 0;
        skillEffectsTime = 10;
        useAtFirst = true;

        aimState = this.GetComponent<AbstractCharacter>();//2.��ȡĿ�꣨����Ŀ����ʱ��
    }


    private float now = 0;//��ʱ
    private int seconds = 0;//ÿ��
    /// <summary>
    /// ��־��-3
    /// </summary>
    /// <param name="aimCharacter"></param>
    override public void UseVerbs(AbstractCharacter aimCharacter)
    {
        if (aimCharacter.buffs[14] < 1)
        {
            aimCharacter.AddBuff(14);

            //1.��Ŀ�����Ӵ˽ű����ýű���Start��ȡ�����ɫ��,����Update�ȴ�����Ч��
            aimCharacter.gameObject.AddComponent<HeChenAi>();
        }
    }

    public override void SpecialAbility(AbstractCharacter aimCharacter)
    {
       
    }

    private void FixedUpdate()
    {
        if (aimState != null)//3.ʱ�䵽���������Լ�
        {
            if(now>seconds)//ÿ��5���˺�
            {
                aimState.hp -= 5;
                seconds++;
            }
            
            if (now < skillEffectsTime)
            {
                now += Time.deltaTime;
            }
            else if (now >= skillEffectsTime)
            {
                aimState.san += 3;
                aimState.RemoveBuff(14);
                Destroy(this);
            }
        }
    }
}