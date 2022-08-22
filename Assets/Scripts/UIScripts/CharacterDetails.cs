using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///<summary>
///��ɫ��Ϣ��壨���ڸ�����Ԥ���屾��
///</summary>
class CharacterDetails : MonoBehaviour
{
    public Text[] texts1;
    public Text[] texts2;
    public Text[] texts3;
    public Text[] texts4;
    public GameObject importantPanel;
    private List<GameObject> importantImage=new List<GameObject>();
    public GameObject imagePrefab;
    public Image charaName;
    public Image charaImage;

    /// <summary>��ȡmousedown�ű� </summary>
    private MouseDown mouseDown;

    private void Start()
    {
        mouseDown= GameObject.Find("MainCamera").GetComponent<MouseDown>();
        //��ȡ��Ҫ֮��
        for (int i = 0; i < mouseDown.abschara.importantNum.Count; i++)
        {
            GameObject a = Instantiate(imagePrefab);
            importantImage.Add(a);
            importantImage[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("FirstStageLoad/" + "head" + mouseDown.abschara.importantNum[i].ToString());
            importantImage[i].transform.SetParent(importantPanel.transform);
            a.transform.localScale = new Vector3(1, 1, 1);//�������SetParent����
        }
        //������Ϣ���
        texts3[0].text = "��ݣ�" + mouseDown.absRole.roleName;
        texts3[1].text = "�Ը�" + mouseDown.absTrait.traitName;
        texts3[2].text = mouseDown.abschara.brief;

        //��ɫ����ͼƬ
        charaName.sprite = Resources.Load<Sprite>("FirstStageLoad/" + "Character_" + mouseDown.abschara.wordName);
        charaImage.sprite = Resources.Load<Sprite>("FirstStageLoad/" + mouseDown.abschara.wordName);

        //״̬���
        texts4[0].text= mouseDown.absTrait.traitName;
        texts4[1].text = mouseDown.absRole.roleName;

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
    }
    /// <summary>
    /// �������Ĺرհ�ť����Ԥ����ҽű�����ֵ��
    /// </summary>
    public void CloseCharaPanel()
    {
        Destroy(this.transform.parent.gameObject);
        Time.timeScale = 1f;
        mouseDown.isShow = false;
    }
}
