using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class ToBigger : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 16;
        wordName = "���";
        bookName = BookNameEnum.allBooks;
        description = "ѧ�����飬���150%��������ħ���˺�������Ŀ���ɥ��";
        nickname.Add( "��ʹ");
        skillMode = gameObject.AddComponent<SelfMode>();
        skillMode.attackRange = new SingleSelector();
        skillEffectsTime = Mathf.Infinity;
        rarity = 1;
        needCD=3;
    }

    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        BasicAbility(useCharacter);
    }

    public override void BasicAbility(AbstractCharacter useCharacter)
    {
        useCharacter.maxHP += 20;
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return character.wordName + "���İ�֮�˶���˵�����ž������⣬������������������ʹ������";

    }

}
