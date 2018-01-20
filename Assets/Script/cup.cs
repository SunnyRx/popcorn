using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class cup : MonoBehaviour {

    public Rigidbody _rb;
    public float _speed;
	public float jumpSpeed = 400f;

    public int playerNum;

    public bool isGrounded;


    public int score;

	// Use this for initialization
	void Start () {
        score = 0;
    }
	
	// Update is called once per frame
	void Update () {

        float horizontal = 0;
        float vertical = 0;

        switch (playerNum)
        {
            case 1:
                horizontal = Input.GetAxisRaw("Horizontal");
                vertical = Input.GetAxisRaw("Vertical");
                break;
            case 2:
                horizontal = Input.GetAxisRaw("Horizontal2");
                vertical = Input.GetAxisRaw("Vertical2");
                break;
        }




        Vector3 movement = new Vector3(horizontal, 0, 0f) * Time.deltaTime * _speed;
        

		if (isGrounded) {  
			//空格键控制跳跃  
			//if (Input.GetKey (KeyCode.Space)) {  
            if (vertical > 0)
            {
                //Debug.Log("Jump!jumpSpeed="+jumpSpeed);
                FindObjectOfType<AudioManager>().Play("CupJump");
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
                    Debug.Log("Catch! ppcNum = " + popcorn.playerNum + " playerNum=" + playerNum);
                    if (popcorn.playerNum == playerNum)
                    {
                        FindObjectOfType<AudioManager>().Play("CoinCollect");
                        GameSystem.getInstance().setScore(popcorn.TakePopcorn());
                    }
                }
                Destroy(other.gameObject);
                break;
		case "PROPS":
			props tmpProp = other.GetComponent<props> ();
			if (null != tmpProp) 
			{
                    FindObjectOfType<AudioManager>().Play("CoinCollect");
                    tmpProp.TakePopcorn();
			}
            Destroy(other.gameObject);
            break;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

}
