using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeparadorDeRegistros.src
{
    internal class FileInteract
    {
        private string fileName = "";
        private string[] lines;
        private List<String> copiedLines = new List<string>();
        public FileInteract(String filePath) { 
        
            if(! File.Exists(filePath)) throw new Exception("O arquivo não existe em "+ filePath);
            try
            {
                lines = File.ReadAllLines(filePath);
            }catch (Exception ex)
            {
                throw new Exception("O arquivo não pode ser carregado: " + ex.Message);
            }
            this.fileName = System.IO.Path.GetFileName(filePath);

        }

        public void separateFile330(List<string> guias )
        {
            

           // int cont = 0;
            foreach(string line in lines)
            {
                string[] columns = line.Split("|");
                switch(columns[1])
                {
                    case "000":
                        copiedLines.Add(line);
                        break;
                    case "330":
                        if (guias.Contains(columns[19] ?? "" ) )
                        {
                            copiedLines.Add(line);
                        }
                        break;
                }
            }

            if( copiedLines.Count > 0 )
            {
                saveDialog();
            }
            else
            {
                MessageBox.Show("Nenhum registro para copiar");
            }
        }

        private void saveDialog()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Salvar Como";
            saveFileDialog1.FileName = String.Concat(this.fileName, "-new", ".txt");
            saveFileDialog1.Filter = "Arquivos TXT (*.txt)|*.txt|Arquivos de Baixa (*.new)|*.new|Todos os Arquivos (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);
                streamWriter.Write(String.Join(Environment.NewLine, copiedLines.ToArray() )); // Gravamos o valor no arquivo.
                streamWriter.Close(); // Fechamos a conexão com o arquivo.
                MessageBox.Show("Arquivo salvo com sucesso");

            }
        }
    }
}
