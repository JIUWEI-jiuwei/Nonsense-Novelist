using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// buff������
/// </summary>
public class GongZhen : AbstractBuff
{

    static public string s_description = "����ÿ��4�������񡱣���ά+1��<sprite name=\"hp\">+30";
    static public string s_wordName = "����";
    int count=0;
    /// <summary>�����ɫ����</summary>
    static int num;
    /// <summary>�ϴ������¼</summary>
    private int record;
    override protected void Awake()
    {
        base.Awake();
        buffName = "����";
        book = BookNameEnum.CrystalEnergy;
        description = "����ÿ��4�������񡱣���ά+1����������+30";

        count = GetComponents<GongZhen>().Length;
        num = Mathf.FloorToInt(count / 4);
        record = num;
        chara.maxHp += 30 * num;
        chara.def += 1 * num;
        chara.san += 1 * num;
        chara.psy += 1 * num;
        chara.atk += 1 * num;
        //if (this.GetComponents<GongZhen>().Length == 1)
        //{
        //    num++;
        //}
        //GongZhen[] all = CharacterManager.father.GetComponentsInChildren<GongZhen>();
        //foreach (GongZhen gz in all)
        //{
        //    gz.NumChanged();
        //}
    }

    //public void NumChanged()
    //{
    //    chara.atk += num - record;
    //    chara.def += num - record;
    //    chara.psy += num - record;
    //    chara.san += num - record;
    //    record = num;
    //}


    private void OnDestroy()
    {
        //chara.atk -= record;
        //chara.def -= record;
        //chara.psy -= record;
        //chara.san -= record;
        chara.maxHp -= 30 * num;
        chara.def -= 1 * num;
        chara.san -= 1 * num;
        chara.psy -= 1 * num;
        chara.atk -= 1 * num;

        //if(this.GetComponents<GongZhen>().Length==1)//��ʾ��ʣ�Լ�
        //{
        //    num--;
        //}
        //GongZhen[] all = CharacterManager.father.GetComponentsInChildren<GongZhen>();
        //foreach (GongZhen gz in all)
        //{
        //    if(gz!=this)
        //    gz.NumChanged();
        //}
    }
}
