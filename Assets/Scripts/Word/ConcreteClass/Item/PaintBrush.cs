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
        itemID = 3;
        itemName = "����";
        bookName = BookNameEnum.HuaShi;
        nickname.Add("��ˢ");
        VoiceEnum = MaterialVoiceEnum.Soft;
        level = 1;

    }
}
