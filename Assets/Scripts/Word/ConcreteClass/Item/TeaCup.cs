using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �豭
/// </summary>
class TeaCup : AbstractItems
{
    public override void Awake()
    {
        itemID = 1;
        wordName = "�豭";
        bookName = BookNameEnum.HongLouMeng;
        description = "һ���൱���µĲ豭������3����־";
        VoiceEnum = MaterialVoiceEnum.Ceram;
        rarity = 0;
    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        chara.psy += 2;
    }

    public override void UseVerbs()
    {
        base.UseVerbs();

    }

    public override void End()
    {
        base.End();
        aim.psy-= 2;
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

            return character.wordName+"�ó���һ���ϴ���С�ı��̷��β豭��";
        
    }
}
