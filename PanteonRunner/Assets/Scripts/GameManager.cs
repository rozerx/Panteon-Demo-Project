using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 2f;

    public GameObject finUI;

    //public void OnCollisionEnter(Collision other)
    //{
    //    if (other.collider.CompareTag("Obstacle"))
    //    {
    //        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //    }

    //}

    public void FinishLevel()
    {
        finUI.SetActive(true);
    }

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
