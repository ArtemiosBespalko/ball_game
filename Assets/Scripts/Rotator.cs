using UnityEngine;

public class Rotator : MonoBehaviour
{
    Quaternion originRotation;
    float angle;
    public float rotationSpeed;
    float random;

    public void Start()
    {
        originRotation = transform.rotation;
        random = Random.Range(1, 4);
    }

    private void FixedUpdate()
    {
        angle++;

        Quaternion rotationY = Quaternion.AngleAxis(angle * random, Vector3.up);
        Quaternion rotationX = Quaternion.AngleAxis(angle * random, Vector3.right);

        transform.rotation = originRotation * rotationY * rotationX;
    }

    public void Update()
    {

    }
}