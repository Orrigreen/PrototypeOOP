using UnityEngine;

// INHERITANCE
public class EnemyController : PersonController {

    // POLYMORPHISM
    protected override void Jump() {
        rb.AddForce(Vector3.up * (JumpSpeed / 2), ForceMode.Impulse);
    }
}
