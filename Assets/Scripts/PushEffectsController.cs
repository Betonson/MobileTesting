using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushEffectsController : MonoBehaviour
{

    [SerializeField] private Material material;

    private float dissolveAmount = 0;

    Collider2D col;
    //private bool isDissolving = false;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (isDissolving)
        //{
        //    dissolveAmount = Mathf.Clamp01(dissolveAmount + (Time.deltaTime * 0.5f));
        //    material.SetFloat("_DissolveAmount", dissolveAmount);
        //    if (dissolveAmount >= 1)
        //    {
        //        Destroy(this.gameObject);
        //    }
        //}
        //else
        //{
        //    dissolveAmount = Mathf.Clamp01(dissolveAmount - (Time.deltaTime * 0.5f));
        //    material.SetFloat("_DissolveAmount", dissolveAmount);
        //}

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            //Vector2 touchPosition = touch.position;
            if (touch.phase == TouchPhase.Began)
            {
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                if (col == touchedCollider)
                {
                    Destroy(gameObject);
                }
            }

        }
    }

}
