using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    public void GoToNextScene() {
        SceneManager.LoadScene(1);
    }
}
