using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ·¢ÉäÆ÷
/// </summary>
public class RollControler : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
       
            //¼ÆËã½Ç¶È
            Vector3 clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector2 dic1 = Vector2.down;
            Vector2 dic2 = transform.position - clickPos;

            Vector3 v3 = Vector3.Cross(dic1, dic2);

            float angle = 0;
            if (v3.z > 0)
                angle = Vector3.Angle(dic1, dic2);
            else
                angle = 360 - Vector3.Angle(dic1, dic2);

            transform.eulerAngles = new Vector3(0, 0, angle);
    }

}