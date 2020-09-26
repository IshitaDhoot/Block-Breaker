using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    [SerializeField] float screenWidthInUnits = 16f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePosition = Input.mousePosition.x/Screen.width * screenWidthInUnits;
        Vector2 paddlePosition = new Vector2(mousePosition, transform.position.y);
        paddlePosition.x = Mathf.Clamp(mousePosition, minX, maxX);
        transform.position = paddlePosition;
    }
}
