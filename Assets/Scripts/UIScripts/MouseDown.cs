using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
///鼠标点击物体 显示信息
///</summary>
class MouseDown : MonoBehaviour
{
    /// <summary>属性面板预制体</summary>
    public GameObject propertyPanelPrefab;
    /// <summary>UIcanvas</summary>
    public Canvas UIcanvas;
    /// <summary>预制体的克隆体</summary>
    private GameObject a;

    private void Update()
    {
        MouseDownView();
    }  
    /// <summary>
    /// 全局鼠标射线
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
    /// 属性面板的关闭按钮
    /// </summary>
    public void propertyButtonDown()
    {
        Destroy(a);
    }
}
