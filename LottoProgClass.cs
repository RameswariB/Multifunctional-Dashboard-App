using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Project_420_WebApp
{
    class LottoProgClass
    {
        private string dir = @"..\LottoMAX\";
        private string path = @"..\LottoMAX\LottoNbrs.txt";
        public FileStream fs = null;
        public DateTime currentDateTime; 
        
        public LottoProgClass() { }  //default constructor
       

        public bool writeFileLotto(string LottoType,string maxLottoString,int Bonus) {
            
            try
            {

                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                // create the output stream for a text file that exists
                StreamWriter textOut = new StreamWriter(fs);
                // write the fields into text file
                textOut.Write(LottoType+"," + DateTime.Now.ToString("MM/dd/yyyy hh:mm tt") + ", " + maxLottoString + "  BONUS " + Bonus);

                // close the output stream for the text file
                textOut.Close();
                fs.Close();
                return true;

            }
            catch (FileNotFoundException)
            {
                //MessageBox.Show(path + " not found.", "File Not Found");
                return false;
            }
            catch (DirectoryNotFoundException)
            {
                //MessageBox.Show(dir + " not found.", "Directory Not Found");
                return false;
            }
            catch (IOException ex)
            { 
                //MessageBox.Show(ex.Message, "IOException");
                return false;
            }
            finally { if (fs != null) fs.Close(); }
        }
        public string readFileLotto() {
            string textToPrint;
            try
            {

                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                // create the object for the input stream for a text file
                StreamReader textIn = new StreamReader(fs);
                textToPrint = "Winning Numbers Are :\n";
                // read the data from the file and store it in the list
                textToPrint += textIn.ReadToEnd();
                
                // close the input stream for the text file
                textIn.Close();

                fs.Close();
                return textToPrint;
            }
            catch (FileNotFoundException)
            {
                textToPrint= path +  "File Not Found";
                return textToPrint;
            }
            catch (DirectoryNotFoundException)
            {
                textToPrint=dir +  "Directory Not Found";
                return textToPrint;
            }
            catch (IOException ex)
            { textToPrint= "IOException"; return textToPrint; }
            finally { if (fs != null) fs.Close(); }
        }

    }
}
