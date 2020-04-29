using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
// ===============================
// AUTHORS     : A.C. YALCIN & H. CAKIR
// CREATE DATE : 02/2020
// PURPOSE     : Image encryption with PlayFair algorithm.
//==================================
namespace Server
{
    public partial class Client : Form
    {
        private const int keyWidth = 16;
        private const int keyHeight = 16;
        private string filePath = "";
        private int width;
        private int height;
        private List<int> RArray = new List<int>(); // R values of original image.
        private List<int> GArray = new List<int>(); // G values of original image.
        private List<int> BArray = new List<int>(); // B values of original image.
        private int[] eRArray; // Encrypted R pixels of image.
        private int[] eGArray; // Encrypted G pixels of image.
        private int[] eBArray; // Encrypted B pixels of image.
        private int[] secretKey = new int[keyWidth * keyHeight];
        private Random rnd = new Random();
        private List<int> randomList = new List<int>();
        private int MyNumber = 0;
        private Socket socketName;
        private bool isOpen = false;
        private Bitmap encryptedImage;
        private bool isEncrypted = false;
        public Client()
        {
            InitializeComponent();
            generateSecretKey();
        }
        private void bSendImage_Click(object sender, EventArgs e)
        {
            if (isOpen)
            {

                if (isEncrypted)
                {
                    try
                    {
                        int byteCap = ASCIIEncoding.ASCII.GetByteCount(width.ToString()) +
                                  ASCIIEncoding.ASCII.GetByteCount(height.ToString()) +
                                  ASCIIEncoding.ASCII.GetByteCount(ConvertString(secretKey)) +
                                  (ASCIIEncoding.ASCII.GetByteCount(ConvertString(eRArray)) * 3);
                        byte[] bytes = new byte[byteCap];
                        lPath.Text = "Socket connected to " + socketName.RemoteEndPoint.ToString();
                        byte[] byteArray = Encoding.ASCII.GetBytes(width.ToString() +
                                                             "!" + height.ToString() +
                                                             "!" + ConvertString(secretKey) +
                                                             "!" + ConvertString(eRArray) +
                                                             "!" + ConvertString(eGArray) +
                                                             "!" + ConvertString(eBArray) + "<EOF>"); // Encoding the data string into a byte array.

                        socketName.Send(byteArray); // Sending the data through the socket. 
                        MessageBox.Show("Encrypted image send to " + stIpAddressVal.Text + " width successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No encrypted image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please connect to server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bSelectImage_Click(object sender, EventArgs e) // Fetching image details.
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Bitmap File |*.bmp";
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Please Select Image File";
            file.Multiselect = false;

            if (file.ShowDialog() == DialogResult.OK)
            {
                filePath = file.FileName;
                lPathVal.Text = file.FileName;
                l_status.Text = "Image selected with correctly.";
                lHeightVal.Text = height.ToString();
                lWidthVal.Text = width.ToString();
                lNameVal.Text = file.SafeFileNames[0];
                lTypeVal.Text = Path.GetExtension(file.FileName);
                lSizeVal.Text = (new FileInfo(file.FileName).Length/1024).ToString() + "KB";
                FetchPixels();
                isEncrypted = false;
            }
        }
        private void bEncryptImage_Click(object sender, EventArgs e)
        {
            if (filePath == "")
            {
                MessageBox.Show("Please select a image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!isEncrypted)
                {
                    LastCharPadding(); // Adding padding pixels.

                    eRArray = Encryption(RArray.ToArray(), secretKey, RArray.Count, keyWidth, keyHeight);
                    eGArray = Encryption(GArray.ToArray(), secretKey, GArray.Count, keyWidth, keyHeight);
                    eBArray = Encryption(BArray.ToArray(), secretKey, BArray.Count, keyWidth, keyHeight);

                    CreateEncryptedImage(); // Encrypted image is creating.
                    isEncrypted = true;
                }
                else
                {
                    MessageBox.Show("Image was already encrypted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void bConnect_Click(object sender, EventArgs e) // Connect to server
        {
            if (stIpAddressVal.Text == "" || stPortVal.Text == "")
            {
                MessageBox.Show("Please enter the server ip and port.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (!isOpen)
                    {
                        IPHostEntry host = Dns.GetHostEntry("localhost");
                        IPAddress ipAddress = host.AddressList[1];
                        IPEndPoint remoteEP = new IPEndPoint(ipAddress, int.Parse(stPortVal.Text));

                        socketName = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp); // Defining socket params.
                        socketName.Connect(remoteEP); // Connect to server.
                        isOpen = true;
                        sbConnect.Text = "Disconnect";
                    }
                    else
                    {
                        isOpen = false;
                        sbConnect.Text = "Connect";
                        socketName.Shutdown(SocketShutdown.Both);
                        socketName.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void bSaveEncryptedImage_Click(object sender, EventArgs e) // Save encrypted image
        {
            if (isEncrypted)
            {
                SaveFileDialog fileDialog = new SaveFileDialog();
                fileDialog.Title = "Save Encryped Image";
                fileDialog.Filter = "Images|*.bmp";
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    encryptedImage.Save(fileDialog.FileName, ImageFormat.Bmp);
                }
            }
            else
            {
                MessageBox.Show("No encrypted image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // OTHER FUNCTIONS //
        private string ConvertString(int[] arr)
        {
            string output;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                sb.Append(arr[i]);
                sb.Append(",");
            }

            output = sb.ToString();
            return output;
        }
        private void FetchPixels() // Pixels are fetching.
        {
            Bitmap image = new Bitmap(filePath); // New image is creating.
            width = image.Width; // Width value is defining.
            height = image.Height; // Height value is defining.
            for (int row = 0; row < height; row++)
                for (int column = 0; column < width; column++)
                {
                    Color pixel = image.GetPixel(column, row);
                    RArray.Add(pixel.R); // Related pixel value is adding to list.
                    GArray.Add(pixel.G); // Related pixel value is adding to list.
                    BArray.Add(pixel.B); // Related pixel value is adding to list.
                }

            PictureBox.Image = image; // Created image is projecting on the screen.
        }
        // KEY GENERATION FUCTIONS //
        private void NewNumber()
        {
            MyNumber = rnd.Next(0, 256);
            if (!randomList.Contains(MyNumber))
                randomList.Add(MyNumber);
            else
            {
                NewNumber();
            }
        }
        private void generateSecretKey()
        {
            for (int k = 0; k < 256; k++)
                NewNumber();

            int i = 0, j = 0;
            foreach (int item in randomList)
            {
                secretKey[i] = item;
                i++;
            }
        }
        // ENCYRPTION //
        private int[] Encryption(int[] image, int[] key, int lenght, int widthofKey, int heightofKey)
        {
            l_status.Text = "Encrypting...";
            int[] encryptedText = new int[lenght];
            int character_1 = 0, character_2 = 0;
            int encrypedtedCharacter_1 = 0, encrypedtedCharacter_2 = 0;

            for (int encryptionCounter = 0; encryptionCounter < lenght; encryptionCounter += 2)
            {
                encrypedtedCharacter_1 = 0;
                encrypedtedCharacter_2 = 0;
                character_1 = image[encryptionCounter];
                character_2 = image[encryptionCounter + 1];

                /* Encryption */
                int rowCharacter_1 = 0, columnCharacter_1 = 0;
                int rowCharacter_2 = 0, columnCharacter_2 = 0;
                /* Location of current characters on the key */
                for (int rowCounterKey = 0; rowCounterKey < heightofKey; rowCounterKey++)
                {
                    for (int columnCounterKey = 0; columnCounterKey < widthofKey; columnCounterKey++)
                    {

                        /* Row and column detection of character_1 */
                        if (character_1 == key[columnCounterKey + rowCounterKey * heightofKey])
                        {
                            rowCharacter_1 = rowCounterKey;
                            columnCharacter_1 = columnCounterKey;
                        }

                        /* Row and column detection of character_2 */
                        if (character_2 == key[columnCounterKey + rowCounterKey * heightofKey])
                        {
                            rowCharacter_2 = rowCounterKey;
                            columnCharacter_2 = columnCounterKey;
                        }

                    }

                }

                /* If on the same row then todo */
                if (rowCharacter_1 == rowCharacter_2)
                {
                    if (columnCharacter_1 != widthofKey - 1)
                    {
                        encrypedtedCharacter_1 = key[(columnCharacter_1 + 1) + rowCharacter_1 * heightofKey];
                    }
                    else
                    {
                        encrypedtedCharacter_1 = key[rowCharacter_1 * heightofKey];
                    }

                    if (columnCharacter_2 != widthofKey - 1)
                    {
                        encrypedtedCharacter_2 = key[(columnCharacter_2 + 1) + rowCharacter_2 * heightofKey];
                    }
                    else
                    {
                        encrypedtedCharacter_2 = key[rowCharacter_2 * heightofKey];
                    }

                }
                /* If on the same column then todo */
                if (columnCharacter_1 == columnCharacter_2)
                {
                    if (rowCharacter_1 != heightofKey - 1)
                    {
                        encrypedtedCharacter_1 = key[columnCharacter_1 + (rowCharacter_1 + 1) * heightofKey];
                    }
                    else
                    {
                        encrypedtedCharacter_1 = key[columnCharacter_1];
                    }

                    if (rowCharacter_2 != heightofKey - 1)
                    {
                        encrypedtedCharacter_2 = key[columnCharacter_2 + (rowCharacter_2 + 1) * heightofKey];
                    }
                    else
                    {
                        encrypedtedCharacter_2 = key[columnCharacter_2];
                    }

                }
                /* If not both */
                if (rowCharacter_1 != rowCharacter_2 && columnCharacter_1 != columnCharacter_2)
                {
                    encrypedtedCharacter_1 = key[columnCharacter_2 + rowCharacter_1 * heightofKey];
                    encrypedtedCharacter_2 = key[columnCharacter_1 + rowCharacter_2 * heightofKey];
                }

                /* Encrypted equivalents */
                encryptedText[encryptionCounter] = encrypedtedCharacter_1;
                encryptedText[encryptionCounter + 1] = encrypedtedCharacter_2;

            }
            return encryptedText;
        }
        private void LastCharPadding()
        {
            if (RArray.Count % 2 != 0) // If count of list is odd, then adding padding value at the end of the list.
            {
                RArray.Add(128);
                GArray.Add(128);
                BArray.Add(128);
            }
        }
        private void CreateEncryptedImage()
        {
            if (filePath != "")
            {
                encryptedImage = new Bitmap(width, height); // Created new image.
                int globalPixelCounter = 0; // Global counter defined.

                for (int row = 0; row < height; row++)
                    for (int column = 0; column < width; column++)
                    {
                        encryptedImage.SetPixel(column, row, Color.FromArgb(eRArray[globalPixelCounter],
                                                                            eGArray[globalPixelCounter],
                                                                            eBArray[globalPixelCounter])); // Encrypted image is generating with encrypted pixels.
                        globalPixelCounter++;
                    }
                PictureBox.Image = encryptedImage;
                l_status.Text = "Image was encryped.";
            }
            else
            {
                MessageBox.Show("Please select a image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    
