using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Base64DecoderApp
{
    public partial class Base64DecoderForm : Form, INotifyPropertyChanged
    {
        private bool IsBusy;

        private string base64Text;
        public string Base64Text
        {
            get => base64Text;
            set
            {
                if (IsBusy)
                {
                    base64Text = value;
                    RaisePropertyChanged();
                    return;
                }

                IsBusy = true;

                try
                {
                    base64Text = value;
                    Utf8Text = Decode(value);
                    RaisePropertyChanged();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
                finally
                {
                    IsBusy = false;
                }
            }
        }

        private string utf8Text;
        public string Utf8Text
        {
            get => utf8Text;
            set
            {
                if (IsBusy)
                {
                    utf8Text = value;
                    RaisePropertyChanged();
                    return;
                }

                IsBusy = true;

                try
                {
                    utf8Text = value;
                    Base64Text = Encode(value);
                    RaisePropertyChanged();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
                finally
                {
                    IsBusy = false;
                }
            }
        }

        private string Decode(string input)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(input));
        }

        //encode
        private string Encode(string input)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }

        public Base64DecoderForm()
        {
            InitializeComponent();
        }

        private void Base64DecoderForm_Load(object sender, EventArgs e)
        {
            //create a two-way binding for base64 text box
            var binding = new Binding(
                nameof(Text),
                this,
                nameof(Base64Text),
                true,
                DataSourceUpdateMode.OnPropertyChanged);

            Base64TextBox.DataBindings.Add(binding);

            //create a two-way binding for utf8 text box
            binding = new Binding(
                nameof(Text),
                this,
                nameof(Utf8Text),
                true,
                DataSourceUpdateMode.OnPropertyChanged);
            Utf8TextBox.DataBindings.Add(binding);
        }
    }
}