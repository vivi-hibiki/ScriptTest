using System.Collections;
using System.Collections.Generic;
using UnityEngine;public class Boss
{
    private int hp = 100;   // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; // 攻撃力
    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log( this.power + "のダメージを与えた" );
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log( damage+"のダメージを受けた" );
    
        this.hp -= damage;
    }

   public void Magic()
    {
        // MPが5以上ある場合
        if (mp >= 5)
        {
            // MPを5減らす
            mp -= 5;
            // 残りのMPを表示
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            // MPが足りない場合のメッセージを表示
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }


}

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start ()
    {
        // 配列を初期化する
    int[] points = {1, 2, 3, 4, 5,};

        // 配列の要素数のぶんだけ処理を繰り返す
        for (int i = 0; i < points.Length; i++)
        {
        
            if( points[i] >=0)
            {
                // 配列の要素を表示する
                Debug.Log (points [i]);
            }
        }

     for (int i = points.Length-1; i >= 0; i--)
        {
        
            if( points[i] >=0)
            {
                // 配列の要素を表示する
                Debug.Log (points [i]);
            }
        }

    // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss ();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
         // Bossクラスの変数を宣言してインスタンスを代入
        // Magic関数を10回呼び出す
        for (int i = 0; i < 10; i++)
        {
            lastboss.Magic();
        }
        lastboss.Magic();
    }
    

   
    void Update ()
    {

    }
}