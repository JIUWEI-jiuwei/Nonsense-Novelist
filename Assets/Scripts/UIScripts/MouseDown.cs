using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    private GameObject a;

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
                Debug.Log(hit.collider.name);
                a = Instantiate(propertyPanelPrefab, UIcanvas.transform);
               
            }

        }
    }
    /// <summary>
    /// �������Ĺرհ�ť
    /// </summary>
    public void propertyButtonDown()
    {
        Destroy(a);
    }
}
