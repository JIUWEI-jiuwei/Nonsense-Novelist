using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��ˮ��
/// </summary>
class PinkStone: AbstractItems
{
    public void Awake()
    {
        itemID = 9;
        wordName = "��ˮ��";
        bookName = BookNameEnum.CrystalEnergy;
        getWay = GetWayEnum.NormalWord;
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;
        psy = 3;
        dodgeChance += 0.15f;
    }
}
