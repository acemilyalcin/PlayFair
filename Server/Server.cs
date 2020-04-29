using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Drawing.Imaging;
using System.Threading;
// ===============================
// AUTHORS     : A.C. YALCIN & H. CAKIR
// CREATE DATE : 02/2020
// PURPOSE     : Image encryption with PlayFair algorithm.
//==================================
namespace Client
{
    public partial class Server : Form
    {
        public int[] secretKey;
        public int[] eRArray; // Encrypted R values of image.
        public int[] eGArray; // Encrypted G values of image.
        public int[] eBArray; // Encrypted B values of image.
        public int width;
        public int height;
        Bitmap image;
        Socket handler = null;
        Thread thread;
        private bool isCame = false;
        private bool isEncrypted = false;
        private bool isOpen = false;
        public Server()
        {
            InitializeComponent();
        }
        private void bDecrypt_Click(object sender, EventArgs e)
        {
            if (isCame)
            {
                eRArray = desifreleme(eRArray, secretKey, eRArray.Length, 16, 16);
                eGArray = desifreleme(eGArray, secretKey, eGArray.Length, 16, 16);
                eBArray = desifreleme(eBArray, secretKey, eBArray.Length, 16, 16);

                l_status.Text = "Image was decrypted.";
                isEncrypted = true;

                CreateImage();
            }
            else
            {
                MessageBox.Show("There is no picture coming.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int[] desifreleme(int[] image, int[] key, int lenght, int keyWidth, int keyHeight)
        {
            int[] encrypedText = new int[lenght];
            int character_1 = 0, character_2 = 0;
            int encryptedCharacter_1 = 0, encryptedCharacter_2 = 0;

            for (int encryptionCounter = 0; encryptionCounter < lenght; encryptionCounter += 2)
            {

                character_1 = image[encryptionCounter];
                character_2 = image[encryptionCounter + 1];

                /* Encryption */
                int rowCharacter_1 = 0, columnCharacter_1 = 0;
                int rowCharacter_2 = 0, columnCharacter_2 = 0;
                /* Location of current characters on the key */
                for (int rowCounterKey = 0; rowCounterKey < keyHeight; rowCounterKey++)
                {
                    for (int columnCounterKey = 0; columnCounterKey < keyWidth; columnCounterKey++)
                    {
                        /* Row and column detection of character_1 */
                        if (character_1 == key[columnCounterKey + rowCounterKey * keyHeight])
                        {
                            rowCharacter_1 = rowCounterKey;
                            columnCharacter_1 = columnCounterKey;
                        }

                        /* Row and column detection of character_2 */
                        if (character_2 == key[columnCounterKey + rowCounterKey * keyHeight])
                        {
                            rowCharacter_2 = rowCounterKey;
                            columnCharacter_2 = columnCounterKey;
                        }

                    }

                }

                /* If on the same row then todo */
                if (rowCharacter_1 == rowCharacter_2)
                {
                    if (columnCharacter_1 != 0)
                    {
                        encryptedCharacter_1 = key[(columnCharacter_1 - 1) + rowCharacter_1 * keyHeight];
                    }
                    else
                    {
                        encryptedCharacter_1 = key[(keyWidth - 1) + rowCharacter_1 * keyHeight];
                    }

                    if (columnCharacter_2 != 0)
                    {
                        encryptedCharacter_2 = key[(columnCharacter_2 - 1) + rowCharacter_2 * keyHeight];
                    }
                    else
                    {
                        encryptedCharacter_2 = key[(keyWidth - 1) + rowCharacter_2 * keyHeight];
                    }

                }
                /* If on the same column then todo */
                if (columnCharacter_1 == columnCharacter_2)
                {
                    if (rowCharacter_1 != 0)
                    {
                        encryptedCharacter_1 = key[columnCharacter_1 + (rowCharacter_1 - 1) * keyHeight];
                    }
                    else
                    {
                        encryptedCharacter_1 = key[columnCharacter_1 + (keyHeight - 1) * keyHeight];
                    }

                    if (rowCharacter_2 != 0)
                    {
                        encryptedCharacter_2 = key[columnCharacter_2 + (rowCharacter_2 - 1) * keyHeight];
                    }
                    else
                    {
                        encryptedCharacter_2 = key[columnCharacter_2 + (keyHeight - 1) * keyHeight];
                    }

                }
                /* If not both */
                if (rowCharacter_1 != rowCharacter_2 && columnCharacter_1 != columnCharacter_2)
                {
                    encryptedCharacter_1 = key[columnCharacter_2 + rowCharacter_1 * keyHeight];
                    encryptedCharacter_2 = key[columnCharacter_1 + rowCharacter_2 * keyHeight];
                }

                /* Encrypted equivalents */
                encrypedText[encryptionCounter] = encryptedCharacter_1;
                encrypedText[encryptionCounter + 1] = encryptedCharacter_2;

            }
            return encrypedText;
        }
        async private void sbStartServer_Click(object sender, EventArgs e)
        {
            if (!isOpen)
            {
                if (stIpAddressVal.Text == "" || stPortVal.Text == "")
                {
                    MessageBox.Show("Please enter the server ip and port.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    thread = new Thread(new ThreadStart(ConnectionFunction));
                    thread.Start();
                    isOpen = true;
                    l_status.Text = "Server was opened.";
                }
            }
        }
        private void bSaveEncryptedImage_Click(object sender, EventArgs e)
        {
            if (isEncrypted)
            {
                SaveFileDialog fileDialog = new SaveFileDialog();
                fileDialog.Title = "Save Encryped Image";
                fileDialog.Filter = "Images|*.bmp";
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    image.Save(fileDialog.FileName, ImageFormat.Bmp);
                }
            }
            else
            {
                MessageBox.Show("There is no encrypted image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void stStopServer_Click(object sender, EventArgs e)
        {
            if (handler != null)
            {
                if (isOpen)
                {
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                    isOpen = false;
                }
                else
                {
                    MessageBox.Show("There is no opened connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                l_status.Text = "Server has been stop.";
                isOpen = false;
            }
        } // Closing socket
        // OTHER FUCNTIONS //
        private void CreateImage()
        {
            Bitmap encryptedImage = new Bitmap(this.width, this.height); // New image was created. 
            int globalPixelCounter = 0; // Global counter was defined.
            for (int row = 0; row < height; row++)
                for (int column = 0; column < width; column++)
                {
                    encryptedImage.SetPixel(column, row, Color.FromArgb(eRArray[globalPixelCounter],
                                                                        eGArray[globalPixelCounter],
                                                                        eBArray[globalPixelCounter])); // Pixels has set.
                    globalPixelCounter++;
                }
            pImage.Image = encryptedImage;
            image = encryptedImage;
        }
        private void ConnectionFunction()
        {
            l_status.Text = "Waiting sender...";

            //IPHostEntry host = Dns.GetHostEntry("localhost");
            IPAddress ipAddress = IPAddress.Parse(stIpAddressVal.Text);
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, int.Parse(stPortVal.Text));

                try
                {
                    // Create a Socket that will use Tcp protocol      
                    Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    // A Socket must be associated with an endpoint using the Bind method  
                    listener.Bind(localEndPoint);
                    // Specify how many requests a Socket can listen before it gives Server busy response.  
                    // We will listen 10 requests at a time  
                    listener.Listen(10);

                    isOpen = true;

                    
                    handler = listener.Accept();
                    l_status.Text = "Waiting for a connection...";
                    // Incoming data from the client.    
                    string data = null;
                    byte[] bytes = null;

                    while (true)
                    {
                        bytes = new byte[400000];
                        int bytesRec = handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        if (data.IndexOf("<EOF>") > -1)
                        {
                            break;
                        }
                    }

                    string[] inComingDatas = data.Split('!');
                    width = Int32.Parse(inComingDatas[0]);
                    height = Int32.Parse(inComingDatas[1]);
                    secretKey = inComingDatas[2].Split(',').Where(val => val != "").Select(int.Parse).ToArray();
                    eRArray = inComingDatas[3].Split(',').Where(val => val != "").Select(int.Parse).ToArray();
                    eGArray = inComingDatas[4].Split(',').Where(val => val != "").Select(int.Parse).ToArray();
                    eBArray = inComingDatas[5].Split(',').Where(val => val != "<EOF>").Select(int.Parse).ToArray();
                    CreateImage();
                    byte[] msg = Encoding.ASCII.GetBytes(data);
                    handler.Send(msg);

                    isCame = true;
                    isEncrypted = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
    }
}
