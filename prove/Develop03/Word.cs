class Word
{
    private string _text;
    private bool _isHidden;
    private Random _random;
    public Word(string text,bool isHidden = false)
    {
        _text = text;
        _isHidden = isHidden;
        _random = new Random();
    }
    public void Hide()
    {
        _isHidden = true;
        _text = "____";
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if(_isHidden)
        {
            return _text;
        }
        else
        {
            int _randomHide = _random.Next(2);
            if(_randomHide==0)
            {
                Hide();
                return "____";
            }
            else
            {
                Show();
                return _text;
            }
        }
    }

}