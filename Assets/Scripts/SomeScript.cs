using UnityEngine;
using UnityEngine.SceneManagement;

public class SomeScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Finish")) SceneManager.LoadScene(0);
    }
}