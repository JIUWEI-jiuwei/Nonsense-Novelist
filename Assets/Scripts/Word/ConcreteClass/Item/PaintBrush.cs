using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ����
/// </summary>
class PaintBrush : AbstractItems
{
    public void Awake()
    {
        itemID = -1;
        wordName = "����";
        bookName = BookNameEnum.HuaShi;
        description = "һ֧ƽƽ����Ļ���";
        nickname.Add("��ˢ");
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Soft;

    }
}
