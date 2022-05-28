using UnityEngine;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;
///<summary>
///鼠标拖拽
///</summary>
class MouseDrag : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    /// <summary>图像位置</summary>
    private RectTransform rectTrans;
    /// <summary>卡槽父物体位置</summary>
    private Transform gridPanel;
    /// <summary>卡槽父物体位置（用于测试）</summary>
    private Transform gridPanelForTest;
    /// <summary>词条父物体位置</summary>
    private Transform wordPanel;
    /// <summary>词条父物体位置</summary>
    private Transform testPanel;
    /// <summary>CanvasGroup组件</summary>
    private CanvasGroup canvasGroup;
    /// <summary>词条身上的技能脚本</summary>
    private AbstractWords0 absWord;

    /// <summary>形容词的加载圆圈</summary>
    public GameObject adjCircle;
    /// <summary>动词的加载圆圈</summary>
    public GameObject verbCircle;
    /// <summary>形容词圆圈加载的位置</summary>
    private Transform parentCircleTF;

    private void Start()
    {
        rectTrans = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        absWord = GetComponent<AbstractWords0>();
        FindGrid();
    }
    /// <summary>
    /// 开始拖拽
    /// </summary>
    /// <param name="eventData"></param>
    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
        canvasGroup.alpha = 0.5f;
    }
    /// <summary>
    /// 正在拖拽
    /// </summary>
    /// <param name="eventData"></param>
    public void OnDrag(PointerEventData eventData)
    {
        foreach(Canvas canvas in FindObjectsOfType<Canvas>())
        {
            if (canvas.name == "MainCanvas")
            {
                rectTrans.anchoredPosition += eventData.delta / canvas.scaleFactor;
            }
        }
    }
    /// <summary>
    /// 拖拽结束
    /// </summary>
    /// <param name="eventData"></param>
    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f;
        //若未使用，则回到最初位置
        if (rectTrans != null)
        {
            FindGrid();
        }
        //将UI词条拖拽到角色身上
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider != null)
        {
            Debug.Log(hit.collider.name);
            if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Character"))
            {
                if (absWord.wordSort==WordSortEnum.verb)
                {
                    
                    //将词条身上的动词技能组件添加到角色身上
                    AbstractVerbs b = this.GetComponent<AbstractVerbs>();
                    hit.collider.gameObject.AddComponent(b.GetType());
                    hit.collider.gameObject.GetComponent<AbstractCharacter>().skills.Add(b);
                }
                else if (absWord.wordSort==WordSortEnum.adj)
                {                    
                    this.GetComponent<AbstractAdjectives>().UseVerbs(hit.collider.gameObject.GetComponent<AbstractCharacter>());                   
                }
                Destroy(this.gameObject);
            }
        }
             
    }
    /// <summary>
    /// 将词条位置与卡槽位置相匹配
    /// </summary>
    public void FindGrid()
    {
        foreach(Canvas canvas in FindObjectsOfType<Canvas>())
        {
            if (canvas.name == "MainCanvas" )
            {
                gridPanel = canvas.transform.Find("GridPanel");
                wordPanel = canvas.transform.Find("WordPanel");
                testPanel = canvas.transform.Find("TestPanel");
                gridPanelForTest = canvas.transform.Find("GridPanelForTest");
            }
        }
        for(int i = 0; i < wordPanel.childCount; i++)
        {
           wordPanel.GetChild(i).position = gridPanel.GetChild(i).position;
        }
        for(int i = 0; i < testPanel.childCount; i++)
        {
            testPanel.GetChild(i).position = gridPanelForTest.GetChild(i).position;
        }
    }
}
