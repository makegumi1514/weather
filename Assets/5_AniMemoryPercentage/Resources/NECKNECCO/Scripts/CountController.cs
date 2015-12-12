using UnityEngine;
using System.Collections;

public class CountController : MonoBehaviour {
	[SerializeField]
	SpriteRenderer digit1;//前半演出数値の1の位のスプライト.
	[SerializeField]
	SpriteRenderer digit10;//前半演出数値の10の位スプライト.

    [SerializeField]
	SpriteRenderer resultDigit1;//結果数値の1の位のスプライト.
	[SerializeField]
	SpriteRenderer resultDigit10;//結果数値の10の位のスプライト.

    [SerializeField]
	GameObject d10;//結果数値が2桁以下の場合の数値オブジェクト.
    [SerializeField]
	GameObject d100;//結果数値が3桁の場合の数値オブジェクト.

    [SerializeField]
	Sprite[] textSprite = new Sprite[10];//数字画像配列.
	
	int countDigit1;
	int countDigit10;

	public int countResult;//結果数値変数.

	void Start () {
	
	}

	void Update () {
        //前半演出時の数値の切り替え.
		countDigit1 = Random.Range (0, 10);
		countDigit10 = Random.Range (0, 10);

		digit1.sprite = textSprite [countDigit1];
		digit10.sprite = textSprite [countDigit10];

	}

    //アニメーションで呼び出す用の、結果数値の表示のための関数.
	public void Result()
	{
		if (countResult.ToString ().Length == 1) 
		{
			d10.SetActive(true);
			d100.SetActive(false);
			resultDigit1.sprite = textSprite [countResult];
			resultDigit10.sprite = textSprite [0];
		}
        else if (countResult.ToString ().Length == 2)
		{
			d10.SetActive(true);
			d100.SetActive(false);
			int r10 = countResult / 10;
			int r1 = countResult - (r10 * 10);
			resultDigit1.sprite = textSprite [r1];
			resultDigit10.sprite = textSprite [r10];
		}
        else if (countResult.ToString ().Length == 3)
		{
			d10.SetActive(false);
			d100.SetActive(true);
		}
	}
}
