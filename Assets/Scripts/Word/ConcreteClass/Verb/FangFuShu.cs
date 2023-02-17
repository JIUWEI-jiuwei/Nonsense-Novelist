using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ������
/// </summary>
class FangFuShu : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 5;
        wordName = "����";
        bookName = BookNameEnum.EgyptMyth;
        description = "ʹ���ѻ�á����";
        skillMode = gameObject.AddComponent<CureMode>();
        skillMode.attackRange =  new SingleSelector();
        skillEffectsTime = 20;
        rarity = 1;
        needCD = 10;
        description = "ͨ�����ӵĹ��������岻�ḯ�ܣ��ٴλ������Ļ��ᡣ";

    }
    /// <summary>
    /// ����
    /// </summary>
    /// <param name="useCharacter">ʩ����</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        buffs.Add(skillMode.CalculateAgain(attackDistance, useCharacter)[0].gameObject.AddComponent<ReLife>());
        buffs[0].maxTime = skillEffectsTime;
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        //if (character == null || aimState==null)
            //return null;

        return character.wordName + "����С��������������һ��Сȱ�ڣ�������֬�͹������С��ٽ���֬��������2��ͷ­����ֹͷ���ı��Ρ������������������ڼ����һ���£������Ϳ����������岻�������������ˡ�";

    }
}
