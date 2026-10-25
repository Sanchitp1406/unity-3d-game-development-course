using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveThePlayer();
    }

    void MoveThePlayer()
    {
        float xValue, yValue = 0, zValue, PlayerSpeed = 10f;

        xValue = Input.GetAxis("Horizontal") * PlayerSpeed * Time.deltaTime;
        zValue = Input.GetAxis("Vertical") * PlayerSpeed * Time.deltaTime;

        transform.Translate(xValue, yValue, zValue);
    }

}
