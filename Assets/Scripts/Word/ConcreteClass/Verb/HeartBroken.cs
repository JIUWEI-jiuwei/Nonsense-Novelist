using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ����
/// </summary>
class HeartBroken : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 14;
        wordName = "����";
        bookName = BookNameEnum.allBooks;
        description = "ʹ���˻�á���ɥ��";
        nickname.Add( "��ʹ");
        skillMode = gameObject.AddComponent<SelfMode>();
        skillMode.attackRange = new SingleSelector();
        skillEffectsTime = 2;
        rarity = 1;
        needCD=2;
    }

    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        buffs.Add(gameObject.AddComponent<Upset>());
        buffs[0].maxTime = skillEffectsTime;
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return character.wordName + "���İ�֮�˶���˵�����ž������⣬������������������ʹ������";

    }

}
