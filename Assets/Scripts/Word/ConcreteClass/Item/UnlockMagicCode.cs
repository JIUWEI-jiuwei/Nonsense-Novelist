using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// δ�����ġ�������ħ�䡷
/// </summary>
class UnlockMagicCode : AbstractItems
{
    public override void Awake()
    {
        itemID = 4;
        wordName = "δ�����ġ�������ħ�䡷";
        bookName = BookNameEnum.StudentOfWitch;
        description = "һ��װ�λ�����ħ�䣬��������һ���۾�������ȥ������3����־��3�������";
        
    }
    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "��ιι����ɵúú����ţ���ħ���" + character.wordName + "˵����";

    }
}
