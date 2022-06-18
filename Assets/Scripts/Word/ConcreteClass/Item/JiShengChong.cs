using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///������
/// </summary>
class JiShengChong : AbstractItems
{
    public void Awake()
    {
        itemID = 11;
        wordName = "������";
        bookName = BookNameEnum.Epidemiology;
        getWay = GetWayEnum.NormalWord;
        description = "����������������Ϊ���겻��������3����������ٹ����ٶȡ�";
        holdEnum = HoldEnum.handSingle;
        banUse.Add(gameObject.AddComponent<Biology>());
        VoiceEnum = MaterialVoiceEnum.Meat;
        camp = CampEnum.all;
        def =-3;
        attackInterval = -0.3f;
    }
}
