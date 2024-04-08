using System;

namespace FileHandlerWinForm.Models
{
    internal class TextProcessorModel
    {
        public string ReadFile(string filePath) => File.ReadAllText(filePath);
        public void WriteFile(string filePath, string text) => File.WriteAllText(filePath, text);
        public string RemovePunctuation(string text) => text;
        public string RemoveShortWords(string text, int wordLenght) => text;
    }
}
