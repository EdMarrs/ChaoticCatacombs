using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth
{
    public event EventHandler onDamaged;
    public event EventHandler onDead;
    private List<Heart> heartList;

    public playerHealth(int heartAmount)
    {
        heartList = new List<Heart>();

        for (int i = 0; i < heartAmount; i++)
        {
            Heart heart = new Heart(4);

            heartList.Add(heart);
        }

        heartList[heartList.Count - 1].setFragments(0);
    }

    public List<Heart> getHeartsList()
    {
        return heartList;
    }

    public void damage(int damageAmount)
    {
        /** cycles through the hearts, starting from the end **/
        for (int i = heartList.Count - 1; i >= 0; i--)
        {
            Heart heart = heartList[i];

            /** test if the heart can absorb the damageAmount
             * if the heart can't absorb full damageAmount, damage the heart and go to the next heart
             * else the heart can absorb full damage, absorb and break the cycle
            **/
            if (damageAmount > heart.getFragmentAmount())
            {
                damageAmount -= heart.getFragmentAmount();
                heart.damage(heart.getFragmentAmount());
            } else
            {
                heart.damage(damageAmount);
                break;
            }
        }

        if (onDamaged != null)
        {
            onDamaged(this, EventArgs.Empty);
        }

        if (isDead())
        {
            if (onDead != null)
            {
                onDead(this, EventArgs.Empty);
            }
        }
    }

    public bool isDead()
    {
        return heartList[0].getFragmentAmount() == 0;
    }

    /**** Represents a single heart ****/
    public class Heart
    {
        private int fragments;

        public Heart(int fragments)
        {
            this.fragments = fragments;
        }

        public int getFragmentAmount()
        {
            return fragments;
        }

        public void setFragments(int fragments)
        {
            this.fragments = fragments;
        }

        public void damage(int damageAmount)
        {
            if (damageAmount >= fragments)
            {
                fragments = 0;
            } else
            {
                fragments -= damageAmount;
            }
        }
    }
}
