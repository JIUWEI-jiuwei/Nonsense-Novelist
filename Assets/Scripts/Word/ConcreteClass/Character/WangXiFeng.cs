using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class WangXiFeng : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 4;
        gender = GenderEnum.girl;
        wordName = "������";
        bookName = BookNameEnum.HongLouMeng;
        brief = "����¥�Ρ���һλ�����Ҽ��߱�������Ů�ˡ�";
        criticalSpeak = "��������������ǽ������";
        deadSpeak = "���һ����㾡����";
        trait = gameObject.AddComponent<Spicy>();
        role = gameObject.AddComponent<Parents>();
        hp=maxHP = 120;
        sp=maxSP = 15;
        atk = 10;
        def = 3;
        psy = 5;
        san = 3;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackInterval = 1.5f;
        skillSpeed = 0;
        dodgeChance = 0;
        attackDistance = 1;
        luckyValue = 0;
        importantNum.AddRange(new int[] { 3 });
        bg_text = "�������ѩ�������й��ŵ�С˵����¥�Ρ��е��������ʮ����֮һ�����������ӡ��ڼָ�����ʵȨ��Ϊ���ĺ��������������磬�Ұ��Һޣ����¾�����������ɷ�������ʶ�ʮ���ƶʣ�������ƺ����ȶ��㡣�������ڱ��ݺ����Ҳ�����,�ڼ�����Ѫ������,������Ѫ������";
        mainSort = MainSortEnum.atk;
    }

    public override string CriticalText(AbstractCharacter otherChara)
    {
        if (otherChara != null)
            return "���������"+otherChara .wordName+"�ݺݵ�һ���ơ�����񮹷������ǽ�����ӣ���,";
        else
            return null;
    }

    public override string DieText()
    {
        return "��ɫ�Ұ׵�������֧�ֲ�ס������ȥ��";
    }

    public override string LowHPText()
    {
        return "������һ���в���̫�����������ն���Ѫ��ӿ������Ѫ������ʱ������ʮ��������";
    }

    public override string ShowText(AbstractCharacter otherChara)
    {
        if (otherChara != null)
            return "ֻ������һ��߿���Ц����" + otherChara.wordName + "�����������ˡ�����ձ��߳���һ��Ũױ���޵��ٸ������������";
        else
            return null;
    }

}
