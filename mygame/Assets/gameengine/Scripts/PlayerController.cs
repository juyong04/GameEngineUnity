using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 이동 속도 (Inspector에서 조절 가능)
    public float moveSpeed = 5.0f;
    
    void Update()
    {
    
    // A키 - 왼쪽으로 이동
    if (Input.GetKey(KeyCode.A))
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        Debug.Log("왼쪽으로 이동 중!");
    }
    
    // D키 - 오른쪽으로 이동
    if (Input.GetKey(KeyCode.D))
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        Debug.Log("오른쪽으로 이동 중!");
    }
    }
}