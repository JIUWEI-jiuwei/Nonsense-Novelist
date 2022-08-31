using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///������Ӧ
/// </summary>
class ChaoMinFanYing : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        adjID = 7;
        wordName = "������Ӧ";
        nickname.Add ("����");
        bookName = BookNameEnum.Epidemiology;
        chooseWay = ChooseWayEnum.canChoose;
        banAim.Add(gameObject.AddComponent<Biology>());
        skillMode=gameObject.AddComponent<DamageMode>();
        percentage = 15;
        skillEffectsTime = 1;
        useAtFirst = false;
        description = "���15���˺�";
    }


    /// <summary>
    /// 15�̶������˺�
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

        return "ͻȻ"+character.wordName + "��֪��������ʲô���ۻ��������������ʼ���ȫ��������ӣ���˻���Ž��Լ�ץ��Ѫ��ģ����";

    }
}
