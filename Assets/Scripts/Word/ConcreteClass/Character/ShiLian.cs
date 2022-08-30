using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ʧ����2���֣�
/// </summary>
class ShiLian : AbstractCharacter
{
  override public void Awake()
    {
        base.Awake();
        characterID = 2;
        gender = GenderEnum.noGender;
        wordName = "ʧ��";
        brief = "��������֮�࣬�����Ը����֮�˸�Ϊ����";
        description = "��������֮�࣬�����Ը����֮�˸�Ϊ����";
        bookName = BookNameEnum.allBooks;
        nickname.Add( "����֮��");
        nickname.Add("��������İ���");
        criticalSpeak = "��Ǹ�������ǲ����ʡ�";
        deadSpeak = "�㾹Ȼ˿�����ں���";
        trait = gameObject.AddComponent<Inexorability>();
        role = gameObject.AddComponent<Noble>();
        skills.Add(gameObject.AddComponent<HeartBroken>());
        hp=maxHP = 40;
        sp=maxSP = 20;
        atk = 5;
        def = 1;
        psy = 13;
        san = 3;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackInterval = 1.3f;
        skillSpeed = 0;
        dodgeChance = 0;
        attackDistance = 6;
        luckyValue = 0;
        enemyLevel = 2;
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
