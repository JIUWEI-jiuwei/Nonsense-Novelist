using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �����
/// </summary>
class LinQiuJun : AbstractAdjectives
{

    public override void Awake()
    {
        base.Awake();
        adjID = 6;
        wordName = "�����";
        nickname.Add("�ܲ�");
        bookName = BookNameEnum.Epidemiology;
        chooseWay = ChooseWayEnum.canChoose;
        banAim.Add(gameObject.AddComponent<Biology>());
        skillMode=gameObject.AddComponent<DamageMode>();
        percentage = 10;
        skillEffectsTime = 3;
        useAtFirst = false;
        description = "���10���˺�";
    }


    /// <summary>
    /// 10�̶������˺�
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

        return character.wordName + "�����忪ʼ����һЩ������Ż�ķ���������ƺ��ᴫ���������ˡ�";

    }
}
