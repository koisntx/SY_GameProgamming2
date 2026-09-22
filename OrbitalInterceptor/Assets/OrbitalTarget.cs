using UnityEngine;

public class OrbitalTarget : MonoBehaviour
{
    public Transform pointA, pointB;
    public float travelDuration;

    private float timer;
    private bool toB = true;

    // Update is called once per frame
    void Update()
    {
        //1. Add frame time to our stopwatch
        timer += Time.deltaTime;
        float t = timer / travelDuration;

        //2. CTRL + K +C, CTRL + K+U / ctrl /
        //Vector3 start, target;
        //if (toB)
        //{
        //    start = pointA.position;
        //    target = pointB.position;
        //}
        //else
        //{
        //    start = pointB.position;
        //    target = pointA.position;
        //}

        Vector3 start = toB ? pointA.position : pointB.position;
        Vector3 target = toB ? pointB.position : pointA.position;

        //3.Apply Movement
        transform.position = Vector3.Lerp(start, target, t);

        //4.If arrived on point a or b?
        if (t > 1f)
        {
            timer = 0;
            // toB = false;
            toB = !toB;
        }
    }
}
