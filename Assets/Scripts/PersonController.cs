using UnityEngine;

public class PersonController : MonoBehaviour {

    private float jumpSpeed = 6.0f;

    protected Rigidbody rb;

    private bool jumping = false;

    // ENCAPSULATION
    public float JumpSpeed { get => jumpSpeed; set => jumpSpeed = value; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.Space) && !jumping) {
            Jump();
            jumping = true;
        }
    }

    // ABSTRACTION
    protected virtual void Jump() {
        rb.AddForce(Vector3.up * JumpSpeed, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Ground")) {
            jumping = false;
        }
    }
}
