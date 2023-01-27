using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��ҩ
/// </summary>
class YiZhiWeiShiQi : AbstractItems
{
    public override void Awake()
    {
        itemID = 4;
        wordName = "����ιʳ��";
        bookName = BookNameEnum.ZooManual;
        description = "һö�����൱���ӵ�ҩ�裬����3�������";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.materialNull;
        rarity = 2;

        nowTime = 0;
        skillMode = new CureMode();
    }

    float nowTime;
    AbstractSkillMode skillMode;
    AbstractCharacter[] friends;
    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        friends= skillMode.CalculateAgain(999, aim);
        foreach (AbstractCharacter friend in friends)
        {
            friend.psy++;
        }
    }

    public override void UseVerbs()
    {
        base.UseVerbs();
        nowTime += Time.deltaTime;
        if (nowTime > 1)
        {
            nowTime = 0;
            friends = skillMode.CalculateAgain(999, aim);
            friends[0].hp += 3;
        }
    }

    public override void End()
    {
        base.End();
    }
    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "��ĵ������׺ɻ������ܽ�ػ����÷������......��ʮ��δ�ض����������������������أ���" + character.wordName + "˵����";

    }
}
