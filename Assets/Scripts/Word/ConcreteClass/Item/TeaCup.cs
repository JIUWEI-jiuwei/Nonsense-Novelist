using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �豭
/// </summary>
class TeaCup : AbstractItems
{
  public TeaCup()
    {
        itemID = 1;
        itemName = "�豭";
        bookName = BookNameEnum.HongLouMeng;
        description = "һ���൱���µĲ豭";
        VoiceEnum = MaterialVoiceEnum.Ceram;
        level = 1;

    }
}
