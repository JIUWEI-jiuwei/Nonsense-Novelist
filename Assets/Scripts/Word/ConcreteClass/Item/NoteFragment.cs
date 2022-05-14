using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 德拉瑞斯的笔记碎片
/// </summary>
class NoteFragment : AbstractItems
{
    public void Awake()
    {
        itemID = 3;
        wordName = "德洛瑞斯的笔记碎片";
        bookName = BookNameEnum.StudentOfWitch;
        getWay = GetWayEnum.NormalWord;
        description = "记载了一些德洛瑞斯写着玩的杂耍魔法，但对普通人来说足具威力了";
        nickname.Add("笔记本");
        camp = CampEnum.all;
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Book;
        withSkill = gameObject.AddComponent<LengXiangPillSkill>();
        psy = 5;
    }
}
