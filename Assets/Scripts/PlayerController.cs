using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    public Text text;
    public Text winText;

    private int _pickedUp = 0;
    private Rigidbody _rigidbody;

    public void Start()
    {
       _rigidbody = GetComponent<Rigidbody>();
        _pickedUp = 0;

        winText.gameObject.SetActive(false);
        winText.text = "";
    }

    public void FixedUpdate()
    {
        float horizontal = CrossPlatformInputManager.GetAxis("Horizontal");
        float vertical = CrossPlatformInputManager.GetAxis("Vertical");
        

        var movementVector = new Vector3(horizontal, 0f, vertical);
        movementVector = movementVector * speed;

        _rigidbody.AddForce(movementVector);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            _pickedUp += 1;
            SetPickupText();

            if (_pickedUp >= 7)
            {
                winText.gameObject.SetActive(true);
                winText.text = "You win!";
            }
        }
    }

    private void SetPickupText()
    {
        text.text = "Count: " + _pickedUp.ToString();
    }
}
