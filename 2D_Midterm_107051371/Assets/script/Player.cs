using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject final;

    public Text textCount;

    public int count;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name =="Gate")
        {
            final.SetActive(true);

        }
        if(collision.tag == "Gem")
        {
            Destroy(collision.gameObject);

            count++;
            textCount.text = "item" + count;
        }
       
    }
}
