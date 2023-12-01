namespace ExopratiqueCcharp.codingGame
{
    public class ChangeMonaie
    {
        public static Change OptimalChange(long s)
        {
            Change myChange;

            if (s == 0 || s == 1)
            {
                return null;
            }
            else
            {
                myChange = new Change();
                if(s== 2)
                {
                     myChange.Coin2 = 2;
                }
                else
                {
                    while(s >1)
                    {
                        if((s%2== 0)||(s >=2))
                        {
                            myChange.Coin2 += 2;
                            s -= 2;
                        } else if((s%5== 0)||(s >=5))
                        {
                            myChange.bill5 += 5;
                            s -= 5;
                        }
                        else
                        {
                            myChange.bill10 += 10;
                            s-= 10;
                        }
                    }
                }
            }

            return myChange;
        }
    }
}
