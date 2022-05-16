using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �豭
/// </summary>
class TeaCup : AbstractItems
{
    public void Awake()
    {
        itemID = 1;
        wordName = "�豭";
        bookName = BookNameEnum.HongLouMeng;
        getWay = GetWayEnum.NormalWord;
        description = "һ���൱���µĲ豭";
        VoiceEnum = MaterialVoiceEnum.Ceram;
        san = 3;
    }

    public override string PlaySentence()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

            return character.wordName+"�ó���һ���ϴ���С�ı��̷��β豭��";
        
    }
}
