using UnityEngine;

public class BallFactroryScript : MonoBehaviour
{

    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        // ボールのインスタンスを生成
        // Instantiate(ball, transform.position, transform.rotation);
        // 一定時間ごとに指定した命令を実行
        InvokeRepeating("SpawnBall", 0f, 1f);
    }

    void SpawnBall()
    {
        Instantiate(ball, new Vector3(Random.Range(-5f, 5f), transform.position.y, transform.position.z), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
