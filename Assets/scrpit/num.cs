using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class num : MonoBehaviour
{
    public GameObject num_object = null; // Textオブジェクト
    public UDP UDP;

    // 初期化
    void Start()
    {
    }

    // 更新
    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        Text num_text = num_object.GetComponent<Text>();
        // テキストの表示を入れ替える stringでくるのでそれをfloatに
        float num = float.Parse(UDP.num)*0.01f;
        int per = (int)num;
        num_text.text = per.ToString() + "回目";//何パーセントか出す
    }
}