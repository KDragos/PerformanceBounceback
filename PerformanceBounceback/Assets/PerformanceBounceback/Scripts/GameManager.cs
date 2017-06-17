using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int score;
    public Score scoreTextUpdater1;
    public Score scoreTextUpdater2;

    public void ScorePoint()
    {
        score++;
        scoreTextUpdater1.UpdateScore();
        scoreTextUpdater2.UpdateScore();
    }
}
