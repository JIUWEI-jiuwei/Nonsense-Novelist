using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 白水晶
/// </summary>
class WhiteStone: AbstractItems
{
    public void Awake()
    {
        itemID = 6;
        wordName = "白水晶";
        bookName = BookNameEnum.CrystalEnergy;
        getWay = GetWayEnum.NormalWord;
        description = "一颗纯洁无暇的白色水晶，提升四维属性各1点。";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;
        
        atk = 1;
        def = 1;
        psy = 1;
        san = 1;
    }
}
