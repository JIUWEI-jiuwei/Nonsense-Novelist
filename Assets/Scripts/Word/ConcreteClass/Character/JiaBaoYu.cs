using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class JiaBaoYu : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 8;
        gender = GenderEnum.boy;
        wordName = "�ֱ���";
        bookName = BookNameEnum.HongLouMeng;
        role = gameObject.AddComponent<Noble>();
        trait = gameObject.AddComponent<Obsessed>();
        hp=maxHP  = 60;
        sp=maxSP = 10;
        atk = 7;
        def = 3;
        psy = 8;
        san = 0;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackInterval = 1.3f;
        skillSpeed = 0;
        dodgeChance = 0;
        attackDistance = 6;
        luckyValue = 0;
        importantNum.AddRange(new int[] { 1, 10 });
        bg_text = "�ֱ����й��ŵ���������¥�Ρ��е������ǡ�ǰ������Ϊ��ϼ���������ߣ��ٹ��������������������Ĵ��ӡ�����ͨ�鱦�������ϵ�ָ����ֱ���������ֱ��񣬼ָ�ͨ�Ʊ���ү��������������÷������Ϊ֪������չ��һ���������еĴ�����飬�������ڼ��尲���º����Ϳ��Ѧ���ν�飬��ʹ�������ᾡ����";
        mainSort = MainSortEnum.psy;
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
