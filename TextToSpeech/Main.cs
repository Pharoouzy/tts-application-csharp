using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using Microsoft.Office.Interop.Word;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace TextToSpeech
{
    public partial class Main : Form
    {
        SpeechSynthesizer reader = new SpeechSynthesizer();
        string pdfText = "";
        public Main()
        {
            InitializeComponent();
            volVal.Text = vol_tb.Value.ToString();
            speedVal.Text = speed_tb.Value.ToString();
            label4.Text = trackBar1.Value.ToString();
            label5.Text = trackBar2.Value.ToString();
            reader.SpeakProgress += new EventHandler<SpeakProgressEventArgs>(speak_progress);
        }

        private void speak_progress(object sender, SpeakProgressEventArgs e)
        {
            plainText_tb.HideSelection = false;
            int textPosition = e.CharacterPosition;
            plainText_tb.Find(e.Text, textPosition, RichTextBoxFinds.WholeWord);
        }

        private void speak(string text)
        {
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SpeakAsync(text);
        }

        

        private void pause()
        {
            if (reader != null)
            {
                if (reader.State == SynthesizerState.Speaking)
                {
                    reader.Pause();
                }
            }
        }

        private void resume()
        {
            if (reader != null)
            {
                reader.Rate = speed_tb.Value;
                reader.Volume = vol_tb.Value;
                reader.Rate = trackBar2.Value;
                reader.Volume = trackBar1.Value;
                if (reader.State == SynthesizerState.Paused)
                {
                    reader.Resume();
                }
            }
        }

        private void stop()
        {
            reader.Dispose();
        }

        private void voice_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void speed_tb_Scroll(object sender, EventArgs e)
        {
            if (reader != null)
            {
                if (reader.State == SynthesizerState.Speaking)
                {
                    reader.Rate = speed_tb.Value;
                }
            }
            speedVal.Text = speed_tb.Value.ToString();
        }

        private void read_btn_Click(object sender, EventArgs e)
        {
            //read_btn.Enabled = false;
            reader.Dispose();
            reader = new SpeechSynthesizer();
            if (voice_cmb.Text == "Male")
            {
                reader.SelectVoiceByHints(VoiceGender.Male);
            }
            else
            {
                reader.SelectVoiceByHints(VoiceGender.Female);
            }
            reader.Rate = speed_tb.Value;
            reader.Volume = vol_tb.Value;
            if (plainText_tb.Text != "")
            {
                reader.SpeakAsync(plainText_tb.Text);
            }
            else
            {
                reader.SpeakAsync("Sorry I cannot read empty string, please type something for me to read.");
            }
        }

        private void pause_btn_Click(object sender, EventArgs e)
        {
            pause();
        }

        private void resume_btn_Click(object sender, EventArgs e)
        {
            resume();
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            stop();
        }

        private void vol_tb_Scroll(object sender, EventArgs e)
        {
            volVal.Text = vol_tb.Value.ToString();
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF Files(*.pdf)|*.pdf|DOC Files(*.doc)|*.doc|DOCX Files(*.docx)|*.docx";
            ofd.Title = "Select a Document";
            string file, extension, outputFile;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                reader.Dispose();
                file = ofd.FileName;
                double size = file.Length;
                extension = System.IO.Path.GetExtension(file);
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                outputFile = fbd.SelectedPath+"\\\file.pdf";//"C:\\\file.pdf";
                MessageBox.Show(size.ToString());
                if (extension == ".doc" || extension == ".docx")
                {
                    speak("This is a Microsoft Word Document, It'll take me some minutes to convert it to my readable format!!!");
                    Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                    Microsoft.Office.Interop.Word.Document doc = null;
                    doc = app.Documents.Open(file, Type.Missing, false);

                    // convert doc to pdf
                    doc.ExportAsFixedFormat(outputFile, WdExportFormat.wdExportFormatPDF);
                    // close doc file and quit app word
                    doc.Close(false, Type.Missing, Type.Missing);
                    app.Quit(false, false, false);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                    axAcroPDF1.src = outputFile;
                }
                else
                {
                    string text = string.Empty;
                    try
                    {
                        PdfReader pdf = new PdfReader(file);

                        for (int page = 1; page <= pdf.NumberOfPages; page++)
                        {
                            ITextExtractionStrategy its = new iTextSharp.text.pdf.parser.LocationTextExtractionStrategy();
                            String s = PdfTextExtractor.GetTextFromPage(pdf, page, its);
                            s = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(s)));
                            text = text + s;
                            text.Replace("\n", "");
                            pdfText = text;
                            /*reader.Dispose();
                            reader = new SpeechSynthesizer();
                            reader.SpeakAsync(text);*/
                        }
                        pdf.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    axAcroPDF1.src = file;
                }
            }
        }

        private void pdf_read_btn_Click(object sender, EventArgs e)
        {
            reader.Dispose();
            reader = new SpeechSynthesizer();
            if (voice_cmb.Text == "Male")
            {
                reader.SelectVoiceByHints(VoiceGender.Male);
            }
            else
            {
                reader.SelectVoiceByHints(VoiceGender.Female);
            }
            reader.Rate = trackBar2.Value;
            reader.Volume = trackBar1.Value;
            if (pdfText != "")
            {
                reader.SpeakAsync(pdfText);
            }
            else
            {
                reader.SpeakAsync("Sorry I cannot read empty string, please select a file for me to read.");
            }
        }

        private void pdf_pause_btn_Click(object sender, EventArgs e)
        {
            pause();
        }

        private void pdf_resume_btn_Click(object sender, EventArgs e)
        {
            resume();
        }

        private void pdf_stop_btn_Click(object sender, EventArgs e)
        {
            stop();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackBar2.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar1.Value.ToString();
        }
    }
}
