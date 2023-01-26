using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ̫��þ�
/// </summary>
class TaiXuHuanJing : AbstractAdjectives
{
    private AbstractCharacter aimState;//������ڽ�ɫ����ʱ����ȡ�ĳ����ɫ
    public override void Awake()
    {
        base.Awake();
        adjID = 3;
        wordName = "̫��þ�";
        bookName = BookNameEnum.HongLouMeng;
        description = "�ı䳡�أ��������뾫��Ե�����������־�Ե�������10��";
        chooseWay = ChooseWayEnum.allChoose;
        skillMode = gameObject.AddComponent<PlatformMode>();
        attackDistance = 999;
        skillEffectsTime = 10;
        useAtFirst = true;

        aimState = this.GetComponent<AbstractCharacter>();//2.��ȡĿ�꣨����Ŀ����ʱ��
    }

    private float now = 0;//��ʱ
    private float swap;//���ڽ������м����
    /// <summary>
    /// �鵽ʱ��ȫ������̫��þ�����ͨ�����Ծ���������־�����м���
    /// </summary>
    override public void SpecialAbility(AbstractCharacter aimCharacter)
    {
        if (!aimCharacter.buffs.ContainsKey(8) || aimCharacter.buffs[8] < 1)//��ߵ�1��
        {
            aimCharacter.AddBuff(8);
            swap = aimCharacter.atk;
            aimCharacter.atk = aimCharacter.psy;
            aimCharacter.psy = swap;

            swap = aimCharacter.def;
            aimCharacter.def = aimCharacter.san;
            aimCharacter.san = swap;

            //1.��Ŀ����Ӵ˽ű����ýű���Start��ȡ�����ɫ��,����Update�ȴ�����Ч��
            aimCharacter.gameObject.AddComponent<TaiXuHuanJing>();
        }
    }

    override public void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        aims =skillMode.CalculateAgain(attackDistance, aimCharacter);
        foreach (AbstractCharacter aim in aims)
        {
            SpecialAbility(aim);
        }

    }

    private void FixedUpdate()
    {
        if (aimState != null)//3.ʱ�䵽���������Լ�
        {
            if (now < skillEffectsTime)
            {
                now += Time.deltaTime;
            }
            else if (now >= skillEffectsTime)
            {
                swap = aimState.atk;
                aimState.atk = aimState.psy;
                aimState.psy = swap;

                swap = aimState.def;
                aimState.def = aimState.san;
                aimState.san = swap;
                aimState.RemoveBuff(8);
            }
        }
    }

    public override string UseText()
    {
        return "ֻ������������������һ���㱣���ͻȻ����̫��þ�֮�С�";

    }
}
