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
    public Canvas otherCanvas;
    /// <summary>Ԥ����Ŀ�¡��</summary>
    private static GameObject a;
    /// <summary>Ԥ�����е�����</summary>
    private Text[] texts=new Text[2];
    /// <summary>�����ɫ</summary>
    [HideInInspector]
    public AbstractCharacter abschara;
    /// <summary>�����ɫ���</summary>
    [HideInInspector]
    public AbstractRole absRole;
    /// <summary>�������ݴ�</summary>
    [HideInInspector]
    public AbstractAdjectives absAdj;
    /// <summary>���󶯴�</summary>
    [HideInInspector]
    public AbstractVerbs absVerbs;
    /// <summary>�����Ը�</summary>
    [HideInInspector]
    public AbstractTrait absTrait;
    /// <summary>�жϵ�ǰ�Ƿ��н�ɫ��Ϣչʾ���</summary>
    public bool isShow = false;
 
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
            if(hit.collider!=null&&hit.collider.gameObject.layer==3&&isShow==false)
            {
                //���ɽ�ɫ��Ϣ���
                a = Instantiate(propertyPanelPrefab, otherCanvas.transform);
                isShow = true;
                
                //��ȡ�����ɫ�Ľű���Ϣ
                abschara = hit.collider.GetComponent<AbstractCharacter>();
                absRole = hit.collider.GetComponent<AbstractRole>();
                absTrait = hit.collider.GetComponent<AbstractTrait>();
                if (hit.collider.GetComponent<AbstractAdjectives>())
                {
                    absAdj = hit.collider.GetComponent<AbstractAdjectives>();
                }
                else if (hit.collider.GetComponent<AbstractVerbs>())
                {
                    absVerbs = hit.collider.GetComponent<AbstractVerbs>();
                }
                Time.timeScale = 0f;
            }

        }
    }    
}
