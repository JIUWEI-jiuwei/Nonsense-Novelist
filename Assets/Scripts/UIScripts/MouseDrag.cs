using UnityEngine;
using UnityEngine.EventSystems;
using System;

///<summary>
///�����ק
///</summary>
class MouseDrag : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    /// <summary>ͼ��λ��</summary>
    private RectTransform rectTrans;
    /// <summary>CanvasGroup���</summary>
    private CanvasGroup canvasGroup;
    /// <summary>������С����ֹ�����ƫ��</summary>
    [SerializeField] private Canvas canvas;
    /// <summary>�����λ��</summary>
    private Vector2 startpos;
    private AbstractWords0 absWord;

    private void Start()
    {
        rectTrans = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        startpos= rectTrans.anchoredPosition;
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
        rectTrans.anchoredPosition += eventData.delta/canvas.scaleFactor;
        
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
            rectTrans.anchoredPosition = startpos;
        }        
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider != null)
        {
            Debug.Log(hit.collider.name);
            if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Character"))
            {
                if (absWord.GetType() == typeof(AbstractVerbs))
                {
                    hit.collider.gameObject.GetComponent<AbstractCharacter>().skill.Add(this.GetComponent<AbstractVerbs>());

                }
                else if (absWord.GetType() == typeof(AbstractAdjectives))
                {
                    this.GetComponent<AbstractAdjectives>().UseVerbs(hit.collider.gameObject.GetComponent<AbstractCharacter>());
                }
                Destroy(this.gameObject);
            }
        }
             
    }
}
