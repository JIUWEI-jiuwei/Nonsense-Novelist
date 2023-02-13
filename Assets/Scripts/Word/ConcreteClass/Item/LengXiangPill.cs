using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ������
/// </summary>
class LengXiangPill : AbstractItems
{
    public override void Awake()
    {
        itemID = 2;
        wordName = "������";
        bookName = BookNameEnum.HongLouMeng;
        description = "һö�����൱���ӵ�ҩ�裬����3�������";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.materialNull;
        rarity = 1;
        nowTime = 0;
        wordCollisionShoots.Add(gameObject.AddComponent<XuWu>());
    }
    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        chara.def++;
    }

    float nowTime;
    public override void UseVerbs()
    {
        base.UseVerbs();
        nowTime += Time.deltaTime;
        if(nowTime>1)
        {
            nowTime= 0;
            aim.hp += 3;
        }

    }

    public override void End()
    {
        base.End();
        aim.def--;
    }
    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "��ĵ������׺ɻ������ܽ�ػ����÷������......��ʮ��δ�ض����������������������أ���" + character.wordName + "˵����";

    }
}
