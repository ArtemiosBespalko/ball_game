using UnityEngine;

public class Rotator : MonoBehaviour
{
    public void Update()
    {
        transform.Rotate(new Vector3(15f, 30f, 45f) * Time.deltaTime);
    }
}
