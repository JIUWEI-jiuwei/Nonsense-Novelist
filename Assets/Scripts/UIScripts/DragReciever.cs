using UnityEngine;
using UnityEngine.EventSystems;

///<summary>
///鼠标拖拽物体的接收者
///</summary>
class DragReciever : MonoBehaviour, IPointerEnterHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("悬停");
    }
}
