
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_YiZhiWeiShiQi : ServantAbstract
{
    override public void Awake()
    {
        base.Awake();
        characterID = 3;
        wordName = "益智喂食器";
        bookName = BookNameEnum.ZooManual;


        hp = maxHp = 30;
        atk = 0;
        def = 10;
        psy = 5;
        san = 0;

        //mainProperty.Add("防御", "肉T");
        //trait = gameObject.AddComponent<Pride>();
        roleName = "丰容";

        brief = "周期给队友提供“亢奋”";
        description = "周期给队友提供“亢奋”";

    }








  

    public override string ShowText(AbstractCharacter otherChara)
    {
        if (otherChara != null)
            return otherChara.wordName + "早已看见多了一个妹妹，细看形容，只见泪光点点，娇喘微微，闲静时如姣花照水，行动处似弱柳扶风，" + otherChara.wordName + "笑道：“这个妹妹，我曾见过的”";
        else
            return null;
    }
    public override string CriticalText(AbstractCharacter otherChara)
    {
        if (otherChara != null)
            return "“我就知道，别人不挑剩下的也不给我。”林黛玉轻捻一朵花瓣，向" + otherChara.wordName + "飞去";
        else
            return null;
    }

    public override string LowHPText()
    {
        return "黛玉对侍女喘息道：“笼上火盆罢。”便将一对帕子，一叠诗稿焚尽于火盆中。";
    }
    public override string DieText()
    {
        return "“宝玉…宝玉…你好……”黛玉没说完便合上了双眼。";
    }


}
