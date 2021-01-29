using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//　↓先生のを参考にしました

public class BattleManager : MonoBehaviour
{

    //共有する変数
    public int test;

    //データの共有に使うインスタンス
    private static BattleManager instance;

    //インスタンスを取得できる唯一のプロパティ
    public static BattleManager Instance
    {
        get
        {
            //nullチェック
            if (null == instance)
            {
                instance = (BattleManager)FindObjectOfType(typeof(BattleManager));
                if (null == instance)
                {
                    Debug.Log(" BattleManager Instance Error ");
                }
            }
            return instance;
        }
    }

    //シーン間でもインスタンスのオブジェクトが1つになるようにする
    void Awake()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("BattleManager");
        if (1 < obj.Length)
        {
            // 既に存在しているなら削除
            Destroy(gameObject);
        }
        else
        {
            // シーン遷移では破棄させない
            DontDestroyOnLoad(gameObject);
        }
    }
}