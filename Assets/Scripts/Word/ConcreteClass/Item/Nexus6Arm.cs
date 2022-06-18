using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///Nexus-6���ֱ�
/// </summary>
class Nexus6Arm : AbstractItems
{
    public void Awake()
    {
        itemID = 10;
        wordName = "Nexus-6���ֱ�";
        bookName = BookNameEnum.ElectronicGoal;
        getWay = GetWayEnum.NormalWord;
        description = "һ���Ѿ�ͣ����ǿ���е�ۣ�����10�㹥����10%�������ʡ�";
        holdEnum = HoldEnum.handDouble;
        VoiceEnum = MaterialVoiceEnum.Meat;
        camp = CampEnum.friend;
        atk =10;
        criticalChance = 0.1f;
    }
}
