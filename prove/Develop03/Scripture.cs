using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberOfWordsToHide)
    {
        Random random = new Random();
        int wordsHidden = 0;

        while (wordsHidden < numberOfWordsToHide)
        {
            int wordCount = _words.Count;
            int index = random.Next(wordCount);
            Word word = _words[index];
            if (!word.GetisHidden())
            {
                word.HideWord();
                wordsHidden += 1;
            }
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (word.GetisHidden() == false)
            {
                return false;
            }
        }
        return true;
    }

    public void DisplayFullScripture()
    {
        Console.WriteLine(_reference.RefToString());
        string fullText = "";
        foreach (Word word in _words)
        {
            fullText += word.DisplayWord() + " ";
        }
        Console.WriteLine(fullText);

    }
}



// class Scripture
// {
//     private Reference _reference;
//     private List<Word> _words;

//     public Scripture(Reference reference, string text)
//     {
//         _reference = reference;
//         _words = new List<Word>();

//         // Split the text into words and add to the list
//         string[] wordArray = text.Split(' ');
//         foreach (string wordText in wordArray)
//         {
//             Word word = new Word(wordText);
//             _words.Add(word);
//         }
//     }

//     public void HideRandomWords(int numberOfWordsToHide)
//     {
//         Random random = new Random();
//         int wordsHidden = 0;

//         while (wordsHidden < numberOfWordsToHide)
//         {
//             int wordCount = _words.Count;
//             int index = random.Next(wordCount);
//             Word word = _words[index];

//             if (!word.GetisHidden())
//             {
//                 word.HideWord();
//                 wordsHidden += 1;
//             }
//         }
//     }

//     public bool AllWordsHidden()
//     {
//         foreach (Word word in _words)
//         {
//             if (!word.GetisHidden())
//             {
//                 return false;
//             }
//         }
//         return true;
//     }

//     public void DisplayFullScripture()
//     {
//         Console.WriteLine(_reference.RefToString());

//         foreach (Word word in _words)
//         {
//             Console.Write(word.DisplayWord() + " ");
//         }

//         Console.WriteLine();
//     }
// }
