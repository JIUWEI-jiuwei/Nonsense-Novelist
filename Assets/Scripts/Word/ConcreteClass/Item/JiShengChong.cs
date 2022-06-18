using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///寄生虫
/// </summary>
class JiShengChong : AbstractItems
{
    public void Awake()
    {
        itemID = 11;
        wordName = "寄生虫";
        bookName = BookNameEnum.Epidemiology;
        getWay = GetWayEnum.NormalWord;
        description = "寄生虫让其宿主颇为焦躁不安，降低3点防御，减少攻击速度。";
        holdEnum = HoldEnum.handSingle;
        banUse.Add(gameObject.AddComponent<Biology>());
        VoiceEnum = MaterialVoiceEnum.Meat;
        camp = CampEnum.all;
        def =-3;
        attackInterval = -0.3f;
    }
}
