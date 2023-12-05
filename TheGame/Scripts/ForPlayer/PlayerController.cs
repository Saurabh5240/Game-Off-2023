using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float forwardForce = 35.0F;
    public float horizontalForce = 6.0F;
    public float jumpForce = 15.0F;
    public float gravityModifier = 4F;
    private float forwardInput;
    private float horizontalInput;

    private bool inAir = false;
    public bool onLevel1 = false;
    public bool onLevel2 = false;
    public bool onLevel3 = false;
    public bool onLevel4 = false;
    public bool onLevel5 = false;
    private Vector3 forward = new Vector3(0, 0, 3F);
    private Vector3 left = new Vector3(-3F, 0, 0);

    public float scaleChanger = 0.001F;

    private Vector3 startPos;

    public GameObject[] levels;

    public GameObject gameOverText;
    public Button restartButton;
    public GameObject youwin;

    private bool gameOn = true;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position  + new Vector3(0,4F,0);
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;

        



    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (gameOn)
        {
            PlayerMovement();

            ScaleChange();

            ResetAndBound();

        }

        if (transform.position.y < -400)
        {
            gameOn = false;
            transform.position = startPos;
            gameOverText.SetActive(true);
            restartButton.gameObject.SetActive(true);
        
        
        }

        

    }

    private void ScaleChange()                   // The ball scale is changing with time and it will dissapear after certain time////
    {
        transform.localScale -= new Vector3(scaleChanger, scaleChanger, scaleChanger);
        if (transform.localScale.x < 0.1)
        {
            Destroy(gameObject);
            Debug.Log("GameOver!!!");
        
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        int enemyCount = FindObjectsOfType<Enemy>().Length;

        if (collision.gameObject.CompareTag("Surface"))
        {
            inAir = false;

        }

        if (collision.gameObject.CompareTag("Level1") )
        {
            inAir = false;
            onLevel1 = true;
            

        }
        
        if (collision.gameObject.CompareTag("Level2") )
        {
            inAir = false;
            onLevel2 = true;
            

        }
        if (collision.gameObject.CompareTag("Level3") )
        {
            inAir = false;
            onLevel3 = true;
            

        }
        if (collision.gameObject.CompareTag("Level4") )
        {
            inAir = false;
            onLevel4 = true;
            

        }
        if (collision.gameObject.CompareTag("Level5"))
        {
            inAir = false;
            onLevel5 = true;
            

        }

        if (collision.gameObject.CompareTag("LastPlatform"))
        {
            youwin.SetActive(true);
            restartButton.gameObject.SetActive(true);


        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Rigidbody enemyRb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayPos = collision.gameObject.transform.position - transform.position;   //The direction in which enemy is hit back after powerup

            enemyRb.AddForce(awayPos * 40.0F, ForceMode.Impulse);
            

        }


    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOn = true;


    }
    private void PlayerMovement()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(forward * forwardForce * -forwardInput);  //Negative Z direction so its -ve of Vector3.forward(0,0,1)
        playerRb.AddForce(left * horizontalForce * horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space) && !inAir)
        {
            playerRb.AddForce(Vector3.up * jumpForce);
            inAir = true;

        }

    }

    private void ResetAndBound()
    {
        

        if (transform.position.z > 914.0F )
        {
            transform.position = new Vector3( transform.position.x , transform.position.y , 914.0F);
        
        }


    
    }

}
