using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///���
/// </summary>
class HunFei : AbstractAdjectives
{
    private AbstractCharacter aimState;//������ڽ�ɫ����ʱ����ȡ�ĳ����ɫ
    public override void Awake()
    {
        base.Awake();
        adjID = 9;
        wordName = "���";
        bookName = BookNameEnum.PHXTwist;
        chooseWay = ChooseWayEnum.canChoose;
        skillMode=gameObject.AddComponent<UpATKMode>();
        percentage = 0;
        skillEffectsTime = 10;
        useAtFirst = true;
        description = "����Ŀ��30%�������Ĺ���������10��";
        aimState = this.GetComponent<AbstractCharacter>();//2.��ȡĿ�꣨����Ŀ����ʱ��
    }

    private float now = 0;//��ʱ
    private float record;//��¼�����Ĺ�����
    /// <summary>
    /// ����30%�������Ĺ�����,����10��
    /// </summary>
    /// <param name="aimCharacter"></param>
    override public void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        record = aimCharacter.psy * 0.3f;
        skillMode.UseMode(null,record,aimCharacter);
        aimCharacter.AddBuff(1);

        //1.��Ŀ����Ӵ˽ű����ýű���Start��ȡ�����ɫ��,����Update�ȴ�����Ч��
        aimCharacter.gameObject.AddComponent<HunFei>().record=record;
    }

    private void FixedUpdate()
    {
        if(aimState!=null)
        {
            if (now < skillEffectsTime)
            {
                now += Time.deltaTime;
            }
            else if (now >= skillEffectsTime)
            {
                aimState.atk-=record;
                aimState.RemoveBuff(1);
            }
        }
    }

    public override void SpecialAbility(AbstractCharacter aimCharacter)
    {
        
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "һ�����������Ĵ���������׵ؽ����ˣ��ڽ�����İ�Сʱ�ڣ���Ⱥ�İ������Գɳ�ɳ���Ѩ���л��" + character.wordName + "Ҳ�������ⳡʢ���С�";

    }
}
