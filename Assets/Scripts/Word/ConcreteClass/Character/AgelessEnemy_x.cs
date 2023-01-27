using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �޵У���ʱ���ã�
/// </summary>
class AgelessEnemy_x : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = -1;
        gender = GenderEnum.noGender;
        wordName = "�޵�";
        bookName = BookNameEnum.allBooks;
        description = "�����������ȥ�����Ҳ�֪Ϊ�����ǻ᲻�������Է�";
        trait = gameObject.AddComponent<Pride>();
        hp=maxHP = 70;
        atk = 15;
        def = 2;
        psy = 7;
        san = 2;
        attackInterval = 2.2f;
        attackDistance = 600;
    }

    public override string ShowText(AbstractCharacter otherChara)
    {
        return "";
    }

    public override string CriticalText(AbstractCharacter otherChara)
    {
        return "";
    }

    public override string LowHPText()
    {
        return "";
    }
    public override string DieText()
    {
        return "";
    }
}
