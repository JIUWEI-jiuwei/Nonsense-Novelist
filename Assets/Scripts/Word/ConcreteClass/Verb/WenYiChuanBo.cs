using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class WenYiChuanBo : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 11;
        wordName = "���ߴ���";
        bookName = BookNameEnum.FluStudy;
        description = "ѧ����������ö��ѻ�ø���Ļ��ᣬ����20�롣";
        skillMode = gameObject.AddComponent<DamageMode>();
        (skillMode as DamageMode).isPhysics = true;
        skillMode.attackRange =  new SingleSelector();
        skillEffectsTime = 5;
        rarity = 2;
        needCD = 2;
        description = "ͨ�����ӵĹ��������岻�ḯ�ܣ��ٴλ������Ļ��ᡣ";

    }

    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        AbstractCharacter center = skillMode.CalculateAgain(attackDistance, useCharacter)[0];
        //���ĵõ�����
        buffs.Add(center.gameObject.AddComponent<ChuanBo>());
        //���ڵõ�����
        AbstractCharacter[] neighbors = (buffs[0] as ChuanBo).GetNeighbor(center);
        foreach (AbstractCharacter n in neighbors)
        {
            buffs.Add(n.gameObject.AddComponent<Ill>());
        }
        //���ĵõ�����
        buffs.Add(center.gameObject.AddComponent<Ill>());

        foreach (AbstractBuff buff in buffs)
        {
            buff.maxTime = skillEffectsTime;
        }
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        //if (character == null || aimState==null)
            //return null;

        return character.wordName + "����С��������������һ��Сȱ�ڣ�������֬�͹������С��ٽ���֬��������2��ͷ­����ֹͷ���ı��Ρ������������������ڼ����һ���£������Ϳ����������岻�������������ˡ�";

    }
}
