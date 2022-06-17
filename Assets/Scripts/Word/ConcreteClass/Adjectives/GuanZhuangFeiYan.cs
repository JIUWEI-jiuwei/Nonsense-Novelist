using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///��״����
/// </summary>
class GuanZhuangFeiYan : AbstractAdjectives
{

    public override void Awake()
    {
        base.Awake();
        adjID = 8;
        wordName = "��״����";
        bookName = BookNameEnum.Epidemiology;
        chooseWay = ChooseWayEnum.canChoose;
        banAim.Add(gameObject.AddComponent<Biology>());
        skillMode=gameObject.AddComponent<DamageMode>();
        percentage = 25;
        skillEffectsTime = 7;
        useAtFirst = true;
        description = "��һ�ֹ㷺��������Ȼ���RNA�������µķ��ף����ֲ����ڵ�����΢������������������Χ����˱���Ϊ��״������";
    }


    /// <summary>
    /// 25�̶������˺�
    /// </summary>
    /// <param name="aimCharacter"></param>
    override public void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        aimCharacter.hp-=(int)percentage; 
    }

    public override void SpecialAbility(AbstractCharacter aimCharacter)
    {
       
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "һ��ͻ���������߲�ͻȻ���ٵ���" + character.wordName + "���ϣ�����ʼ����˥�ߣ�����ĸ����湦��Ҳ�������½���";

    }
}
