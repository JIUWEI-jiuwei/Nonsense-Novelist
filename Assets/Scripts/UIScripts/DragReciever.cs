using UnityEngine;
using UnityEngine.EventSystems;

///<summary>
///�����ק����Ľ�����
///</summary>
class DragReciever : MonoBehaviour, IPointerEnterHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("��ͣ");
    }
}
