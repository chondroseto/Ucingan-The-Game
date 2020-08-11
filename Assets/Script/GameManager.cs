using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
	private TextMeshProUGUI timer;
	public GameObject player1;
	public GameObject player2;
	public GameObject kucing1;
	public GameObject kucing2;
	public GameObject player3;
	public GameObject kucing3;
	

	
	public GameObject template;
	public GameObject cat;
	public GameObject[] rand;
	public GameObject[] Krand;
	
	
	private int x,kondisi;
	private float timeLeft;
    // Start is called before the first frame update
    void Start()
    {
		timer = GetComponent<TextMeshProUGUI>();
		
		rand = new GameObject[3];
		Krand = new GameObject[3];
		rand[0] = player1;
		rand[1] = player2;
		rand[2] = player3;
		
		Krand[0] = kucing1;
		Krand[1] = kucing2;
		Krand[2] = kucing3;
		
		kondisi = 0;
		x = Random.Range(1,2);
		timeLeft = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
         if(timeLeft < 0 && kondisi == 0)
         {
         	x = Random.Range(0, 2);
			Instantiate(Krand[x], rand[x].transform.position,rand[x].transform.rotation);
			rand[x].SetActive(false);
			timeLeft = 180f;
			kondisi = 1;
         }
		 else if (timeLeft <0 && kondisi == 1 && cat.activeSelf == false){
			template.SetActive(true);
		 }
		timer.text = timeLeft.ToString("0");
    }
}
