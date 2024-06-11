using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActive : MonoBehaviour
{
    public float[] Min;
    public float[] Max;
    public float Speed;

    private void Update()
    {
        MoveH();
        MoveV();
    }

    private void MoveV()
    {
        float input = Input.GetAxis("Vertical");
        float MoveAmount = input * Speed * Time.deltaTime;
        Vector3 currentPosition = transform.position;
        float positionX = currentPosition.y + MoveAmount;
        float clampX = Mathf.Clamp(positionX, Min[1], Max[1]);
        transform.position = new Vector3(currentPosition.x,clampX, currentPosition.z);
    }

    private void MoveH()
    {
        float input = Input.GetAxis("Horizontal");
        float MoveAmount = input * Speed * Time.deltaTime;
        Vector3 currentPosition = transform.position;
        float newpositionX = currentPosition.x + MoveAmount;
        float clampX = Mathf.Clamp(newpositionX, Min[0], Max[0]);
        transform.position = new Vector3(clampX, currentPosition.y, currentPosition.z);
    }
}
