using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyInput : MonoBehaviour
{
    [SerializeField] float RSpeed;
    [SerializeField] float LSpeed;

    public float Rx { get; private set; }
    public float Ry { get; private set; }
    public float Lx { get; private set; }
    public float Ly { get; private set; }

    void Update()
    {
        float deltaTime = Time.deltaTime;

        Ry = Sensor(KeyCode.UpArrow, 1 * RSpeed, deltaTime, Ry);
        Ry = Sensor(KeyCode.DownArrow, -1 * RSpeed, deltaTime, Ry);
        Rx = Sensor(KeyCode.RightArrow, 1 * RSpeed, deltaTime, Rx);
        Rx = Sensor(KeyCode.LeftArrow, -1 * RSpeed, deltaTime, Rx);

        Ly = Sensor(KeyCode.W, 1 * LSpeed, deltaTime, Ly);
        Ly = Sensor(KeyCode.S, -1 * LSpeed, deltaTime, Ly);
        Lx = Sensor(KeyCode.D, 1 * RSpeed, deltaTime, Lx);
        Lx = Sensor(KeyCode.A, -1 * LSpeed, deltaTime, Lx);
    }

    float Sensor(KeyCode keyCode, float speed, float timer, float senser)
    {
        if (Input.GetKey(keyCode))
        {
            senser += timer * speed;
        }
        else if (Input.GetKeyDown(keyCode))
        {
            senser = 0;
        }
        return senser;
    }
}
