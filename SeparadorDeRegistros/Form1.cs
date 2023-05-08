using SeparadorDeRegistros.src;

namespace SeparadorDeRegistros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxPath_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                textBoxPath.Text = openFileDialog1.FileName;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInteract fileInteract = new FileInteract(textBoxPath.Text);

            string editTextGuiasValue = textBoxGuias.Text;
            if(String.IsNullOrEmpty(editTextGuiasValue))
            {
                throw new Exception("Informar o número das guias que serão copiadas. Utilize a virgula para separar");
            }
            else
            {
                List<string> listGuias = new List<string>();
                string[] guias = editTextGuiasValue.Split(',');
                foreach(string guia in guias)
                {
                    if( String.IsNullOrEmpty(guia))
                    {
                        listGuias.Add(guia.Trim());
                    }
                    
                }

                fileInteract.separateFile330(listGuias);
            }


        }
    }
}