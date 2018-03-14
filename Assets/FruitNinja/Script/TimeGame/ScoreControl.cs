using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class ScoreControl : MonoBehaviour {

	public Text scoreTxt;
	public Text scoreTxtApple;
	public Text scoreTxtBanana;
	public Text scoreTxtBasaha;
	public Text scoreTxtPeach;
	public Text scoreTxtSandia;
	public int score = 0;
	public int AppleScore = 0;
	public int BananaScore = 0;
	public int BasahaScore = 0;
	public int PeachScore = 0;
	public int SandiaScore = 0;

    private float lastScoreTime;
    private float currentTime;
    private static ScoreControl instance = null;

	void Awake(){
		instance = this;
	}

    void Start()
    {
        LastScoreTime = Time.time + 2.5f;
    }

	void Update () {
		scoreTxt.text = score + "";
		scoreTxtApple.text = AppleScore + "";
		scoreTxtBanana.text = BananaScore + "";
		scoreTxtBasaha.text = BasahaScore + "";
		scoreTxtPeach.text = PeachScore + "";
		scoreTxtSandia.text = SandiaScore + "";
        if (Time.time - LastScoreTime >= 5.0f && !ShowExitInGame.ifExitShowed)
        {
            MessageDispatcher.Instance.dispatchMessage(0.0f, Singleton.gameType, MessageType.Msg_ShowExitInGame, new Vector2(0, 0), 0);
            //Debug.Log(LastScoreTime.ToString());
            LastScoreTime = Time.time;
        }
	}
	public static ScoreControl Instance{
		get{
			return instance;
		}
	}

    public float LastScoreTime
    {
        get
        {
            return lastScoreTime;
        }
        set
        {
            lastScoreTime = value;
        }
    }

    public float CurrentTime
    {
        get
        {
            return currentTime;
        }

        set
        {
            currentTime = value;
        }

    }
}
