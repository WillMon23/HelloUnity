using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalHealthTextBehavior : MonoBehaviour
{
    [SerializeField]
    private Text _healthTest;
    [SerializeField]
    private GoalBehavior _goal;

    // Update is called once per frame
    void Update()
    {
        float health = (_goal.Health);

        if (health < 0) health = 0; 

        _healthTest.text = "Health: " + health;
    }
}
