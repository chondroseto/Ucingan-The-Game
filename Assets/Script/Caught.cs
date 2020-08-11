using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caught : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Kucing;
	public GameObject Player;
	
	public GameObject Player1;
	public GameObject Player2;
	public GameObject Player3;

	public GameObject template;
	public GameObject hooman;
	public AudioSource turned;

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Kucing" && hooman.activeSelf == false){
			Instantiate(Kucing, Player.transform.position,Player.transform.rotation);
			turned.Play();
			Player.SetActive(false);
		}
		if((Player1.activeSelf == false)&&(Player2.activeSelf == false)&&(Player3.activeSelf == false)){
			template.SetActive(true);
		}
	}
}
