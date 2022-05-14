using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ������˹�ıʼ���Ƭ
/// </summary>
class NoteFragment : AbstractItems
{
    public void Awake()
    {
        itemID = 3;
        wordName = "������˹�ıʼ���Ƭ";
        bookName = BookNameEnum.StudentOfWitch;
        getWay = GetWayEnum.NormalWord;
        description = "������һЩ������˹д�������ˣħ����������ͨ����˵���������";
        nickname.Add("�ʼǱ�");
        camp = CampEnum.all;
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Book;
        withSkill = gameObject.AddComponent<LengXiangPillSkill>();
        psy = 5;
    }
}
