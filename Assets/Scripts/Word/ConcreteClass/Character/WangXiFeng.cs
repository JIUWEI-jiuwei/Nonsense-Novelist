using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class WangXiFeng : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 2;
        wordName = "������";
        bookName = BookNameEnum.HongLouMeng;
        gender = GenderEnum.girl;
        hp = maxHP = 150;
        atk = 5;
        def = 4;
        psy = 3;
        san = 3;
        mainProperty.Add("����", "����dps");
        trait = gameObject.AddComponent<Spicy>();
        roleName = "��ҳ�";
        attackInterval = 2.2f;
        attackDistance = 200;
        brief = "����¥�Ρ���һλ�����Ҽ��߱�������Ů�ˡ�";
        description = "�������ѩ�������й��ŵ�С˵����¥�Ρ��е��������ʮ����֮һ�����������ӡ��ڼָ�����ʵȨ��Ϊ���ĺ��������������磬�Ұ��Һޣ����¾�����������ɷ�������ʶ�ʮ���ƶʣ�������ƺ����ȶ��㡣�������ڱ��ݺ����Ҳ�����,�ڼ�����Ѫ������,������Ѫ������";
    }

    /// <summary>
    /// ���
    /// </summary>
    public override float atk { get { return base.atk +5; } set { base.atk = value; } }
    public override float def { get { return base.def + 5; } set { base.def = value; } }
    public override float san { get { return base.san + 5; } set { base.san = value; } }
    public override float psy { get { return base.psy  + 5; } set { base.psy  = value; } }

    public override string ShowText(AbstractCharacter otherChara)
    {
        if (otherChara != null)
            return "ֻ������һ��߿���Ц����" + otherChara.wordName + "�����������ˡ�����ձ��߳���һ��Ũױ���޵��ٸ������������";
        else
            return null;
    }

    public override string CriticalText(AbstractCharacter otherChara)
    {
        if (otherChara != null)
            return "���������"+otherChara .wordName+"�ݺݵ�һ���ơ�����񮹷������ǽ�����ӣ���,";
        else
            return null;
    }
    public override string LowHPText()
    {
        return "������һ���в���̫�����������ն���Ѫ��ӿ������Ѫ������ʱ������ʮ��������";
    }

    public override string DieText()
    {
        return "��ɫ�Ұ׵�������֧�ֲ�ס������ȥ��";
    }

}
