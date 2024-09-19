namespace Gravar_tela__Salvar_como_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())

            {
                saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|Texto (*.txt)|*.txt";
                saveFileDialog.Title = "Salvar como";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    string filePath = saveFileDialog.FileName;

                    if (Path.GetExtension(filePath) == ".rtf")
                    {
                        rtbTexto.SaveFile(filePath);
                    }
                    else
                    {
                        File.WriteAllText(filePath, rtbTexto.Text);
                    }
                }

            }
        }
    }
}
