using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ����ʯ
/// </summary>
class TigerStone: AbstractItems
{
    public void Awake()
    {
        itemID = 8;
        wordName = "����ʯ";
        bookName = BookNameEnum.CrystalEnergy;
        getWay = GetWayEnum.NormalWord;
        description = "һ�Ž�ɫ�����ı�ʯ������3�㹥����������ǿ����������";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;
        atk = 3;
        multipleCriticalStrike = 0.5f;
    }
}
