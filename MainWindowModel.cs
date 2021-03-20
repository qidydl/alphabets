using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace alphabets
{
    public class MainWindowModel : INotifyPropertyChanged
    {
        public MainWindowModel()
        {
            _selectedAlphabet = Alphabets[0];
        }

        /// <inheritdoc/>
        public event PropertyChangedEventHandler? PropertyChanged;

        public IList<string> Alphabets { get; } = new List<string> { "Fancy", "Fancier" };

        public string SelectedAlphabet
        {
            get => _selectedAlphabet;
            set
            {
                _selectedAlphabet = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedAlphabet)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(OutputText)));
            }
        }
        private string _selectedAlphabet;

        public string? InputText
        {
            get => _inputText;
            set
            {
                _inputText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(InputText)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(OutputText)));
            }
        }
        private string? _inputText = "Enter input here";

        public string OutputText
        {
            get
            {
                var newAlphabet = _selectedAlphabet switch
                {
                    "Fancy" => s_fancyAlphabet,
                    "Fancier" => s_fancierAlphabet,
                    _ => s_baseAlphabet
                };

                return Translate(InputText, newAlphabet);
            }
        }

        private static string Translate(string? input, string[] newAlphabet)
        {
            var builder = new StringBuilder(input);

            for (var i = 0; i < s_baseAlphabet.Length; i++)
            {
                builder.Replace(s_baseAlphabet[i], newAlphabet[i]);
            }

            return builder.ToString();
        }

        private static readonly string[] s_baseAlphabet = new[] {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
        };

        private static readonly string[] s_fancyAlphabet = new[] {
            "𝓪", "𝓫", "𝓬", "𝓭", "𝓮", "𝓯", "𝓰", "𝓱", "𝓲", "𝓳", "𝓴", "𝓵", "𝓶", "𝓷", "𝓸", "𝓹", "𝓺", "𝓻", "𝓼", "𝓽", "𝓾", "𝓿", "𝔀", "𝔁", "𝔂", "𝔃",
            "𝓐", "𝓑", "𝓒", "𝓓", "𝓔", "𝓕", "𝓖", "𝓗", "𝓘", "𝓙", "𝓚", "𝓛", "𝓜", "𝓝", "𝓞", "𝓟", "𝓠", "𝓡", "𝓢", "𝓣", "𝓤", "𝓥", "𝓦", "𝓧", "𝓨", "𝓩"
        };

        private static readonly string[] s_fancierAlphabet = new[] {
            "𝖆", "𝖇", "𝖈", "𝖉", "𝖊", "𝖋", "𝖌", "𝖍", "𝖎", "𝖏", "𝖐", "𝖑", "𝖒", "𝖓", "𝖔", "𝖕", "𝖖", "𝖗", "𝖘", "𝖙", "𝖚", "𝖛", "𝖜", "𝖝", "𝖞", "𝖟",
            "𝕬", "𝕭", "𝕮", "𝕯", "𝕰", "𝕱", "𝕲", "𝕳", "𝕴", "𝕵", "𝕶", "𝕷", "𝕸", "𝕹", "𝕺", "𝕻", "𝕼", "𝕽", "𝕾", "𝕿", "𝖀", "𝖁", "𝖂", "𝖃", "𝖄", "𝖅"
        };
    }
}