using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public Transform spawnArea;
    public int maxBallAmount;
    public int spawnInterval;
    //public Vector2 powerUpAreaMin;
    //public Vector2 powerUpAreaMax;

    public List<GameObject> BallTemplateList;
    private List<GameObject> BallList;

    private float timer;

    private void Start()
    {
        BallList = new List<GameObject>();
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnInterval)
        {
            SpawnBall();
            timer -= spawnInterval;
        }
    }

    public void SpawnBall()
    {
        if (BallList.Count >= maxBallAmount)
        {
            return;
        }
        int randomBall = Random.Range(0, BallTemplateList.Count);

        GameObject ball = Instantiate(BallTemplateList[randomBall], new Vector3(BallTemplateList[randomBall].transform.position.x, BallTemplateList[randomBall].transform.position.y, BallTemplateList[randomBall].transform.position.z), Quaternion.identity, spawnArea);
        ball.SetActive(true);
        BallList.Add(ball);
    }

    public void RemoveBall(GameObject ball)
    {
        BallList.Remove(ball);
        Destroy(ball);
    }

    //public void GenerateRandomBall()
    //{
    //    GenerateRandomBall(new Vector3(Random.Range(powerUpAreaMin.x, powerUpAreaMax.x), Random.Range(powerUpAreaMin.y, powerUpAreaMax.y)));
    //}

    //public void GenerateRandomBall(Vector2 position)
    //{
    //    if (powerUpList.Count >= maxPowerUpAmount)
    //    {
    //        return;
    //    }

    //    if (position.x < powerUpAreaMin.x ||
    //        position.x > powerUpAreaMax.x ||
    //        position.y < powerUpAreaMin.y ||
    //        position.y > powerUpAreaMax.y)
    //    {
    //        return;
    //    }
    //    int randomIndex = Random.Range(0, powerUpTemplateList.Count);

    //    GameObject powerUp = Instantiate(powerUpTemplateList[randomIndex], new Vector3(position.x, position.y, powerUpTemplateList[randomIndex].transform.position.z), Quaternion.identity, spawnArea);
    //    powerUp.SetActive(true);

    //    powerUpList.Add(powerUp);
    //}

    //public void RemovePowerUp(GameObject powerUp)
    //{
    //    powerUpList.Remove(powerUp);
    //    Destroy(powerUp);
    //}

    //public void RemoveAllPowerUp()
    //{
    //    while (powerUpList.Count > 0)
    //    {
    //        RemovePowerUp(powerUpList[0]);
    //    }
    //}
}
