
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_YiZhiWeiShiQi : ServantAbstract
{
    override public void Awake()
    {
        base.Awake();
        characterID = 3;
        wordName = "����ιʳ��";
        bookName = BookNameEnum.ZooManual;


        hp = maxHp = 30;
        atk = 0;
        def = 10;
        psy = 5;
        san = 0;

        //mainProperty.Add("����", "��T");
        //trait = gameObject.AddComponent<Pride>();
        roleName = "����";

        brief = "���ڸ������ṩ�����ܡ�";
        description = "���ڸ������ṩ�����ܡ�";

    }








  

    public override string ShowText(AbstractCharacter otherChara)
    {
        if (otherChara != null)
            return otherChara.wordName + "���ѿ�������һ�����ã�ϸ�����ݣ�ֻ������㣬����΢΢���о�ʱ��毻���ˮ���ж������������磬" + otherChara.wordName + "Ц������������ã����������ġ�";
        else
            return null;
    }
    public override string CriticalText(AbstractCharacter otherChara)
    {
        if (otherChara != null)
            return "���Ҿ�֪�������˲���ʣ�µ�Ҳ�����ҡ�������������һ�仨�꣬��" + otherChara.wordName + "��ȥ";
        else
            return null;
    }

    public override string LowHPText()
    {
        return "�������Ů��Ϣ���������ϻ���ա����㽫һ�����ӣ�һ��ʫ��پ��ڻ����С�";
    }
    public override string DieText()
    {
        return "�����񡭱�����á���������û˵��������˫�ۡ�";
    }


}
