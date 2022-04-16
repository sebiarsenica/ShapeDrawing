namespace ShapeUI
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.button_Triangle = new System.Windows.Forms.Button();
            this.button_Square = new System.Windows.Forms.Button();
            this.button_Line = new System.Windows.Forms.Button();
            this.button_Circle = new System.Windows.Forms.Button();
            this.button_Rectangle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_Draw = new System.Windows.Forms.Panel();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_DrawAll = new System.Windows.Forms.Button();
            this.button1_DrawSquare = new System.Windows.Forms.Button();
            this.label_Area = new System.Windows.Forms.Label();
            this.checkBox_Point2 = new System.Windows.Forms.CheckBox();
            this.label_Point2_Y = new System.Windows.Forms.Label();
            this.label_Point2_X = new System.Windows.Forms.Label();
            this.button_DrawTriangle = new System.Windows.Forms.Button();
            this.button_DrawLine = new System.Windows.Forms.Button();
            this.ColorPicker = new System.Windows.Forms.PictureBox();
            this.button_DrawCircle = new System.Windows.Forms.Button();
            this.button_Area = new System.Windows.Forms.Button();
            this.textBox_ResizeFactor = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Resize = new System.Windows.Forms.Button();
            this.button_MoveTo = new System.Windows.Forms.Button();
            this.comboBox_Shapes = new System.Windows.Forms.ComboBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_DrawRectangle = new System.Windows.Forms.Button();
            this.textBox_Width = new System.Windows.Forms.TextBox();
            this.textBox_Height = new System.Windows.Forms.TextBox();
            this.label_Width = new System.Windows.Forms.Label();
            this.label_Height = new System.Windows.Forms.Label();
            this.label_Y_Value = new System.Windows.Forms.Label();
            this.label_X_Value = new System.Windows.Forms.Label();
            this.label_Y_Text = new System.Windows.Forms.Label();
            this.label_X_Text = new System.Windows.Forms.Label();
            this.textBoxErrors = new System.Windows.Forms.ErrorProvider(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button_Picture = new System.Windows.Forms.Button();
            this.button_DrawPicture = new System.Windows.Forms.Button();
            this.Picture_FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button_SearchPicture = new System.Windows.Forms.Button();
            this.panel_Menu.SuspendLayout();
            this.panel_Draw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxErrors)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel_Menu.Controls.Add(this.button_Picture);
            this.panel_Menu.Controls.Add(this.button_Triangle);
            this.panel_Menu.Controls.Add(this.button_Square);
            this.panel_Menu.Controls.Add(this.button_Line);
            this.panel_Menu.Controls.Add(this.button_Circle);
            this.panel_Menu.Controls.Add(this.button_Rectangle);
            this.panel_Menu.Controls.Add(this.panel2);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(244, 632);
            this.panel_Menu.TabIndex = 0;
            // 
            // button_Triangle
            // 
            this.button_Triangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Triangle.BackColor = System.Drawing.SystemColors.ControlText;
            this.button_Triangle.FlatAppearance.BorderSize = 0;
            this.button_Triangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Triangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Triangle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Triangle.Location = new System.Drawing.Point(-2, 382);
            this.button_Triangle.Margin = new System.Windows.Forms.Padding(2);
            this.button_Triangle.Name = "button_Triangle";
            this.button_Triangle.Size = new System.Drawing.Size(246, 41);
            this.button_Triangle.TabIndex = 17;
            this.button_Triangle.Text = "Triangle           🛆";
            this.button_Triangle.UseVisualStyleBackColor = false;
            this.button_Triangle.Click += new System.EventHandler(this.button_Triangle_Click);
            // 
            // button_Square
            // 
            this.button_Square.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Square.BackColor = System.Drawing.SystemColors.ControlText;
            this.button_Square.FlatAppearance.BorderSize = 0;
            this.button_Square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Square.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Square.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Square.Location = new System.Drawing.Point(-2, 337);
            this.button_Square.Margin = new System.Windows.Forms.Padding(2);
            this.button_Square.Name = "button_Square";
            this.button_Square.Size = new System.Drawing.Size(246, 41);
            this.button_Square.TabIndex = 16;
            this.button_Square.Text = "Square            ⧠";
            this.button_Square.UseVisualStyleBackColor = false;
            this.button_Square.Click += new System.EventHandler(this.button_Square_Click);
            // 
            // button_Line
            // 
            this.button_Line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Line.BackColor = System.Drawing.SystemColors.ControlText;
            this.button_Line.FlatAppearance.BorderSize = 0;
            this.button_Line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Line.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Line.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Line.Location = new System.Drawing.Point(-2, 292);
            this.button_Line.Margin = new System.Windows.Forms.Padding(2);
            this.button_Line.Name = "button_Line";
            this.button_Line.Size = new System.Drawing.Size(246, 41);
            this.button_Line.TabIndex = 15;
            this.button_Line.Text = "Line                 |";
            this.button_Line.UseVisualStyleBackColor = false;
            this.button_Line.Click += new System.EventHandler(this.button_Line_Click);
            // 
            // button_Circle
            // 
            this.button_Circle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Circle.BackColor = System.Drawing.SystemColors.ControlText;
            this.button_Circle.FlatAppearance.BorderSize = 0;
            this.button_Circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Circle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Circle.Location = new System.Drawing.Point(-2, 247);
            this.button_Circle.Margin = new System.Windows.Forms.Padding(2);
            this.button_Circle.Name = "button_Circle";
            this.button_Circle.Size = new System.Drawing.Size(246, 41);
            this.button_Circle.TabIndex = 3;
            this.button_Circle.Text = "Circle             ◯";
            this.button_Circle.UseVisualStyleBackColor = false;
            this.button_Circle.Click += new System.EventHandler(this.button_Circle_Click);
            // 
            // button_Rectangle
            // 
            this.button_Rectangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Rectangle.BackColor = System.Drawing.SystemColors.ControlText;
            this.button_Rectangle.FlatAppearance.BorderSize = 0;
            this.button_Rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Rectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Rectangle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Rectangle.Location = new System.Drawing.Point(0, 202);
            this.button_Rectangle.Margin = new System.Windows.Forms.Padding(2);
            this.button_Rectangle.Name = "button_Rectangle";
            this.button_Rectangle.Size = new System.Drawing.Size(240, 41);
            this.button_Rectangle.TabIndex = 2;
            this.button_Rectangle.Text = "Rectangle       ▭";
            this.button_Rectangle.UseVisualStyleBackColor = false;
            this.button_Rectangle.Click += new System.EventHandler(this.button_Rectangle_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(250, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 517);
            this.panel2.TabIndex = 1;
            // 
            // panel_Draw
            // 
            this.panel_Draw.BackColor = System.Drawing.SystemColors.Info;
            this.panel_Draw.Controls.Add(this.button_SearchPicture);
            this.panel_Draw.Controls.Add(this.button_DrawPicture);
            this.panel_Draw.Controls.Add(this.button_Remove);
            this.panel_Draw.Controls.Add(this.button_DrawAll);
            this.panel_Draw.Controls.Add(this.button1_DrawSquare);
            this.panel_Draw.Controls.Add(this.label_Area);
            this.panel_Draw.Controls.Add(this.checkBox_Point2);
            this.panel_Draw.Controls.Add(this.label_Point2_Y);
            this.panel_Draw.Controls.Add(this.label_Point2_X);
            this.panel_Draw.Controls.Add(this.button_DrawTriangle);
            this.panel_Draw.Controls.Add(this.button_DrawLine);
            this.panel_Draw.Controls.Add(this.ColorPicker);
            this.panel_Draw.Controls.Add(this.button_DrawCircle);
            this.panel_Draw.Controls.Add(this.button_Area);
            this.panel_Draw.Controls.Add(this.textBox_ResizeFactor);
            this.panel_Draw.Controls.Add(this.button_Save);
            this.panel_Draw.Controls.Add(this.button_Resize);
            this.panel_Draw.Controls.Add(this.button_MoveTo);
            this.panel_Draw.Controls.Add(this.comboBox_Shapes);
            this.panel_Draw.Controls.Add(this.button_Clear);
            this.panel_Draw.Controls.Add(this.button_DrawRectangle);
            this.panel_Draw.Controls.Add(this.textBox_Width);
            this.panel_Draw.Controls.Add(this.textBox_Height);
            this.panel_Draw.Controls.Add(this.label_Width);
            this.panel_Draw.Controls.Add(this.label_Height);
            this.panel_Draw.Controls.Add(this.label_Y_Value);
            this.panel_Draw.Controls.Add(this.label_X_Value);
            this.panel_Draw.Controls.Add(this.label_Y_Text);
            this.panel_Draw.Controls.Add(this.label_X_Text);
            this.panel_Draw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Draw.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Draw.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_Draw.Location = new System.Drawing.Point(244, 0);
            this.panel_Draw.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Draw.Name = "panel_Draw";
            this.panel_Draw.Size = new System.Drawing.Size(1162, 632);
            this.panel_Draw.TabIndex = 1;
            this.panel_Draw.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Draw_Paint);
            this.panel_Draw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_Draw_MouseClick);
            // 
            // button_Remove
            // 
            this.button_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Remove.Location = new System.Drawing.Point(772, 13);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(96, 24);
            this.button_Remove.TabIndex = 27;
            this.button_Remove.Text = "Remove ";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // button_DrawAll
            // 
            this.button_DrawAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DrawAll.Location = new System.Drawing.Point(9, 106);
            this.button_DrawAll.Name = "button_DrawAll";
            this.button_DrawAll.Size = new System.Drawing.Size(96, 24);
            this.button_DrawAll.TabIndex = 26;
            this.button_DrawAll.Text = "Draw All";
            this.button_DrawAll.UseVisualStyleBackColor = true;
            this.button_DrawAll.Click += new System.EventHandler(this.button_DrawAll_Click);
            // 
            // button1_DrawSquare
            // 
            this.button1_DrawSquare.Location = new System.Drawing.Point(457, 21);
            this.button1_DrawSquare.Margin = new System.Windows.Forms.Padding(2);
            this.button1_DrawSquare.Name = "button1_DrawSquare";
            this.button1_DrawSquare.Size = new System.Drawing.Size(38, 32);
            this.button1_DrawSquare.TabIndex = 25;
            this.button1_DrawSquare.Text = "⧠";
            this.button1_DrawSquare.UseVisualStyleBackColor = true;
            this.button1_DrawSquare.Click += new System.EventHandler(this.button1_DrawSquare_Click);
            // 
            // label_Area
            // 
            this.label_Area.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Area.AutoSize = true;
            this.label_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Area.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Area.Location = new System.Drawing.Point(991, 68);
            this.label_Area.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Area.Name = "label_Area";
            this.label_Area.Size = new System.Drawing.Size(60, 24);
            this.label_Area.TabIndex = 24;
            this.label_Area.Text = "Area:";
            // 
            // checkBox_Point2
            // 
            this.checkBox_Point2.AutoSize = true;
            this.checkBox_Point2.Location = new System.Drawing.Point(321, 86);
            this.checkBox_Point2.Name = "checkBox_Point2";
            this.checkBox_Point2.Size = new System.Drawing.Size(87, 28);
            this.checkBox_Point2.TabIndex = 23;
            this.checkBox_Point2.Text = "Point2";
            this.checkBox_Point2.UseVisualStyleBackColor = true;
            // 
            // label_Point2_Y
            // 
            this.label_Point2_Y.AutoSize = true;
            this.label_Point2_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Point2_Y.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Point2_Y.Location = new System.Drawing.Point(156, 90);
            this.label_Point2_Y.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Point2_Y.Name = "label_Point2_Y";
            this.label_Point2_Y.Size = new System.Drawing.Size(90, 24);
            this.label_Point2_Y.TabIndex = 21;
            this.label_Point2_Y.Text = "Point2 y:";
            // 
            // label_Point2_X
            // 
            this.label_Point2_X.AutoSize = true;
            this.label_Point2_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Point2_X.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Point2_X.Location = new System.Drawing.Point(156, 64);
            this.label_Point2_X.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Point2_X.Name = "label_Point2_X";
            this.label_Point2_X.Size = new System.Drawing.Size(91, 24);
            this.label_Point2_X.TabIndex = 20;
            this.label_Point2_X.Text = "Point2 x:";
            // 
            // button_DrawTriangle
            // 
            this.button_DrawTriangle.Location = new System.Drawing.Point(508, 21);
            this.button_DrawTriangle.Margin = new System.Windows.Forms.Padding(2);
            this.button_DrawTriangle.Name = "button_DrawTriangle";
            this.button_DrawTriangle.Size = new System.Drawing.Size(38, 32);
            this.button_DrawTriangle.TabIndex = 19;
            this.button_DrawTriangle.Text = "🛆";
            this.button_DrawTriangle.UseVisualStyleBackColor = true;
            this.button_DrawTriangle.Click += new System.EventHandler(this.button_DrawTriangle_Click);
            // 
            // button_DrawLine
            // 
            this.button_DrawLine.Location = new System.Drawing.Point(405, 21);
            this.button_DrawLine.Margin = new System.Windows.Forms.Padding(2);
            this.button_DrawLine.Name = "button_DrawLine";
            this.button_DrawLine.Size = new System.Drawing.Size(38, 32);
            this.button_DrawLine.TabIndex = 18;
            this.button_DrawLine.Text = " |";
            this.button_DrawLine.UseVisualStyleBackColor = true;
            this.button_DrawLine.Click += new System.EventHandler(this.button_DrawLine_Click);
            // 
            // ColorPicker
            // 
            this.ColorPicker.Image = global::ShapeUI.Properties.Resources.colorpicker;
            this.ColorPicker.Location = new System.Drawing.Point(26, 64);
            this.ColorPicker.Margin = new System.Windows.Forms.Padding(2);
            this.ColorPicker.Name = "ColorPicker";
            this.ColorPicker.Size = new System.Drawing.Size(51, 37);
            this.ColorPicker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ColorPicker.TabIndex = 17;
            this.ColorPicker.TabStop = false;
            this.ColorPicker.Click += new System.EventHandler(this.ColorPicker_Click);
            // 
            // button_DrawCircle
            // 
            this.button_DrawCircle.Location = new System.Drawing.Point(356, 21);
            this.button_DrawCircle.Margin = new System.Windows.Forms.Padding(2);
            this.button_DrawCircle.Name = "button_DrawCircle";
            this.button_DrawCircle.Size = new System.Drawing.Size(38, 32);
            this.button_DrawCircle.TabIndex = 16;
            this.button_DrawCircle.Text = "◯";
            this.button_DrawCircle.UseVisualStyleBackColor = true;
            this.button_DrawCircle.Click += new System.EventHandler(this.button_DrawCircle_Click);
            // 
            // button_Area
            // 
            this.button_Area.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Area.Location = new System.Drawing.Point(1095, 42);
            this.button_Area.Name = "button_Area";
            this.button_Area.Size = new System.Drawing.Size(58, 24);
            this.button_Area.TabIndex = 15;
            this.button_Area.Text = "Area";
            this.button_Area.UseVisualStyleBackColor = true;
            this.button_Area.Click += new System.EventHandler(this.button_Area_Click);
            // 
            // textBox_ResizeFactor
            // 
            this.textBox_ResizeFactor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ResizeFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ResizeFactor.Location = new System.Drawing.Point(936, 43);
            this.textBox_ResizeFactor.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ResizeFactor.Name = "textBox_ResizeFactor";
            this.textBox_ResizeFactor.Size = new System.Drawing.Size(34, 23);
            this.textBox_ResizeFactor.TabIndex = 14;
            this.textBox_ResizeFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.Location = new System.Drawing.Point(874, 13);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(96, 24);
            this.button_Save.TabIndex = 13;
            this.button_Save.Text = "Save ";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Resize
            // 
            this.button_Resize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Resize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Resize.Location = new System.Drawing.Point(976, 42);
            this.button_Resize.Name = "button_Resize";
            this.button_Resize.Size = new System.Drawing.Size(96, 23);
            this.button_Resize.TabIndex = 12;
            this.button_Resize.Text = "Resize";
            this.button_Resize.UseVisualStyleBackColor = true;
            this.button_Resize.Click += new System.EventHandler(this.button_Resize_Click);
            // 
            // button_MoveTo
            // 
            this.button_MoveTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_MoveTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MoveTo.Location = new System.Drawing.Point(976, 13);
            this.button_MoveTo.Name = "button_MoveTo";
            this.button_MoveTo.Size = new System.Drawing.Size(96, 24);
            this.button_MoveTo.TabIndex = 11;
            this.button_MoveTo.Text = "Move To";
            this.button_MoveTo.UseVisualStyleBackColor = true;
            this.button_MoveTo.Click += new System.EventHandler(this.button_MoveTo_Click);
            // 
            // comboBox_Shapes
            // 
            this.comboBox_Shapes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_Shapes.FormattingEnabled = true;
            this.comboBox_Shapes.Location = new System.Drawing.Point(608, 21);
            this.comboBox_Shapes.Name = "comboBox_Shapes";
            this.comboBox_Shapes.Size = new System.Drawing.Size(158, 30);
            this.comboBox_Shapes.TabIndex = 10;
            this.comboBox_Shapes.SelectedIndexChanged += new System.EventHandler(this.comboBox_Shapes_SelectedIndexChanged);
            // 
            // button_Clear
            // 
            this.button_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Clear.Location = new System.Drawing.Point(1077, 0);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(2);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(83, 36);
            this.button_Clear.TabIndex = 9;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_DrawRectangle
            // 
            this.button_DrawRectangle.Location = new System.Drawing.Point(304, 21);
            this.button_DrawRectangle.Margin = new System.Windows.Forms.Padding(2);
            this.button_DrawRectangle.Name = "button_DrawRectangle";
            this.button_DrawRectangle.Size = new System.Drawing.Size(38, 32);
            this.button_DrawRectangle.TabIndex = 8;
            this.button_DrawRectangle.Text = "▭";
            this.button_DrawRectangle.UseVisualStyleBackColor = true;
            this.button_DrawRectangle.Click += new System.EventHandler(this.button_DrawRectangle_Click);
            // 
            // textBox_Width
            // 
            this.textBox_Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Width.Location = new System.Drawing.Point(233, 41);
            this.textBox_Width.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Width.Name = "textBox_Width";
            this.textBox_Width.Size = new System.Drawing.Size(57, 23);
            this.textBox_Width.TabIndex = 7;
            // 
            // textBox_Height
            // 
            this.textBox_Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Height.Location = new System.Drawing.Point(233, 13);
            this.textBox_Height.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Height.Name = "textBox_Height";
            this.textBox_Height.Size = new System.Drawing.Size(57, 23);
            this.textBox_Height.TabIndex = 6;
            // 
            // label_Width
            // 
            this.label_Width.AutoSize = true;
            this.label_Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Width.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Width.Location = new System.Drawing.Point(156, 37);
            this.label_Width.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Width.Name = "label_Width";
            this.label_Width.Size = new System.Drawing.Size(69, 24);
            this.label_Width.TabIndex = 5;
            this.label_Width.Text = "Width:";
            // 
            // label_Height
            // 
            this.label_Height.AutoSize = true;
            this.label_Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Height.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Height.Location = new System.Drawing.Point(156, 11);
            this.label_Height.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Height.Name = "label_Height";
            this.label_Height.Size = new System.Drawing.Size(77, 24);
            this.label_Height.TabIndex = 4;
            this.label_Height.Text = "Height:";
            // 
            // label_Y_Value
            // 
            this.label_Y_Value.AutoSize = true;
            this.label_Y_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Y_Value.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Y_Value.Location = new System.Drawing.Point(43, 37);
            this.label_Y_Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Y_Value.Name = "label_Y_Value";
            this.label_Y_Value.Size = new System.Drawing.Size(0, 24);
            this.label_Y_Value.TabIndex = 3;
            // 
            // label_X_Value
            // 
            this.label_X_Value.AutoSize = true;
            this.label_X_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_X_Value.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_X_Value.Location = new System.Drawing.Point(43, 11);
            this.label_X_Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_X_Value.Name = "label_X_Value";
            this.label_X_Value.Size = new System.Drawing.Size(0, 24);
            this.label_X_Value.TabIndex = 2;
            // 
            // label_Y_Text
            // 
            this.label_Y_Text.AutoSize = true;
            this.label_Y_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Y_Text.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Y_Text.Location = new System.Drawing.Point(22, 37);
            this.label_Y_Text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Y_Text.Name = "label_Y_Text";
            this.label_Y_Text.Size = new System.Drawing.Size(29, 24);
            this.label_Y_Text.TabIndex = 1;
            this.label_Y_Text.Text = "Y:";
            // 
            // label_X_Text
            // 
            this.label_X_Text.AutoSize = true;
            this.label_X_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_X_Text.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_X_Text.Location = new System.Drawing.Point(22, 11);
            this.label_X_Text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_X_Text.Name = "label_X_Text";
            this.label_X_Text.Size = new System.Drawing.Size(31, 24);
            this.label_X_Text.TabIndex = 0;
            this.label_X_Text.Text = "X:";
            // 
            // textBoxErrors
            // 
            this.textBoxErrors.BlinkRate = 5;
            this.textBoxErrors.ContainerControl = this;
            // 
            // button_Picture
            // 
            this.button_Picture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Picture.BackColor = System.Drawing.SystemColors.ControlText;
            this.button_Picture.FlatAppearance.BorderSize = 0;
            this.button_Picture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Picture.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Picture.Location = new System.Drawing.Point(-2, 427);
            this.button_Picture.Margin = new System.Windows.Forms.Padding(2);
            this.button_Picture.Name = "button_Picture";
            this.button_Picture.Size = new System.Drawing.Size(246, 41);
            this.button_Picture.TabIndex = 18;
            this.button_Picture.Text = "Picture           🖼";
            this.button_Picture.UseVisualStyleBackColor = false;
            this.button_Picture.Click += new System.EventHandler(this.button_Picture_Click);
            // 
            // button_DrawPicture
            // 
            this.button_DrawPicture.Location = new System.Drawing.Point(554, 21);
            this.button_DrawPicture.Margin = new System.Windows.Forms.Padding(2);
            this.button_DrawPicture.Name = "button_DrawPicture";
            this.button_DrawPicture.Size = new System.Drawing.Size(38, 32);
            this.button_DrawPicture.TabIndex = 28;
            this.button_DrawPicture.Text = "🖼";
            this.button_DrawPicture.UseVisualStyleBackColor = true;
            this.button_DrawPicture.Click += new System.EventHandler(this.button_DrawPicture_Click);
            // 
            // Picture_FileDialog
            // 
            this.Picture_FileDialog.FileName = "openFileDialog1";
            // 
            // button_SearchPicture
            // 
            this.button_SearchPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SearchPicture.Location = new System.Drawing.Point(137, 13);
            this.button_SearchPicture.Name = "button_SearchPicture";
            this.button_SearchPicture.Size = new System.Drawing.Size(129, 24);
            this.button_SearchPicture.TabIndex = 29;
            this.button_SearchPicture.Text = "Search Picture";
            this.button_SearchPicture.UseVisualStyleBackColor = true;
            this.button_SearchPicture.Click += new System.EventHandler(this.button_SearchPicture_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1406, 632);
            this.Controls.Add(this.panel_Draw);
            this.Controls.Add(this.panel_Menu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1422, 671);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Resize += new System.EventHandler(this.Menu_Resize);
            this.panel_Menu.ResumeLayout(false);
            this.panel_Draw.ResumeLayout(false);
            this.panel_Draw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxErrors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_Draw;
        private System.Windows.Forms.Button button_Rectangle;
        private System.Windows.Forms.Label label_Y_Text;
        private System.Windows.Forms.Label label_X_Text;
        private System.Windows.Forms.Label label_X_Value;
        private System.Windows.Forms.Label label_Y_Value;
        private System.Windows.Forms.Label label_Width;
        private System.Windows.Forms.Label label_Height;
        private System.Windows.Forms.TextBox textBox_Width;
        private System.Windows.Forms.TextBox textBox_Height;
        private System.Windows.Forms.Button button_DrawRectangle;
        private System.Windows.Forms.ErrorProvider textBoxErrors;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.ComboBox comboBox_Shapes;
        private System.Windows.Forms.Button button_Resize;
        private System.Windows.Forms.Button button_MoveTo;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_ResizeFactor;
        private System.Windows.Forms.Button button_Line;
        private System.Windows.Forms.Button button_Circle;
        private System.Windows.Forms.Button button_Triangle;
        private System.Windows.Forms.Button button_Square;
        private System.Windows.Forms.Button button_Area;
        private System.Windows.Forms.Button button_DrawCircle;
        private System.Windows.Forms.PictureBox ColorPicker;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button_DrawLine;
        private System.Windows.Forms.Button button_DrawTriangle;
        private System.Windows.Forms.Label label_Point2_Y;
        private System.Windows.Forms.Label label_Point2_X;
        private System.Windows.Forms.CheckBox checkBox_Point2;
        private System.Windows.Forms.Label label_Area;
        private System.Windows.Forms.Button button1_DrawSquare;
        private System.Windows.Forms.Button button_DrawAll;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button_Picture;
        private System.Windows.Forms.Button button_DrawPicture;
        private System.Windows.Forms.Button button_SearchPicture;
        private System.Windows.Forms.OpenFileDialog Picture_FileDialog;
    }
}