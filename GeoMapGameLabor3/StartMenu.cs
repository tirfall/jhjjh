using System.Windows.Forms;
//https://stackoverflow.com/questions/1733912/how-do-i-handle-dragging-of-a-label-in-c
namespace GeoMapGameLabor3
{
    public partial class StartMenu : Form
    {
        Rectangle Rectangle = new Rectangle(10, 10, 200, 100);
        Rectangle Circle = new Rectangle(220, 10, 150, 150);
        Rectangle Square = new Rectangle(380, 10, 150, 150);
        int Y_sqr = 0, X_sqr = 0, Y_crl = 0, X_crl = 0, Y_rct = 0, X_rct = 0, X_label=0, Y_label=0;
        PictureBox pb;
        Label l1, l2, l3;
        bool SquareBool = false, CircleBool = false, RectangleBool = false, LabelBool = false;
        int X_l3 = 0, Y_l3 = 0;
        bool Label3Bool = false;
        public StartMenu()
        {
            this.Height = 800;
            this.Width = 1000;
            this.Text = "Start menu";

            pb = new PictureBox();

            
            
            pb.Location = new Point(10, 10);
            
            pb.Size = new Size(900, 700);
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.BorderStyle = BorderStyle.Fixed3D;
            pb.Paint += new PaintEventHandler(pb_Paint);
            pb.MouseDown += new MouseEventHandler(pb_MouseDown);
            pb.MouseMove += new MouseEventHandler(pb_MouseMove);
            pb.MouseUp += new MouseEventHandler(pb_MouseUp);
            this.Controls.Add(pb);

            l1 = new Label();
            l1.Font = new Font("Arial", 24, FontStyle.Bold);
            l1.Text = "Vid";
            l1.Location = new Point(10, 500);
            l1.Size = new Size(100, 100);
            l1.BackColor = Color.LightGray;
            l1.BorderStyle = BorderStyle.Fixed3D;
            pb.Controls.Add(l1);

            l2 = new Label();
            l2.Font = new Font("Arial", 24, FontStyle.Bold);
            l2.Text = "Forma";
            l2.Location = new Point(l1.Width + 30, 500);
            l2.Size = new Size(100, 100);
            l2.BackColor = Color.LightGray;
            l2.BorderStyle = BorderStyle.Fixed3D;
            pb.Controls.Add(l2);

            l3 = new Label();
            l3.Font = new Font("Arial", 24, FontStyle.Bold);
            l3.Text = "Info";
            l3.Location = new Point(l2.Width + 200, 500);
            l3.Size = new Size(100, 100);
            l3.BackColor = Color.LightGray;
            l3.BorderStyle = BorderStyle.Fixed3D;
            pb.Controls.Add(l3);

            l3.MouseDown += new MouseEventHandler(l3_MouseDown);
            l3.MouseMove += new MouseEventHandler(l3_MouseMove);
            l3.MouseUp += new MouseEventHandler(l3_MouseUp);
        }

        private void l3_MouseUp(object? sender, MouseEventArgs e)
        {
            Label3Bool = false;
        }

        private void l3_MouseMove(object? sender, MouseEventArgs e)
        {
            if (Label3Bool)
            {
                l3.Left += e.X - X_label;
                l3.Top += e.Y - Y_label;
            }
        }

        private void l3_MouseDown(object? sender, MouseEventArgs e)
        {
            if ((e.X < l3.Width) && (e.X > 0))
            {
                if ((e.Y < l3.Height) && (e.Y > 0))
                {
                    Label3Bool = true;

                    X_label = e.X;
                    Y_label = e.Y;
                }
            }
        }

        private void pb_MouseMove(object? sender, MouseEventArgs e)
        {
            
            if (SquareBool)
            {
                Square.X = e.X - X_sqr;
                Square.Y = e.Y - Y_sqr;
            }
            if (CircleBool)
            {
                Circle.X = e.X - X_crl;
                Circle.Y = e.Y - Y_crl;
            }
            if (RectangleBool)
            {
                Rectangle.X = e.X - X_rct;
                Rectangle.Y = e.Y - Y_rct;
            }
            
            pb.Invalidate();
        }

        private void pb_MouseUp(object? sender, MouseEventArgs e)
        {
            CircleBool = false;
            RectangleBool = false;
            SquareBool = false;

            if((l1.Location.X < Square.X + Square.Width) && (l1.Location.X > Square.X))
            {
                if((l1.Location.Y < Square.Y + Square.Height) &&(l1.Location.Y > Square.Y))
                {
                    l3.Text = "Sinine square";
                }
            }
        }

        private void pb_MouseDown(object? sender, MouseEventArgs e)
        {
            if ((e.X < Rectangle.X + Rectangle.Width) && (e.X > Rectangle.X))
            {
                if ((e.Y < Rectangle.Y + Rectangle.Height) && (e.Y > Rectangle.Y))
                {
                    RectangleBool = true;

                    X_rct = e.X - Rectangle.X;
                    Y_rct = e.Y - Rectangle.Y;
                }
            }
            if ((e.X < Circle.X + Circle.Width) && (e.X > Circle.X))
            {
                if ((e.Y < Circle.Y + Circle.Height) && (e.Y > Circle.Y))
                {
                    CircleBool = true;

                    X_crl = e.X - Circle.X;
                    Y_crl = e.Y - Circle.Y;
                }
            }
            if ((e.X < Square.X + Square.Width) && (e.X > Square.X))
            {
                if ((e.Y < Square.Y + Square.Height) && (e.Y > Square.Y))
                {
                    SquareBool = true;

                    X_sqr = e.X - Square.X;
                    Y_sqr = e.Y - Square.Y;
                }
            }
        }

        private void pb_Paint(object? sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, Circle);
            e.Graphics.FillRectangle(Brushes.Blue, Square);
            e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);
        }
    }
}