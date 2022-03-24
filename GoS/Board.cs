using System;
using System.Collections.Generic;

public class Board
{
    public int size;
    public List<Sck> currentboard;

    public Board(int size)
    {
        this.size = size;
        currentboard= new List<Sck>(size*size);
    }

    public Sck SearchPosition(int x, int y)
    {
        for(int i=0 ; i<currentboard.Count; i++)
        {
            if(currentboard[i].position[0]==x && currentboard[i].position[1] == y)
            {
                return currentboard[i];
            }
        }

        return null;
    }

    public void Deletefromboard(List<Sck> dead)
    {
        foreach(Sck sck in dead)
        {
            currentboard.Remove(sck);
        }
        
    }
}