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
        getWay = GetWayEnum.FromStory;
        description = "������һЩ������˹д�������ˣħ����������ͨ����˵���������";
        nickname.Add("�ʼǱ�");
        camp = CampEnum.all;
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Book;
        camp = CampEnum.friend;
        withSkill = gameObject.AddComponent<FireBall>();
        psy = 5;
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return character.wordName + "�ӵ��ϼ�����һ��ֽƬ����������д���ǡ���һ��ħ�������";

    }
}
