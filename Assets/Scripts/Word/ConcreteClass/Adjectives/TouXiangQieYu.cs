using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ͵������
/// </summary>
class TouXiangQieYu : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.adj;
        adjID = 1;
        wordName = "͵������";
        bookName = BookNameEnum.HongLouMeng;
        description = "��Ů��͵�飬�����������ȥ�����¶�������";
        chooseWay = ChooseWayEnum.canChoose;
        banAim.Add(gameObject.AddComponent<Girl>());
        skillMode=gameObject.AddComponent<DamageMode>();
        useAtFirst = false;
    }

    
    
    override public void UseVerbs(AbstractCharacter aimCharacter)
    {
        
        skillMode.UseMode(null, 20 *(1- aimCharacter.san/(aimCharacter.san+20)), aimCharacter);
    }

    public override void SpecialAbility(AbstractCharacter aimCharacter)
    {
       
    }

    public override string PlaySentence()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return character.wordName + "˵������ү���������ðɡ���";

    }
}
