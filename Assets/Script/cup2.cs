using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class cup2 : MonoBehaviour {

    public Rigidbody _rb;
    public float _speed;
	public float jumpSpeed = 400f;

    public bool isGrounded;

    public Text scoreText;

    public int score;

	// Use this for initialization
	void Start () {
        score = 0;
        SetScoreText();

    }
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxisRaw("Horizontal2");
        //float vertical = Input.GetAxisRaw("Vertical2");

        Vector3 movement = new Vector3(horizontal, 0, 0f) * Time.deltaTime * _speed;
        

		if (isGrounded) {  
			//空格键控制跳跃  
			if (Input.GetKey (KeyCode.W)) {  
				Debug.Log("Jump!jumpSpeed="+jumpSpeed);
				_rb.AddForce(_rb.transform.up * jumpSpeed);
                isGrounded = false;
            }  
		}  

		_rb.MovePosition(movement + _rb.position);
    }

    void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "PPC":
                ppc popcorn = other.GetComponent<ppc>();
                if (null != popcorn)
                {
                    score += popcorn.TakePopcorn();
                    SetScoreText();
                }
                Destroy(other.gameObject);
                break;
		case "PROPS":
			props tmpProp = other.GetComponent<props> ();
			if (null != tmpProp) 
			{
				tmpProp.TakePopcorn();
			}
			break;
        }
    }

    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

}
