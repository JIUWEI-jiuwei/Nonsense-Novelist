using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///<summary>
///��������� ��ʾ��Ϣ
///</summary>
class MouseDown : MonoBehaviour
{
    /// <summary>�������Ԥ����</summary>
    public GameObject propertyPanelPrefab;
    /// <summary>UIcanvas</summary>
    public Canvas UIcanvas;
    /// <summary>Ԥ����Ŀ�¡��</summary>
    private static GameObject a;
    /// <summary>Ԥ�����е�����</summary>
    private Text[] texts=new Text[2];
    /// <summary>�����ɫ</summary>
    private AbstractCharacter abschara;
    /// <summary>�����ɫ</summary>
    private AbstractRole absRole;

 
    private void Update()
    {
        MouseDownView();
    }  
    /// <summary>
    /// ȫ���������
    /// </summary>
    private void MouseDownView()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector2.zero);
            if(hit.collider!=null)
            {
                a = Instantiate(propertyPanelPrefab, UIcanvas.transform);
                abschara = hit.collider.GetComponent<AbstractCharacter>();
                absRole = hit.collider.GetComponent<AbstractRole>();
                //��texts�����ȡ������Text���
                for (int i = 0; i < texts.Length ; i++)
                {
                   texts[i] = a.transform.GetChild(i + 2).GetComponent<Text>();
                }
                texts[0].text = "�������   " + absRole.roleName;
                texts[1].text = "Ѫ��       " + abschara.maxHP.ToString();
                //texts[2].text = "����       " + abschara.maxSP.ToString();
                //texts[3].text = "������     " + abschara.atk.ToString();
                //texts[4].text = "������     " + abschara.def.ToString();
                //texts[5].text = "������     " + abschara.san.ToString();
                //texts[6].text = "��־��     " + abschara.psy.ToString();
                //texts[7].text = "�����Ը�   " + abschara.trait.ToString();
                //texts[8].text = "��������   " + abschara.criticalChance.ToString();
                //texts[9].text = "��������   " + abschara.multipleCriticalStrike.ToString();
                //texts[10].text = "�����ٶ�  " + abschara.attackInterval.ToString();
                //texts[11].text = "�����ٶ�  " + abschara.skillSpeed.ToString();
                //texts[12].text = "���ܼ���  " + abschara.dodgeChance.ToString();
                //texts[13].text = "����ֵ  " + abschara.luckyValue.ToString();
            }

        }
    }
    /// <summary>
    /// �������Ĺرհ�ť����Ԥ����ҽű�����ֵ��
    /// </summary>
    public void propertyButtonDown()
    {
        Destroy(a);
        Debug.Log("button"+a.name);
    }
}
