using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �̰���Ϊ
/// </summary>
class KeBanXingWei : AbstractAdjectives
{
    private AbstractCharacter aimState;//������ڽ�ɫ����ʱ����ȡ�ĳ����ɫ
    public override void Awake()
    {
        base.Awake();
        adjID = 4;
        wordName = "�̰���Ϊ";
        bookName = BookNameEnum.ZooManual;
        chooseWay = ChooseWayEnum.canChoose;
        skillMode=gameObject.AddComponent<SpecialMode>();
        percentage = 10;
        skillEffectsTime = 7;
        useAtFirst = false;

        aimState = this.GetComponent<AbstractCharacter>();//2.��ȡĿ�꣨����Ŀ����ʱ��
    }


    private float now = 0;//��ʱ
    /// <summary>
    /// ��־��-3
    /// </summary>
    /// <param name="aimCharacter"></param>
    override public void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        if (!aimCharacter.buffs.ContainsKey(2) || aimCharacter.buffs[2] < 5)//��ߵ�5��
        {
            aimCharacter.san -= 3;
        
            aimCharacter.AddBuff(2);

            //1.��Ŀ����Ӵ˽ű����ýű���Start��ȡ�����ɫ��,����Update�ȴ�����Ч��
            aimCharacter.gameObject.AddComponent<KeBanXingWei>();
        }
    }

    public override void SpecialAbility(AbstractCharacter aimCharacter)
    {
       
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
                aimState.san += 3;
                aimState.RemoveBuff(2);
                Destroy(this);
            }
        }
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "���ڳ�������������Ϣ����ȫ�����Ļ����У����ܹ۹��ߵ�ע�Ӻ�ѹ����"+character.wordName+"���������صĿ̰���Ϊ��ֻ�ܲ����ظ���һЩ��������ж���";

    }
}
