using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class percent : MonoBehaviour {
    public GameObject percent_object = null; // Textオブジェクト
    public UDP UDP;

    // 初期化
    void Start()
    {
    }

    // 更新
    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        Text percent_text = percent_object.GetComponent<Text>(); 
        // テキストの表示を入れ替える stringでくるのでそれをfloatに
        float percen = float.Parse(UDP.percent);
        float per = (float)percen;
        percent_text.text = per.ToString() +"%";//何パーセントか出す
    }
}