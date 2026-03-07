
using UnityEngine;
using UnityEngine.SceneManagement;



public class geocontorl : MonoBehaviour
{
    public int counter = 0;
    private Rigidbody2D rb;
    public int speed = 3;
    public string nextlevel = "Scene_2";
    private SpriteRenderer _spriteRenderer;
    // Start is called before the first frame update

    public void Start()
    {
           rb = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    int var = 3;
    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        Debug.Log(xInput);
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _spriteRenderer.color = Color.red;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _spriteRenderer.color = Color.green;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _spriteRenderer.color = Color.blue;
        }

        /*
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -1, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(1,0, 0);
        }
        */
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch(collision.tag)
        {
            case "Death":
                {
                    string thislevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextlevel);
                    break;
                }
        }
    }
   
}

