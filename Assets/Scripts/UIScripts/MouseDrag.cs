using UnityEngine;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;
///<summary>
///�����ק
///</summary>
class MouseDrag : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    /// <summary>ͼ��λ��</summary>
    private RectTransform rectTrans;
    /// <summary>���۸�����λ��</summary>
    private Transform gridPanel;
    /// <summary>���۸�����λ�ã����ڲ��ԣ�</summary>
    private Transform gridPanelForTest;
    /// <summary>����������λ��</summary>
    private Transform wordPanel;
    /// <summary>����������λ��</summary>
    private Transform testPanel;
    /// <summary>CanvasGroup���</summary>
    private CanvasGroup canvasGroup;
    /// <summary>�������ϵļ��ܽű�</summary>
    private AbstractWords0 absWord;

    /// <summary>���ݴʵļ���ԲȦ</summary>
    public GameObject adjCircle;
    /// <summary>���ʵļ���ԲȦ</summary>
    public GameObject verbCircle;
    /// <summary>���ݴ�ԲȦ���ص�λ��</summary>
    private Transform parentCircleTF;
    /// <summary>����ԲȦ���ص�λ��</summary>
    //public Transform verbCircleTF;
    public static List<AbstractVerbs> skills;

    private void Start()
    {
        rectTrans = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        absWord = GetComponent<AbstractWords0>();
        FindGrid();
    }
    /// <summary>
    /// ��ʼ��ק
    /// </summary>
    /// <param name="eventData"></param>
    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
        canvasGroup.alpha = 0.5f;
    }
    /// <summary>
    /// ������ק
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
    /// ��ק����
    /// </summary>
    /// <param name="eventData"></param>
    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f;
        //��δʹ�ã���ص����λ��
        if (rectTrans != null)
        {
            FindGrid();
        }
        //��UI������ק����ɫ����
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider != null)
        {
            Debug.Log(hit.collider.name);
            if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Character"))
            {
                if (absWord.wordSort==WordSortEnum.verb)
                {
                    skills = hit.collider.gameObject.GetComponent<AbstractCharacter>().skills;
                    skills.Add(this.GetComponent<AbstractVerbs>());
                    //���������ϵĶ��ʼ��������ӵ���ɫ����
                    AbstractVerbs b = this.GetComponent<AbstractVerbs>();
                    hit.collider.gameObject.AddComponent(b.GetType());
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
    /// ������λ���뿨��λ����ƥ��
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
