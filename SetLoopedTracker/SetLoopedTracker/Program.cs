Random rng = new Random();
Navigation direction = new Navigation();
for(int i = 0; i<1000000; i++)
{
    int randomNum = rng.Next(0, 4);
    switch(randomNum)
    {
        case 0:
            direction.Up();
            break;
        case 1:
            direction.Down();
            break;
        case 2:
            direction.Left();
            break;
        case 3:
            direction.Right();
            break;
    }
}
direction.sortNavData();
