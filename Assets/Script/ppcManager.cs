using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ppcManager : MonoBehaviour {

    public GameObject lv1ppcR;
    public GameObject lv2ppcR;
    public GameObject lv3ppcR;
    public GameObject lv1ppcB;
    public GameObject lv2ppcB;
    public GameObject lv3ppcB;
    public GameObject ppc;
	public GameObject getMorePPC;
    public GameObject FeverOverlay;
    public GameObject FreezeOverlay;

    public Rigidbody ppcRigdbody;
    public Transform leftSpawn;
    public Transform rightSpawn;

	public Camera mainCamera;

	public Transform baseY;

	public enum gameMode
	{
		normal,
		getMore,
		stop
	}

	public gameMode currentGameMode;

	static ppcManager _instance;

	// Use this for initialization
	void Start () {
		{

            /*
            //Arrange Test
            foreach (List<Vector3> tempList in ppcArrange.Instance.Arrange)
            {
                foreach (Vector3 tempV in tempList)
                {
                    if (tempV[0] == 1)
                    {
                        ppcInstantiate(lv1ppcR, new Vector3(tempV[1], tempV[2], -10));
                    }
                    else
                    {
                        ppcInstantiate(lv1ppcB, new Vector3(tempV[1], tempV[2], -10));
                    }
                }
            }

            //GetMore Test
            Vector3 tmpPosition;
            tmpPosition = new Vector3(0, 20, -10);
			ppcInstantiate(getMorePPC, tmpPosition);
            */
            
		}

		_instance = this;
		Debug.Log("Start!");
		setCurrentGameMode(gameMode.normal);
        spawnPPCArrange();
        //SpawnPPC();


    }

    public void spawnPPCArrange()
    {
        int ramdonNum = Random.Range(0, ppcArrange.Instance.Arrange.Count);
        Debug.Log("Count= "+ppcArrange.Instance.Arrange.Count);
        List<Vector3> tempList = ppcArrange.Instance.Arrange[ramdonNum];
        Debug.Log("tempList Count= " + tempList.Count);
        foreach (Vector3 tempV in tempList)
            {
                Debug.Log(tempList);
                
                if (tempV[0] == 1)
                {
                    ppcInstantiate(lv1ppcR, new Vector3(tempV[1], tempV[2], -10));
                }
                else
                {
                    ppcInstantiate(lv1ppcB, new Vector3(tempV[1], tempV[2], -10));
                }
            }
        Invoke("spawnPPCArrange", 7);
    }

	public void setCurrentGameMode(gameMode gameMode)
	{
		currentGameMode = gameMode;
		switch (currentGameMode)
		{
		case gameMode.normal:
			Debug.Log("NormalMode Set");
            FeverOverlay.SetActive(false);
            FreezeOverlay.SetActive(false);
			SpawnPPC();
			break;
		case gameMode.getMore:
			Debug.Log("GetMoreMode Set");
            FeverOverlay.SetActive(true);
			GetMoreMode();
			Invoke("setGetMoreMode", 10.0f);
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	static public ppcManager getInstance()
	{
		if (!_instance)
		{
			_instance = new ppcManager();
		}
		return _instance;
	}

	static public void destoryInstance()
	{
		
	}

    private void SpawnPPC()
    {
        //float objectHalfXScale = _ppc.transform.localScale.x / 2;
        //float objectHalfYScale = _ppc.transform.localScale.y / 2;
        //float objectHalfZScale = _ppc.transform.localScale.z / 2;



            //设定随机生成范围
            float x = Random.Range(leftSpawn.position.x, rightSpawn.position.x);
            float y = Random.Range(leftSpawn.position.y, rightSpawn.position.y);
            float z = Random.Range(leftSpawn.position.z, rightSpawn.position.z);
            Vector3 randomPosition = new Vector3(x, y, z);

        //生成爆米花
        float ramdonInt = Random.Range(0f, 1f);
        int ramdonNum = Random.Range(1, 3);
        if (ramdonInt >= 0 && ramdonInt < 0.05f)
        {
            ppcInstantiate(getMorePPC, randomPosition);
        }
        else if (ramdonInt >= 0.05f && ramdonInt < 0.5f)
        {
            if (ramdonNum == 1)
            {
                ppcInstantiate(lv1ppcR, randomPosition);
            }
            else if (ramdonNum == 2)
            {
                ppcInstantiate(lv1ppcB, randomPosition);
            }
        }
        else if (ramdonInt >= 0.05f && ramdonInt < 0.8f)
        {
            if (ramdonNum == 1)
            {
                ppcInstantiate(lv2ppcR, randomPosition);
            }
            else if (ramdonNum == 2)
            {
                ppcInstantiate(lv2ppcB, randomPosition);
            }
        }
        else if (ramdonInt >= 0.8f && ramdonInt <= 1f)
        {
            if (ramdonNum == 1)
            {
                ppcInstantiate(lv3ppcR, randomPosition);
            }
            else if (ramdonNum == 2)
            {
                ppcInstantiate(lv3ppcB, randomPosition);
            }
        }
        

		if (currentGameMode == gameMode.normal)
		{
        	float time = Random.Range(0.01f, 0.5f);
        	Invoke("SpawnPPC", time);
		}
    }
    
    void ppcInstantiate(GameObject ppc, Vector3 position)
    {
        GameObject tppc;
        tppc = Instantiate(ppc, position, Quaternion.identity) as GameObject;
		Vector3 addForce = new Vector3(0, 0, 0);
		if (ppc == lv1ppcR || ppc == lv2ppcR || ppc == lv3ppcR || ppc == lv1ppcB || ppc == lv2ppcB || ppc == lv3ppcB)
        	addForce = new Vector3(0, -500 * ppc.GetComponent<ppc>().force, 0);
		else
			addForce = new Vector3(0, -500 * ppc.GetComponent<props>().force, 0);
        tppc.GetComponent<Rigidbody>().AddForce(addForce);
        //tppc.GetComponent<ppc>().model = tppc;
        //Destroy(tppc, 8);
    }

    private void Falldown(GameObject ppc)
    {
        
    }

	public void setGetMoreMode()
	{
		setCurrentGameMode(gameMode.normal);
	}

    public void CoinHeartSetMode()
    {
        setCurrentGameMode(gameMode.getMore);
    }

	private void GetMoreMode()
	{
		//设定随机生成范围
		float x = Random.Range(leftSpawn.position.x, rightSpawn.position.x);
		float y = Random.Range(leftSpawn.position.y, rightSpawn.position.y);
		float z = Random.Range(leftSpawn.position.z, rightSpawn.position.z);
		Vector3 randomPosition = new Vector3(x, y, z);
        //生成爆米花
        float ramdonInt = Random.Range(0f, 1f);
        int ramdonNum = Random.Range(1, 3);
        if (ramdonInt >= 0 && ramdonInt < 0.5f)
        {
            if (ramdonNum == 1)
            {
                ppcInstantiate(lv1ppcR, randomPosition);
            }
            else if (ramdonNum == 2)
            {
                ppcInstantiate(lv1ppcB, randomPosition);
            }
        }
        else if (ramdonInt >= 0.05f && ramdonInt < 0.8f)
        {
            if (ramdonNum == 1)
            {
                ppcInstantiate(lv2ppcR, randomPosition);
            }
            else if (ramdonNum == 2)
            {
                ppcInstantiate(lv2ppcB, randomPosition);
            }
        }
        else if (ramdonInt >= 0.8f && ramdonInt <= 1f)
        {
            if (ramdonNum == 1)
            {
                ppcInstantiate(lv3ppcR, randomPosition);
            }
            else if (ramdonNum == 2)
            {
                ppcInstantiate(lv3ppcB, randomPosition);
            }
        }


        if (currentGameMode == gameMode.getMore)
		{
			float time = Random.Range(0.01f, 0.05f);
			Invoke("GetMoreMode", time);
		}
	}
}
