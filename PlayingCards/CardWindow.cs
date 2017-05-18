using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlayingCards
{
    public partial class CardWindow : Form
    {
        private CardDeck myDeck = new CardDeck();

        public CardWindow()
        {
            InitializeComponent();
            LoadCards();
        }

        static void Main(string[] args)
        {
            Application.Run(new CardWindow());
        }

        private void LoadCards()
        {
            flowLayoutPanel1.Controls.Clear();
            int pictureBoxCount = -100;
            string imagePath = "";
            int y = 0;
            PictureBox pictureBox = new PictureBox();

            foreach (PlayingCard p in myDeck.GetDeck())
            {
                imagePath = "";
                switch ((int)p.Rank)
                {
                    case 0:
                        imagePath += "ace";
                        break;
                    case 10:
                        imagePath += "jack";
                        break;
                    case 11:
                        imagePath += "queen";
                        break;
                    case 12:
                        imagePath += "king";
                        break;
                    default:
                        imagePath += (int)p.Rank + 1;
                        break;

                }

                switch ((int)p.Suit)
                {
                    case 0:
                        imagePath += "_of_diamonds";
                        break;
                    case 1:
                        imagePath += "_of_clubs";
                        break;
                    case 2:
                        imagePath += "_of_hearts";
                        break;
                    case 3:
                        imagePath += "_of_spades";
                        break;
                }
                imagePath += ".png";
               
                pictureBox.Location = new Point(pictureBoxCount + 120, y);
                pictureBox.Size = new Size(70, 90);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromFile("CardImages\\" + imagePath);
                flowLayoutPanel1.Controls.Add(CreatePictureBox(pictureBox));
                pictureBoxCount++;
            }
        }

        private PictureBox CreatePictureBox(PictureBox source)
        {
            PictureBox temp = new PictureBox();
            temp.Location = source.Location;
            temp.Size = source.Size;
            temp.SizeMode = source.SizeMode;
            temp.Image = source.Image;

            return temp;
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            myDeck.ShuffleDeck();
            LoadCards();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            myDeck.SortDeck();
            LoadCards();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
