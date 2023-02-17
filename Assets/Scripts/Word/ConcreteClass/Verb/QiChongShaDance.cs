using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ����ɴ֮��
/// </summary>
class QiChongShaDance : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 6;
        wordName = "����ɴ֮��";
        bookName = BookNameEnum.Salome;
        description = "ʹ�Լ���á����衱";
        skillMode = gameObject.AddComponent<SelfMode>();
        skillMode.attackRange = new SingleSelector();
        skillEffectsTime =10;
        rarity = 3;
        needCD=10;
        description = "ÿһ�ض���ж��һ�㱡ɴ�������赸������Χ���Ѿ�����������";
    }

    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        buffs.Add(gameObject.AddComponent<QiWu>());
        buffs[0].maxTime = skillEffectsTime;
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "������������Ϲ�׹��ײ�Ľ�������" + character.wordName + "��ʼ�������衣��Χ�����Ƕ��׷ױ���������������˼����ˣ����Ҹо�������������";

    }
}
