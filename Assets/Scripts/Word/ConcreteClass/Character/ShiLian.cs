using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ShiLian : AbstractCharacter
{
  public ShiLian()
    {
        characterID = 2;
        gender = GenderEnum.noGender;
        appearance = 2;
        wordName = "ʧ��";
        bookName = BookNameEnum.allBooks;
        nickname = "����֮��";
        criticalSpeak = "��Ǹ�������ǲ����ʡ�";
        deadSpeak = "�㾹Ȼ˿�����ں���";
        maxHP = 50;
        maxSP = 20;
        atk = 7;
        def = 1;
        psy = 13;
        san = 3;
        criticalChance = 0;
        multipleCriticalStrike = 2f;
        attackSpeed = 1.5f;
        skillSpeed = 0;
        luckyValue = 0;
    }
}
