using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///<summary>
///
///</summary>
class test : MonoBehaviour
{

    private void Update()
    {
        this.GetComponent<Image>().sprite = Resources.Load<Sprite>("������");
        Debug.Log(Resources.Load<Sprite>("������"));
        Debug.Log(Resources.Load("������"));
    }
}
