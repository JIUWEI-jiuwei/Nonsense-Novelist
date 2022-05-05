using UnityEngine;
using UnityEngine.EventSystems;
using System;

///<summary>
///鼠标拖拽
///</summary>
class MouseDrag : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    /// <summary>图像位置</summary>
    private RectTransform rectTrans;
    /// <summary>CanvasGroup组件</summary>
    private CanvasGroup canvasGroup;
    /// <summary>画布大小（防止鼠标跑偏）</summary>
    [SerializeField] private Canvas canvas;
    /// <summary>最初的位置</summary>
    private Vector2 startpos;
    private AbstractWords0 absWord;

    private void Start()
    {
        rectTrans = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        startpos= rectTrans.anchoredPosition;
        absWord = GetComponent<AbstractWords0>();
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
        rectTrans.anchoredPosition += eventData.delta/canvas.scaleFactor;
        
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
            rectTrans.anchoredPosition = startpos;
        }
        //将UI词条拖拽到角色身上
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider != null)
        {
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
