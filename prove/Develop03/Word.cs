using System.Runtime.InteropServices;

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text){
        _text = text;
        _isHidden = false;
    }

    public void HideWord()
    {
        _isHidden = true;
    }

    public bool GetisHidden()
    {
        return _isHidden;
    }

    public string DisplayWord()
    {
        if (_isHidden)
        {

            return new string('_', _text.Length);
            
        }else{

            return _text;
        }
    }
}