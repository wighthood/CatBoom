using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{

    private IAData m_Iadata;
    private BombeData m_BombeData;

    private void Update()
    {
        Debug.Log(m_BombeData);
        Debug.Log(m_Iadata);
    }
    public void SpeedAddition()// fonction for add a speed when the player chose thespeed bonus
    {
        if (m_Iadata.m_Speed > 1)
        {
            m_Iadata.m_Speed--; // reduce the speed for the lerp because when you reduce the lerp more speed you have when you have the animation
        } 
    }

    public void RadiusBombAddition()// function for add radius for a explosion more higter in the game when the bomb explode 
    {
        m_BombeData.m_Radius += 2;
    }
}
