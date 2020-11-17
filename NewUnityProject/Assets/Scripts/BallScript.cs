using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{

    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(5f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, 0f, 1 * speed * Time.deltaTime);

        // ボールを逃したらゲームオーバー
        if (transform.position.z > 15.0f)
        {
            //Debug.Log("GAVE OVER");
            //Time.timeScale = 0; // ゲームを止める
            SceneManager.LoadScene("GameOverScene");
        }
    }

    // 何かと衝突したときの処理を記述
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Paddle"))
        {
            Destroy(gameObject);

            // ボールに衝突するとパドルを小さくする
            collision.gameObject.transform.localScale -= new Vector3(Random.Range(0.2f, 1.0f), 0f, 0f);
            if(collision.gameObject.transform.localScale.x < 1.0f)
            {
                collision.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
        }
        
    }


}
