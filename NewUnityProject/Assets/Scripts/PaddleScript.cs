using UnityEngine;

public class PaddleScript : MonoBehaviour
{

    // privateだとインスペクターから変更できない
    // private float speed;
    public float speed; 

    // Start is called before the first frame update
    void Start()
    {
        // speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3は浮動小数点数を引数に取る Vector3(x, y, z)
        // Input.GetAxis("Horizontal") 左キーで-1、右キーで1
        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0f, 0f);
        // Debug.Log(transform.position.x);
    }
}
