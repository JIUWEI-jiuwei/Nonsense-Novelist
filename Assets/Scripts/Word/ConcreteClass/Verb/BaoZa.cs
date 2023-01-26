using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class BaoZa : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 17;
        wordName = "����";
        bookName = BookNameEnum.allBooks;
        description = "ѧ�����飬���150%��������ħ���˺�������Ŀ���ɥ��";
        nickname.Add( "��ʹ");
        skillMode = gameObject.AddComponent<CureMode>();
        skillMode.attackRange = new SingleSelector();
        skillEffectsTime = Mathf.Infinity;
        rarity = 1;
        needCD=2;
    }

    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        SpecialAbility(useCharacter);
    }

    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        skillMode.CalculateAgain(attackDistance, useCharacter)[0].hp += 40;
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return character.wordName + "���İ�֮�˶���˵�����ž������⣬������������������ʹ������";

    }

}
