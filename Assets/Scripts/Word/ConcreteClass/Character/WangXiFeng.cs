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
        criticalChance = 10;
        attackInterval = 2;
        attackDistance = 2;
        importantNum.AddRange(new int[] { 8 });
        brief = "����¥�Ρ���һλ�����Ҽ��߱�������Ů�ˡ�";
        description = "�������ѩ�������й��ŵ�С˵����¥�Ρ��е��������ʮ����֮һ�����������ӡ��ڼָ�����ʵȨ��Ϊ���ĺ��������������磬�Ұ��Һޣ����¾�����������ɷ�������ʶ�ʮ���ƶʣ�������ƺ����ȶ��㡣�������ڱ��ݺ����Ҳ�����,�ڼ�����Ѫ������,������Ѫ������";
    }

    /// <summary>
    /// ���
    /// </summary>
    public override float atk { get { return ATK +3; } set { ATK = value; } }
    public override float def { get { return DEF + 3; } set { DEF = value; } }
    public override float san { get { return SAN + 3; } set { SAN = value; } }
    public override float psy { get { return PSY + 3; } set { PSY = value; } }

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
