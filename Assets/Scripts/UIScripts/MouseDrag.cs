using UnityEngine;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;

///<summary>
///�����ק
///</summary>
class MouseDrag : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    /// <summary>ͼ��λ��</summary>
    private RectTransform rectTrans;
    /// <summary>���۸�����λ��</summary>
    private Transform gridPanel;
    /// <summary>����������λ��</summary>
    private Transform wordPanel;
    /// <summary>����������λ��</summary>
    private Transform testPanel;
    /// <summary>CanvasGroup���</summary>
    private CanvasGroup canvasGroup;
    /// <summary>�������ϵļ��ܽű�</summary>
    private AbstractWords0 absWord;

    private void Awake()
    {
    }
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
                    
                    hit.collider.gameObject.GetComponent<AbstractCharacter>().skills.Add(this.GetComponent<AbstractVerbs>());

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
            }
        }
        for(int i = 0; i < wordPanel.childCount; i++)
        {
           wordPanel.GetChild(i).position = gridPanel.GetChild(i).position;
        }
        for(int i = 0; i < testPanel.childCount; i++)
        {
            testPanel.GetChild(i).position = gridPanel.GetChild(i).position;
        }
    }
}
