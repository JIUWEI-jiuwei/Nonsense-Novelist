using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��ˮ��
/// </summary>
class WhiteStone: AbstractItems
{
    public void Awake()
    {
        itemID = 6;
        wordName = "��ˮ��";
        bookName = BookNameEnum.CrystalEnergy;
        getWay = GetWayEnum.NormalWord;
        description = "һ�Ŵ�����Ͼ�İ�ɫˮ����������ά���Ը�1�㡣";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;
        
        atk = 1;
        def = 1;
        psy = 1;
        san = 1;
    }
}
