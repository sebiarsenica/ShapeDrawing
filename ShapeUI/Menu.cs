using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapeApplication;




namespace ShapeUI
{
    public partial class Menu : Form
    {
        internal Graphics graphics;
        private Point LeftClickLocation;
        private Point RightClickLocation;
        private Point RightClickLocation2;
        Shape shape;
        private ShapeType shapetype;
        Color color = Color.Black;
        private string filepath = "";

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e) //Load Menu event
        {
            panel_Draw.Visible = false;
            button_DrawCircle.Visible = false; 
            button_DrawRectangle.Visible = false;
            HideRectangle();
            HideLine();
            HideCircle();
            HideSquare();
            HideTriangle();
            HidePicture();
            Global.tool.LoadFromDisk();
            
        }

        private void ShowControls()
        {
            if (panel_Draw.Visible == false)
                panel_Draw.Visible = true;
        } //Show main panel

        private void UpdateComboBox() //Update the combobox
        {
            string Name = "";
            switch (shapetype)
            {
                case ShapeType.Circle: Name = "circle"; break;
                case ShapeType.Rectangle: Name = "rectangle"; break;
                case ShapeType.Line: Name = "line"; break;
                case ShapeType.Square: Name = "square"; break;
                case ShapeType.Triangle: Name = "triangle"; break;
                case ShapeType.Picture: Name = "picture"; break;
            }

            comboBox_Shapes.Items.Clear();
            foreach (var shape in Global.tool.Shapes)
            {
                if (shape.Name.StartsWith(Name))
                    comboBox_Shapes.Items.Add(shape.Name);

            }

        }

        private int VerifyRectangleTextBox() //Verify rectangle textboxes values
        {
            int nr = 0;
            if (string.IsNullOrEmpty(textBox_Height.Text))
            {
                textBoxErrors.SetError(textBox_Height, "This field cannot be empty!"); nr++;
            }
            else
                if (int.TryParse(textBox_Height.Text, out _) == false)
            {
                textBoxErrors.SetError(textBox_Height, "This needs to be an integer!"); nr++;
            }
            else
                textBoxErrors.SetError(textBox_Height, null);

            if (string.IsNullOrEmpty(textBox_Width.Text))
            {
                textBoxErrors.SetError(textBox_Width, "This field cannot be empty!"); nr++;
            }
            else
                if (int.TryParse(textBox_Width.Text, out _) == false)
            {
                textBoxErrors.SetError(textBox_Width, "This needs to be an integer!"); nr++;
            }
            else
                textBoxErrors.SetError(textBox_Width, null);

            return nr;

        }

        #region Events
        private void panel_Draw_MouseClick(object sender, MouseEventArgs e) //Get left/right click coords 
        {
            if (e.Button == MouseButtons.Left)
            {
                LeftClickLocation.X = e.X;
                LeftClickLocation.Y = e.Y;
                label_X_Value.Text = e.X.ToString();
                label_Y_Value.Text = e.Y.ToString();
            }
            if (shapetype == ShapeType.Line || shapetype == ShapeType.Triangle)
                if (e.Button == MouseButtons.Right)

                    if (shapetype == ShapeType.Triangle && checkBox_Point2.Checked)
                    {
                        RightClickLocation2.X = e.X; 
                        RightClickLocation2.Y = e.Y;
                        label_Point2_X.Text = "Point2 x: " + e.X;
                        label_Point2_Y.Text = "Point2 y: " + e.Y;
                    }
                    else
                    {
                        RightClickLocation.X = e.X;
                        RightClickLocation.Y = e.Y;
                        label_Height.Text = "Point x: " + e.X;
                        label_Width.Text = "Point y: " + e.Y;
                    }
                
        }

        private void comboBox_Shapes_SelectedIndexChanged(object sender, EventArgs e) //Change combobox selected item
        {
            shape = Global.tool.Shapes.Find(item => item.Name == comboBox_Shapes.SelectedItem.ToString());
            label_X_Value.Text = shape.Origin.X.ToString();
            label_Y_Value.Text = shape.Origin.Y.ToString();
            
            shape.Draw(graphics,color);
        }

        private void panel_Draw_Paint(object sender, PaintEventArgs e) //Panel paint event
        {
            graphics = panel_Draw.CreateGraphics();
            if (Global.tool.Shapes.Count == 0) return;
            Global.tool.Draw(graphics, shape,color);
        }

        private void Menu_Resize(object sender, EventArgs e) //Form resize event
        {
            graphics = panel_Draw.CreateGraphics();

        }
        #endregion

        #region Buttons 
        private void button_MoveTo_Click(object sender, EventArgs e) //Move shape
        {
            panel_Draw.Invalidate();
            Point2d point = new Point2d() { X = Convert.ToInt32(label_X_Value.Text), Y = Convert.ToInt32(label_Y_Value.Text) };
            shape.MoveTo(point);
            graphics = panel_Draw.CreateGraphics();
            Global.tool.Draw(graphics, shape, color);
        }

        private void button_Resize_Click(object sender, EventArgs e) //Resize shape
        {
            int nr = 0;
            if (string.IsNullOrEmpty(textBox_ResizeFactor.Text))
            {
                textBoxErrors.SetError(textBox_ResizeFactor, "This field cannot be empty!"); nr++;
            }
            else
                if (double.TryParse(textBox_ResizeFactor.Text, out _) == false)
            {
                textBoxErrors.SetError(textBox_ResizeFactor, "This needs to be a double number!"); nr++;
            }
            else
                textBoxErrors.SetError(textBox_ResizeFactor, null);

            if (nr > 0) return;
            shape.Resize(Convert.ToDouble(textBox_ResizeFactor.Text));
            panel_Draw.Invalidate();
            shape.Draw(graphics, color);
        }

        private void button_Save_Click(object sender, EventArgs e) //Save button
        {
            Global.tool.SaveOnDisk();
        }

        private void button_Remove_Click(object sender, EventArgs e) //Remove shape button
        {
            if(comboBox_Shapes.Items.Count == 0) return;
            Global.tool.Remove(shape);
            UpdateComboBox();
            if(comboBox_Shapes.Items.Count>0)
            comboBox_Shapes.SelectedIndex = 0;
            if (comboBox_Shapes.Items.Count == 0)
            { comboBox_Shapes.ResetText();
                shape = null;
                panel_Draw.Invalidate();
            }
            panel_Draw.Invalidate();
        }

        private void button_DrawAll_Click(object sender, EventArgs e) //Draw All
        {
            Global.tool.DrawAll(graphics, color);
        }

        private void button_Area_Click(object sender, EventArgs e) //Get shape area
        {
            label_Area.Text = "Area: " + shape.Area();
        }

        private void button_Clear_Click(object sender, EventArgs e) //Clear all drawings button
        {
            comboBox_Shapes.ResetText();
            shape = null;
            panel_Draw.Invalidate();
            panel_Draw.Invalidate();
        }

        private void ColorPicker_Click(object sender, EventArgs e) //Color picker
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
            }
        }

        private void button_SearchPicture_Click(object sender, EventArgs e) //Search picture
        {
            
            Picture_FileDialog = new OpenFileDialog(); 
            Picture_FileDialog.Filter = "jpg files (*.jpg)|*.jpg|All files(*.*)|*.*";
            Picture_FileDialog.FilterIndex = 1;
            Picture_FileDialog.RestoreDirectory = false;
            if (Picture_FileDialog.ShowDialog() == DialogResult.OK)
                filepath = Picture_FileDialog.FileName;
        }

        #endregion

        #region Draw Buttons 

        private void button_DrawRectangle_Click(object sender, EventArgs e) //Draw the rectangle shape
        {
            if (VerifyRectangleTextBox() > 0)
                return;
            if (LeftClickLocation.X == 0)
            { MessageBox.Show("You need to select a position first!"); return; }
            Global.tool.Add(ShapeType.Rectangle, new Dictionary<string, object>()
            {
                {"Origin", new Point2d{X = LeftClickLocation.X, Y= LeftClickLocation.Y} },
                {"Point", new Point2d{X = Convert.ToInt32(textBox_Width.Text), Y = Convert.ToInt32(textBox_Height.Text)} }
            });
            UpdateComboBox();
            comboBox_Shapes.SelectedIndex = comboBox_Shapes.Items.Count - 1;
        }

        private void button_DrawCircle_Click(object sender, EventArgs e) //Draw the circle shape
        {
            textBoxErrors.SetError(textBox_Height, null);
            if (string.IsNullOrEmpty(textBox_Height.Text))
            { textBoxErrors.SetError(textBox_Height, "Field empty!"); return; }
            else
                if (double.TryParse(textBox_Height.Text, out _) == false)
            { textBoxErrors.SetError(textBox_Height, "Field needs to be a double number!");
                return;
            }
            if (LeftClickLocation.X == 0)
            { MessageBox.Show("You need to select a position first!"); return; }

            Global.tool.Add(ShapeType.Circle, new Dictionary<string, object>()
            {
                {"Origin", new Point2d{X = LeftClickLocation.X, Y= LeftClickLocation.Y} },
                {"Radius", (Convert.ToDouble(textBox_Height.Text)) }
            });
            UpdateComboBox();
            comboBox_Shapes.SelectedIndex = comboBox_Shapes.Items.Count - 1;
        }

        private void button_DrawLine_Click(object sender, EventArgs e) //Draw the line shape
        {

            Global.tool.Add(ShapeType.Line, new Dictionary<string, object>()
            {
                {"Origin", new Point2d{X = LeftClickLocation.X, Y= LeftClickLocation.Y} },
                {"Point", new Point2d{X= RightClickLocation.X, Y = RightClickLocation.Y } }
            });
            UpdateComboBox();
            comboBox_Shapes.SelectedIndex = comboBox_Shapes.Items.Count - 1;
        }

        private void button_DrawTriangle_Click(object sender, EventArgs e)
        {
            if (LeftClickLocation.X == 0)
            { MessageBox.Show("You need to select a position first!"); return; }
            if(RightClickLocation.X == 0)
            { MessageBox.Show("You need to select a position first!"); return; }
            if (RightClickLocation2.X == 0 )
            { MessageBox.Show("You need to select a position first!"); return; }
            Global.tool.Add(ShapeType.Triangle, new Dictionary<string, object>()
            {
                {"Origin", new Point2d{X = LeftClickLocation.X,Y= LeftClickLocation.Y} },
                {"Point2", new Point2d {X = RightClickLocation.X, Y= RightClickLocation.Y} },
                {"Point3", new Point2d {X= RightClickLocation2.X,Y=RightClickLocation2.Y } }
            });
            UpdateComboBox();
            comboBox_Shapes.SelectedIndex = comboBox_Shapes.Items.Count - 1;
        } //Draw the triangle shape

        private void button1_DrawSquare_Click(object sender, EventArgs e)  //Draw the square shape
        {
            textBoxErrors.SetError(textBox_Height, null);
            if (string.IsNullOrEmpty(textBox_Height.Text))
            { textBoxErrors.SetError(textBox_Height, "Field empty!"); return; }
            else
                if (double.TryParse(textBox_Height.Text, out _) == false)
            {
                textBoxErrors.SetError(textBox_Height, "Field needs to be a double number!");
                return;
            }
            if (LeftClickLocation.X == 0)
            { MessageBox.Show("You need to select a position first!"); return; }

            Global.tool.Add(ShapeType.Square, new Dictionary<string, object>()
            {
                {"Origin", new Point2d{X = LeftClickLocation.X, Y= LeftClickLocation.Y} },
                {"Height", (Convert.ToDouble(textBox_Height.Text)) }
            });
            UpdateComboBox();
            comboBox_Shapes.SelectedIndex = comboBox_Shapes.Items.Count - 1;

        }

        private void button_DrawPicture_Click(object sender, EventArgs e)  //Draw the picture
        {
            if (string.IsNullOrEmpty(filepath)) return;
            if (LeftClickLocation.X == 0)
            { MessageBox.Show("You need to select a position first!"); return; }

            Global.tool.Add(ShapeType.Picture, new Dictionary<string, object>()
            {
                {"Origin", new Point2d{X= LeftClickLocation.X,Y= LeftClickLocation.Y} },
                {"FilePath", (filepath) }
            });
            UpdateComboBox();
            comboBox_Shapes.SelectedIndex = comboBox_Shapes.Items.Count - 1;
        }

        #endregion

        #region Show-Hide control
        private void HideCurrentMenu()
        {
            if (shapetype == 0) return;
            switch (shapetype)
            {
                case ShapeType.Circle: HideCircle(); break;
                case ShapeType.Rectangle: HideRectangle(); break;
                case ShapeType.Line: HideLine(); break;
                case ShapeType.Square: HideSquare(); break;
                case ShapeType.Triangle: HideTriangle(); break;
                case ShapeType.Picture: HidePicture(); break;
            }
        }

        private void ShowCurrentMenu()
        {
            if (shapetype == 0) return;
            switch (shapetype)
            {
                case ShapeType.Circle: ShowCircle(); break;
                case ShapeType.Rectangle: ShowRectangle(); break;
                case ShapeType.Line: ShowLine(); break;
                case ShapeType.Square: ShowSquare(); break;
                case ShapeType.Triangle: ShowTriangle(); break;
                case ShapeType.Picture: ShowPicture(); break;
            }
        }

        private void HideRectangle() //Hide rectangle controls
        {
            label_Height.Visible = false;
            label_Width.Visible = false;
            textBox_Height.Visible = false;
            textBox_Width.Visible = false;
            button_DrawRectangle.Visible = false;
            textBox_Height.Text = "";
            textBox_Width.Text = "";
        }

        private void ShowRectangle() //Show rectangle controls
        {
            label_Height.Visible = true;
            label_Width.Visible = true;
            textBox_Height.Visible = true;
            textBox_Width.Visible = true;
            button_DrawRectangle.Visible = true;
            
        }

        private void HideCircle() //Hide circle controls
        {
            button_DrawCircle.Visible = false;
            textBox_Height.Visible = false;
            label_Height.Visible = false;
            textBox_Height.Text = "";
            label_Height.Text = "Height";
        }

        private void ShowCircle()  //Show circle controls
        {
            button_DrawCircle.Visible = true;
            label_Height.Text = "Radius";
            label_Height.Visible = true;
            textBox_Height.Visible = true;
        } 

        private void HideLine() //Hide line controls
        {
            button_DrawLine.Visible = false;
            label_Height.Text = "Height";
            label_Height.Visible = false;
            label_Width.Text = "Width";
            label_Width.Visible = false;
           
        } 
       
        private void ShowLine()  //Show line controls
        {
            button_DrawLine.Visible = true;
            label_Height.Text = "Point x: ";
            label_Height.Visible = true;
            label_Width.Text = "Point y: ";
            label_Width.Visible = true;
            
        } 
        
        private void HideSquare() //Hide square controls
        {
           button1_DrawSquare.Visible = false;
            label_Height.Visible = false;
            textBox_Height.Visible = false;
            textBox_Height.Text = "";
        }  

        private void ShowSquare() //Show square controls
        {
            button1_DrawSquare.Visible = true;
            label_Height.Visible = true;
            textBox_Height.Visible = true;
        }  

        private void HideTriangle() //Hide triangle controls
        {
            button_DrawTriangle.Visible = false;
            label_Height.Text = "Height";
            label_Height.Visible = false;
            label_Width.Text = "Width";
            label_Width.Visible = false;
            label_Point2_X.Visible = false;
            label_Point2_Y.Visible = false;
            checkBox_Point2.Visible = false;
        } 

        private void ShowTriangle() //Show triangle controls
        {
            button_DrawTriangle.Visible = true;
            label_Height.Text = "Point1 x: ";
            label_Height.Visible = true;
            label_Width.Text = "Point1 y: ";
            label_Width.Visible = true;
            label_Point2_X.Visible = true;
            label_Point2_Y.Visible = true;
            checkBox_Point2.Visible = true;
        } 

        private void HidePicture() //Hide picture controls
        {
            button_SearchPicture.Visible = false;
            button_DrawPicture.Visible = false;
        }

        private void ShowPicture() //Show picture controls
        {
            button_SearchPicture.Visible = true;
            button_DrawPicture.Visible = true;
        }

        #endregion

        #region Menu Manage
        
        private void button_Rectangle_Click(object sender, EventArgs e) //Rectangle button click
        {
            ShowControls();
            HideCurrentMenu();
            shapetype = ShapeType.Rectangle;
            ShowCurrentMenu();
            UpdateComboBox();
            comboBox_Shapes.ResetText();
            shape = null;
            panel_Draw.Invalidate();
        }

        private void button_Circle_Click(object sender, EventArgs e) //Circle button click
        {
            ShowControls();
            HideCurrentMenu();
            shapetype = ShapeType.Circle;
            ShowCurrentMenu();
            UpdateComboBox();
            comboBox_Shapes.ResetText();
            shape = null;
            panel_Draw.Invalidate();
        }

        private void button_Line_Click(object sender, EventArgs e) //Line button click
        {
            ShowControls();
            HideCurrentMenu();
            shapetype = ShapeType.Line;
            ShowCurrentMenu();
            UpdateComboBox();
            comboBox_Shapes.ResetText();
            shape = null;
            panel_Draw.Invalidate();
        }

        private void button_Square_Click(object sender, EventArgs e) //Square button click
        {
            ShowControls();
            HideCurrentMenu();
            shapetype = ShapeType.Square;
            ShowCurrentMenu();
            UpdateComboBox();
            comboBox_Shapes.ResetText();
            shape = null;
            panel_Draw.Invalidate();
        }

        private void button_Triangle_Click(object sender, EventArgs e) //Triangle button click
        {
            ShowControls();
            HideCurrentMenu();
            shapetype = ShapeType.Triangle;
            ShowCurrentMenu();
            UpdateComboBox();
            comboBox_Shapes.ResetText();
            shape = null;
            panel_Draw.Invalidate();
        }

        private void button_Picture_Click(object sender, EventArgs e) //Picture button click
        {
            ShowControls();
            HideCurrentMenu();
            shapetype = ShapeType.Picture;
            ShowCurrentMenu();
            UpdateComboBox();
            comboBox_Shapes.ResetText();
            shape = null;
            panel_Draw.Invalidate();
        }


        #endregion

       
    }
}
