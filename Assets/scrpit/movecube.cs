using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecube : MonoBehaviour
{
    public UDP UDP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.gameObject.transform.Translate(0.05f, 0, 0);
        // positionを取得して各座標を+1する
        Vector3 pos = this.gameObject.transform.position;
        int a = int.Parse(UDP.text);
        if (a == 0)

        {
            pos.x = 3.0f;
        }
        else if (a == 1)

        {
            pos.x = 0.0f;
        }
        else if (a == 2)

        {
            pos.x = -3.0f;
        }
        else
        {
            pos.x = 0.0f;
        } 
        //pos.x = -3.0f;
       // pos.y = pos.y + 1f;
        //pos.z = pos.z + 1f;

        // 新しい座標をセットする
        this.gameObject.transform.position = pos;
    }
}
