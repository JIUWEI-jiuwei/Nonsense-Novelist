using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��ˮ��
/// </summary>
class PurpleStone: AbstractItems
{
    public void Awake()
    {
        itemID = 7;
        wordName = "��ˮ��";
        bookName = BookNameEnum.CrystalEnergy;
        getWay = GetWayEnum.NormalWord;
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;
        camp = CampEnum.friend;
        psy = 3;
        multipleCriticalStrike = 0.5f;
    }
}
