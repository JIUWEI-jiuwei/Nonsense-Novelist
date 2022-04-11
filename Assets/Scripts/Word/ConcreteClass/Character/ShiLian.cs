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
        wordName = "失恋";
        bookName = BookNameEnum.allBooks;
        nickname = "爱情之苦";
        criticalSpeak = "抱歉，但我们不合适。";
        deadSpeak = "你竟然丝毫不在乎？";
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
