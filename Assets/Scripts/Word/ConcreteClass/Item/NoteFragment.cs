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
        description = "������һЩ������˹д�ıʼǣ�����5�㾫��";
        nickname.Add("�ʼǱ�");
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Book;
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return character.wordName + "�ӵ��ϼ�����һ��ֽƬ����������д���ǡ���һ��ħ�������";

    }
}
