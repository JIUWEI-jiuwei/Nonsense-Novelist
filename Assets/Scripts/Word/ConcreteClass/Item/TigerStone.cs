using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ª¢—€ Ø
/// </summary>
class TigerStone: AbstractItems
{
    public void Awake()
    {
        itemID = 8;
        wordName = "ª¢—€ Ø";
        bookName = BookNameEnum.CrystalEnergy;
        getWay = GetWayEnum.NormalWord;
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;
        camp = CampEnum.friend;
        atk = 3;
        multipleCriticalStrike = 0.5f;
    }
}
