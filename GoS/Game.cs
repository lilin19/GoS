using GoS;
using System;
using System.Collections;
using System.Collections.Generic;


class Game
{
    string BlackPlayer;//0
    string WhitePlayer;//1

    Board board = new Board(19);
    int Komi;
    Rule rule = new BasicRule();
    int currentplayer;
    public List<Sck> Situation = new List<Sck>(500);

    public Game(string player1, string player2, int size, int komi)
    {
        this.BlackPlayer = player1;
        this.WhitePlayer = player2;
        this.board = new Board(19);
        this.Komi = komi;
        currentplayer = 0;
    }

    public void Play(int x, int y)
    {
        if (currentplayer == 0)
        {

            Sck dsck = new Sck(0, x, y, Situation.Count + 1, false);
            if (Update(dsck, board, Situation))
            currentplayer = 1;
        }
        else if (currentplayer == 1)
        {
            Sck dsck = new Sck(1, x, y, Situation.Count + 1, false);
            if (Update(dsck, board, Situation))
            currentplayer = 0;
        }
        else
        {
            throw (new Exception());
        }



    }
    bool Update(Sck input, Board board, List<Sck> situation)
    {
        //rule 1,2
        if (input != null)
        {
            if(rule.Canput(board, input, situation))
            {

                board.currentboard.Add(input);
                Situation.Add(input);
                board.Deletefromboard(rule.Caneat(board, input));
                return true;
            }
            else
            {
                if (rule.Caneat(board, input).Count > 0)
                {
                    board.currentboard.Add(input);
                    Situation.Add(input);
                    board.Deletefromboard(rule.Caneat(board, input));
                    return true;
                }
                return false;
            }
        }else
        {
            return false;
        }
    }
}