using floorAndWalls;
using System.ComponentModel.DataAnnotations;

namespace PaintProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Wall wall1 = new Wall();

            //Wall[] listOfWalls = new Wall[10];

            //listOfWalls[0] = new Wall();

            //List<Item>;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FloorArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //A room is usually 4 walls connected
            // First Wall , try parse the string into a float for calulation

            if (float.TryParse(Wall1Length.Text, out float length1))
            {
                WriteLine("Succesfully parsed text into float");

            }

            else
            {
                throw new Exception(message: "Must be a number");
            }

            if (float.TryParse(WallWidth1.Text, out float width1))
            {
                WriteLine("Succesfully parsed text into float");

            }

            else
            {
                throw new Exception(message: "Must be a number");
            }

            Wall wall1 = new Wall(length1, width1);
            //Wall2

            if (float.TryParse(WallLength2.Text, out float length2))
            {
                WriteLine("Succesfully parsed text into float");
            }

            else
            {
                throw new Exception(message: "Must be a number");
            }

            if (float.TryParse(WallWidth2.Text, out float width2))
            {
                WriteLine("Succesfully parsed text into float");

            }

            else
            {
                throw new Exception(message: "Must be a number");
            }
            Wall wall2 = new Wall(length2, width2);

            //Wall 3
            if (float.TryParse(WallLength3.Text, out float length3))
            {
                WriteLine("Succesfully parsed text into float");
            }

            else
            {
                throw new Exception(message: "Must be a number");
            }
            if (float.TryParse(WallWidth3.Text, out float width3))
            {
                WriteLine("Succesfully parsed text into float");

            }

            else
            {
                throw new Exception(message: "Must be a number");
            }
            Wall wall3 = new Wall(length3, width3);

            //Wall4

            if (float.TryParse(WallLength4.Text, out float length4))
            {
                WriteLine("Succesfully parsed text into float");
            }

            else
            {
                throw new Exception(message: "Must be a number");
            }

            if (float.TryParse(WallWidth4.Text, out float width4))
            {
                WriteLine("Succesfully parsed text into float");

            }

            else
            {
                throw new Exception(message: "Must be a number");
            }
            Wall wall4 = new Wall(length4, width4);

            float totalArea = wall1.Area + wall2.Area + wall3.Area + wall4.Area;

            tbCalculatedPaint.Text = totalArea.ToString();





        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Wall1Length_TextChanged(object sender, EventArgs e)
        {

        }

        private void WallWidth1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCalculatedPaint_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (float.TryParse(FloorLength.Text, out float fFloorLength))
            {

            }
            else
            {
                Console.WriteLine("Cannot Parse value");

            }


            if (float.TryParse(FloorWidth.Text, out float fFloorWidth))
            {

            }
            else
            {
                Console.WriteLine("Cannot Parse value");

            }

            if (float.TryParse(Wall1Length.Text, out float fHeight))
            {

            }
            else
            {
                Console.WriteLine("Cannot Parse value");

            }

            float volume = fHeight * fFloorLength * fFloorWidth;

            tbCalculateVolume.Text = volume.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (float.TryParse(FloorLength.Text, out float fFloorLength))
            {

            }

            else
            {
                throw new ArgumentException(message: "Parameters not valid");
            }

            if (float.TryParse(FloorWidth.Text, out float fFloorWidth))
            {

            }

            else
            {
                throw new ArgumentException(message: "Parameters not valid");
            }

            Floor floor = new Floor(fFloorLength, fFloorWidth);
            tbFloorArea.Text = (floor.Area).ToString();


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
