
using UnityEngine;
using UnityEngine.UI;

///<summary>
///��ɫ��Ϣ���
///</summary>
class CharacterDetails : MonoBehaviour
{
    public Text[] texts1;
    public Text[] texts2;
    public Text[] texts3;

    /// <summary>��ȡmousedown�ű� </summary>
    private MouseDown mouseDown;

    private void Start()
    {
        mouseDown= GameObject.Find("MainCamera").GetComponent<MouseDown>();
        
    }
    private void Update()
    {
        //״̬��Ϣ���
        //HP
        texts1[0].text = mouseDown.abschara.hp.ToString() + "/" + mouseDown.abschara.maxHP.ToString();
        //ATK
        texts1[1].text = IntToString.SwitchATK(mouseDown.abschara.atk);
        //san
        texts1[2].text = IntToString.SwitchATK(mouseDown.abschara.san);
        //SP
        texts1[3].text = mouseDown.abschara.sp.ToString() + "/" + mouseDown.abschara.maxSP.ToString();
        //def
        texts1[4].text = IntToString.SwitchATK(mouseDown.abschara.def);
        //atkInterval
        texts1[5].text = IntToString.SwitchATK(mouseDown.abschara.attackInterval);
        //EXP
        texts1[6].text = mouseDown.abschara.exp.ToString() + "/100";
        //psy
        texts1[7].text = IntToString.SwitchATK(mouseDown.abschara.psy);
        //
        texts1[8].text = IntToString.SwitchATK(mouseDown.abschara.skillSpeed);

        //������Ϣ���
        if (mouseDown.absAdj)
        {
            texts2[0].text = mouseDown.absAdj.wordName;
            texts2[1].text = mouseDown.absAdj.description;
            
        }
        else if (mouseDown.absVerbs)
        {
            texts2[0].text = mouseDown.absVerbs.wordName;
            texts2[1].text = mouseDown.absVerbs.description;
        }
        //������Ϣ���
        texts3[0].text = "��ݣ�"+mouseDown.absRole.roleName;
        texts3[1].text = "�Ը�" + mouseDown.absTrait.traitName;
        texts3[2].text = mouseDown.abschara.brief;
    }
    /// <summary>
    /// �������Ĺرհ�ť����Ԥ����ҽű�����ֵ��
    /// </summary>
    public void CloseCharaPanel()
    {
        Destroy(this.transform.parent.gameObject);
        mouseDown.isShow = false;
    }
}
