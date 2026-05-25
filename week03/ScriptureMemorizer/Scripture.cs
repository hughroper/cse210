public class Scripture
{

    private Reference _reference;

    private List<Word> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = new List<Word>();
        string[] arrayOfWords = text.Split();
        foreach (string word in arrayOfWords)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }

    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText();
        foreach (Word word in _words)
        {
            displayText = displayText + " " + word.GetDisplayText();
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

}