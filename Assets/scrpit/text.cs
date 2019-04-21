using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class text : MonoBehaviour {
    public GameObject action_object = null; // Textオブジェクト
    public UDP UDP;

    // 初期化
    void Start()
    {
    }

    // 更新
    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        Text action_text = action_object.GetComponent<Text>();
        // テキストの表示を入れ替える
        int a = int.Parse(UDP.text);
        if (a == 0)

        {
            action_text.text = "右"; 
        }
        if (a == 1)

        {
            action_text.text = "正面";
        }
        if (a == 2)

        {
            action_text.text = "左";
        }


    }
}