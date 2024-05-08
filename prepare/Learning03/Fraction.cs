class Fraction
{
    private int _top;
    private int _bottom;
    public Fraction()
    {
        _top=1;
        _bottom=1;
    }
    public Fraction(int number)
    {
        _top=number;
        _bottom=1;
    }
    public Fraction(int tnumber, int bnumber)
    {
        _top=tnumber;
        _bottom=bnumber;
    }
    public int GetTop()
    {
        return _top;
    }
    public int GetBotton()
    {
        return _bottom;
    }
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        double div = (double)_top/(double)_bottom;
        return div;
    }
}