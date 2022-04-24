using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 失恋（2级怪）
/// </summary>
class ShiLian : AbstractCharacter
{
  public void Awake()
    {
        characterID = 2;
        gender = GenderEnum.noGender;
        wordName = "失恋";
        description = "爱而不得之苦，对于性格脆弱之人更为致命";
        bookName = BookNameEnum.allBooks;
        nickname.Add( "爱情之苦");
        nickname.Add("令人心碎的爱情");
        criticalSpeak = "抱歉，但我们不合适。";
        deadSpeak = "你竟然丝毫不在乎？";
        camp = CampEnum.enemy;
        role = new Noble();
        skill.Add(new HeartBroken());
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
    }
}
