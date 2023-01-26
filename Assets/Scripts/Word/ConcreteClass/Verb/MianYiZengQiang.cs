using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class MianYiZengQiang : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 12;
        wordName = "����";
        bookName = BookNameEnum.FluStudy;
        description = "ѧ����������ö��ѻ�ø���Ļ��ᣬ����20�롣";
        skillMode = gameObject.AddComponent<CureMode>();
        skillMode.attackRange =  new SingleSelector();
        skillEffectsTime = Mathf.Infinity;
        rarity = 2;
        needCD =3;
        description = "ͨ�����ӵĹ��������岻�ḯ�ܣ��ٴλ������Ļ��ᡣ";

    }
    /// <summary>
    /// ����
    /// </summary>
    /// <param name="useCharacter">ʩ����</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        SpecialAbility(useCharacter);
    }

    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
       AbstractCharacter aim= skillMode.CalculateAgain(attackDistance,useCharacter)[0];
        aim.hp += 30;
        aim.maxHP += 20;
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        //if (character == null || aimState==null)
            //return null;

        return character.wordName + "����С��������������һ��Сȱ�ڣ�������֬�͹������С��ٽ���֬��������2��ͷ­����ֹͷ���ı��Ρ������������������ڼ����һ���£������Ϳ����������岻�������������ˡ�";

    }
}
