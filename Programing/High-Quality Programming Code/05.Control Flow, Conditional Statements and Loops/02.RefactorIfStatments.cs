Potato potato = new Potato();

if (potato != null)
{
    if (potato.isPeeled && !potato.isRotten)
    {
        Cook(potato);
    }
}

if ((x >= minX && x <= maxX) && (y >= minY && y <= maxY)  && !isVisitedCell)
{
    VisitCell();
}