using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
	public float restartDelay = 5f;         // Time to wait before restarting the level

    Animator anim;
	float restartTimer;                     // Timer to count up to restarting the level

    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            anim.SetTrigger("GameOver");
			restartTimer += Time.deltaTime;
			if(restartTimer >= restartDelay)
			{
				Application.LoadLevel(Application.loadedLevel);
			}
        }
    }
}
