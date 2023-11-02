using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowdownTower : MonoBehaviour
{
    private Tower thisTower;

    void Start()
    {
        thisTower = GetComponent<Tower>();
    }

    void Update()
    {
        if(thisTower.enemiesUpdate)     // 적 리스트가 갱신 되었을 떄
        {
            if(thisTower.enemiesInRange.Count > 0)      // 범위 안에 적이 들어왔을 때
            {
                foreach(EnemyController enemy in thisTower.enemiesInRange)
                {
                    enemy.SetMode(thisTower.fireRate);      //슬로우 적용
                }
            }
        }
    }
}
