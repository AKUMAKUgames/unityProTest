using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bullet_action : MonoBehaviour
{
    public Transform explosion_effect;
    public AudioClip collision_sound;
    private float dtime = 0.0f;
    private float otime = 5.0f;
    // Start is called before the first frame update
  
    void Update()
    {
        dtime = dtime + Time.deltaTime;
        if (dtime > otime)
        {
            Destroy(this.gameObject);
            dtime = 0;
        }
        Debug.Log(dtime);
    }
    void OnTriggerEnter(Collider other)
    {
        Instantiate(explosion_effect, this.transform.position, this.transform.rotation);
        AudioSource.PlayClipAtPoint(collision_sound, this.transform.position);
        Destroy(this.gameObject);


        if (other.gameObject.tag == "Obs")
        {
            Destroy(other.gameObject);

        }
        else if (other.gameObject.tag == "Enemy")
        {
            Score.win++;
            if (Score.win >= 5)
            {
                Destroy(other.transform.root.gameObject);
                SceneManager.LoadScene("WIn");
            }
           
        }
        else if (other.gameObject.tag == "Tank")
        {
            Score.lose++;
            if (Score.lose >= 5) {
               // Destroy(other.transform.root.gameObject);
                SceneManager.LoadScene("Lose");
            }

        }
    }
    
}
