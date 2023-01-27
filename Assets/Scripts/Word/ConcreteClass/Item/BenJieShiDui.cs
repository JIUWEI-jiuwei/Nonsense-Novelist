using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��ҩ
/// </summary>
class BenJieShiDui : AbstractItems
{
    public override void Awake()
    {
        itemID = 3;
        wordName = "����ʿ��";
        bookName = BookNameEnum.ZooManual;
        description = "һö�����൱���ӵ�ҩ�裬����3�������";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.materialNull;
        rarity = 2;

        nowTime = 0;
        skillMode = new CureMode();
    }
    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
    }

    float nowTime;
    AbstractSkillMode skillMode;
    AbstractCharacter[] friends;
    public override void UseVerbs()
    {
        base.UseVerbs();
        nowTime += Time.deltaTime;
        if(nowTime>10)
        {
            nowTime= 0;
            friends = skillMode.CalculateAgain(999, aim);

            buffs.Add(friends[Random.Range(0,friends.Length)].gameObject.AddComponent<KangFen>());
            buffs[0].maxTime = 10;
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
