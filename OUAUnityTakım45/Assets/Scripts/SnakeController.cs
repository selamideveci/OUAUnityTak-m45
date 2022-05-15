using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnakeController : MonoBehaviour
{
    Vector3 yon;
    public float hýz;
    public int Gap;

    public GameObject GOText;

    public int Score;
    public Text ScoreText;


    public GameObject BodyPrefab;

    List<GameObject> BodyParts = new List<GameObject>();
    List<Vector3> PositionHistory = new List<Vector3>();

    void Start()
    {
        yon = Vector3.forward;
        GOText.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(yon.x == 0)
            {
                yon = Vector3.right;

            }
            else
            {
                yon = Vector3.forward;
            }
        }
    }
    private void FixedUpdate()
    {
        Vector3 hareket = yon * Time.deltaTime * hýz;
        transform.position += hareket;

        PositionHistory.Insert(0, transform.position);
        int index = 0;
        foreach(var body in BodyParts)
        {
            Vector3 point = PositionHistory[Mathf.Clamp(index * Gap, 0, PositionHistory.Count - 1)];

            Vector3 moveDirection = point - body.transform.position;
            body.transform.position += moveDirection * hýz * Time.deltaTime;

            body.transform.LookAt(point);
            index++;
        }

        ScoreText.text = Score.ToString();
    }

    void GrowSnake()
    {
        GameObject body = Instantiate(BodyPrefab);
        BodyParts.Add(body);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Food")
        {
            GrowSnake();
            Destroy(other.gameObject);
            Score++;

        }

        if(other.gameObject.tag == "Barrýer")
        {
            GOText.SetActive(true);
            Time.timeScale = 0;
        }
    }


}
