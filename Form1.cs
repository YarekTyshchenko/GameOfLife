using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsApplication4
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private System.ComponentModel.IContainer components;

		private myMap map;          // Two map objects
        private myMap initialMap;
		private Bitmap bitmap, grid;
		private Color dead, alive;
        private int frames = 0, mapHeight, mapWidth;    //Init values
        private int generation = 0;
		private bool click = false;
        private bool warp = true;
        private bool showGrid = true;
        private int scale;
        private string rule = "B3/S23";
        // Generated stuff
        private System.Windows.Forms.Timer tick;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
        private PictureBox bigBox;
        private Timer fps;
        private MenuItem menuItem6;
        private MenuItem menuItem7;
        private MenuItem menuItem8;
        private MenuItem menuItem9;
        private MenuItem menuItem10;
        private MenuItem menuItem11;
        private MenuItem menuItem12;
        private MenuItem menuItem13;
        private MenuItem menuItem14;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolSTripStatusLabel1;
        private ToolStripStatusLabel stripFPSlabel;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel stripSimulationLabel;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel stripGridSizeX;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ToolStripStatusLabel stripGridSizeY;
        private MenuItem menuItem15;
        private MenuItem menuItem16;
        private MenuItem menuItem17;
        private MenuItem menuItem18;
        private ToolStripStatusLabel stripGenerationLabel;


        private System.Resources.ResourceManager rm;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            scale = 8; // scale of internal map

            mapWidth = bigBox.Width / scale; // Possible precision loss
            mapHeight = bigBox.Height / scale;
            
			dead = Color.White;     // Global colors for the display.
			alive = Color.Black;
            map = new myMap(rule, warp, mapWidth, mapHeight);
            //#### Internal Loading ####
            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            BinaryFormatter binaryRead = new BinaryFormatter();
            map = (myMap)binaryRead.Deserialize(    // Loading of interally saved map.
                thisExe.GetManifestResourceStream("WindowsApplication4.Resources.glidergun.yt"));
            //##########################
            map.Rule = rule;
            initialMap = map;
            //bitmap = map.GetBitmap();
            bitmap = new Bitmap(mapWidth, mapHeight);
            rescale();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tick = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.bigBox = new System.Windows.Forms.PictureBox();
            this.fps = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolSTripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripFPSlabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripGenerationLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripSimulationLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripGridSizeX = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripGridSizeY = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bigBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tick
            // 
            this.tick.Interval = 10;
            this.tick.Tick += new System.EventHandler(this.Tick_Tick);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "yt";
            this.saveFileDialog.Filter = "YarekT files|*.yt";
            this.saveFileDialog.Title = "Save current map";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem10,
            this.menuItem11});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5});
            this.menuItem1.Text = "File";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            this.menuItem5.Text = "Exit";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem7});
            this.menuItem2.Text = "Image";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 0;
            this.menuItem7.Text = "Save bitmap";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 2;
            this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem6,
            this.menuItem3,
            this.menuItem15,
            this.menuItem9,
            this.menuItem4,
            this.menuItem16,
            this.menuItem8});
            this.menuItem10.Text = "State";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 0;
            this.menuItem6.Text = "Save initial state";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "Save current state";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 2;
            this.menuItem15.Text = "-";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 3;
            this.menuItem9.Text = "Revert to initial state";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 4;
            this.menuItem4.Text = "Load saved state";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 5;
            this.menuItem16.Text = "-";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 6;
            this.menuItem8.Text = "Reset state";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 3;
            this.menuItem11.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem12,
            this.menuItem13,
            this.menuItem17,
            this.menuItem14,
            this.menuItem18});
            this.menuItem11.Text = "Simulation";
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 0;
            this.menuItem12.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
            this.menuItem12.Text = "Run";
            this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Enabled = false;
            this.menuItem13.Index = 1;
            this.menuItem13.Shortcut = System.Windows.Forms.Shortcut.CtrlH;
            this.menuItem13.Text = "Halt";
            this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 2;
            this.menuItem17.Text = "-";
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 3;
            this.menuItem14.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.menuItem14.Text = "Step";
            this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 4;
            this.menuItem18.Text = "Settings";
            this.menuItem18.Click += new System.EventHandler(this.menuItem18_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "yt";
            this.openFileDialog.Filter = "YarekT files|*.yt";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // bigBox
            // 
            this.bigBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bigBox.Location = new System.Drawing.Point(0, 0);
            this.bigBox.Name = "bigBox";
            this.bigBox.Size = new System.Drawing.Size(472, 240);
            this.bigBox.TabIndex = 11;
            this.bigBox.TabStop = false;
            this.bigBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bigBox_MouseMove);
            this.bigBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bigBox_MouseDown);
            this.bigBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bigBox_MouseUp);
            // 
            // fps
            // 
            this.fps.Enabled = true;
            this.fps.Interval = 1000;
            this.fps.Tick += new System.EventHandler(this.fps_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSTripStatusLabel1,
            this.stripFPSlabel,
            this.toolStripStatusLabel3,
            this.stripGenerationLabel,
            this.toolStripStatusLabel2,
            this.stripSimulationLabel,
            this.toolStripStatusLabel4,
            this.stripGridSizeX,
            this.toolStripStatusLabel5,
            this.stripGridSizeY});
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(472, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip";
            // 
            // toolSTripStatusLabel1
            // 
            this.toolSTripStatusLabel1.Name = "toolSTripStatusLabel1";
            this.toolSTripStatusLabel1.Size = new System.Drawing.Size(29, 17);
            this.toolSTripStatusLabel1.Text = "FPS:";
            // 
            // stripFPSlabel
            // 
            this.stripFPSlabel.AutoSize = false;
            this.stripFPSlabel.Name = "stripFPSlabel";
            this.stripFPSlabel.Size = new System.Drawing.Size(30, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(30, 17);
            this.toolStripStatusLabel3.Text = "Gen:";
            // 
            // stripGenerationLabel
            // 
            this.stripGenerationLabel.AutoSize = false;
            this.stripGenerationLabel.Name = "stripGenerationLabel";
            this.stripGenerationLabel.Size = new System.Drawing.Size(60, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel2.Text = "Rule:";
            // 
            // stripSimulationLabel
            // 
            this.stripSimulationLabel.AutoSize = false;
            this.stripSimulationLabel.Name = "stripSimulationLabel";
            this.stripSimulationLabel.Size = new System.Drawing.Size(70, 17);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(51, 17);
            this.toolStripStatusLabel4.Text = "Grid size:";
            // 
            // stripGridSizeX
            // 
            this.stripGridSizeX.Name = "stripGridSizeX";
            this.stripGridSizeX.Size = new System.Drawing.Size(31, 17);
            this.stripGridSizeX.Text = "0000";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel5.Text = "x";
            // 
            // stripGridSizeY
            // 
            this.stripGridSizeY.Name = "stripGridSizeY";
            this.stripGridSizeY.Size = new System.Drawing.Size(31, 17);
            this.stripGridSizeY.Text = "0000";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(472, 262);
            this.Controls.Add(this.bigBox);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Click += new System.EventHandler(this.StartButton_Click);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.bigBox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void start()
		{
            initialMap = map;
            generation = 0;
            tick.Start();
		}

		private void step() // The core of the application
		{
            frames++;
            generation++;
			myMap map_alt = new myMap(rule,warp, map.getwidth, map.getheight);
            //build using unsafe block, compile with /unsafe
            //Maximum atainable framerate seems to be 64
            //##############################################
            BitmapData bmData = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                int nOffset = stride - bitmap.Width * 3;
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    for (int x = 0; x < bitmap.Width; ++x)
                    {
                        if (map.getN(x, y))
                        {
                            map_alt.setPixel(x, y, true);
                            p[0] = p[1] = p[2] = (byte)(0); // there must be a better way
                        }
                        else
                        {
                            map_alt.setPixel(x, y, false);
                            p[0] = p[1] = p[2] = (byte)(255);
                        }
                        p += 3;
                    }
                    p += nOffset;
                }
            }

            bitmap.UnlockBits(bmData);
            //###############################################
            //End unsafe
            // Safe block runs at 50 fps
            /*
            for(int x=0; x<map.getwidth; x++)
			{
				for(int y=0; y<map.getheight; y++)
				{
					if(map.getN(x,y))
					{
						bitmap.SetPixel(x, y, alive);
                        map_alt.setPixel(x,y,true);
					} 
					else 
					{
                        bitmap.SetPixel(x, y, dead);
                        map_alt.setPixel(x,y,false);
					}
				}
			}
            */
            // End safe block
			map = map_alt;
			Invalidate();
		}

        private void drawGrid()
        {
            //grid = new Bitmap(bigBox.Width, bigBox.Height);
            //Graphics g = Graphics.FromImage(grid);
            
        }

		private void update()
		{
            if (tick.Enabled)
            {
                menuItem12.Enabled = false;
                menuItem13.Enabled = true;
                map.Lock = true;
            }
            else
            {
                menuItem12.Enabled = true;
                menuItem13.Enabled = false;
                map.Lock = false;
            }
            stripSimulationLabel.Text = rule;
            stripGenerationLabel.Text = generation.ToString();
            stripGridSizeX.Text = map.getwidth.ToString();
            stripGridSizeY.Text = map.getheight.ToString();
            bigBox.Image = ResizeImage(bitmap, map.getwidth * scale, map.getheight * scale);
            //bigBox.Image = grid;
		}

        private void draw(MouseButtons button, int x, int y)
        {
            if(x >= 0 && y >= 0 && x < bigBox.Width && y < bigBox.Height){
                double scalex = (double) x / scale;
                double scaley = (double) y / scale;
                x = (int)Math.Floor(scalex);
                y = (int)Math.Floor(scaley);

            if(x < mapWidth && y < mapHeight)
            {
                    Color color;
                    bool life;
                    if (button == MouseButtons.Left)
                    {
                        color = alive;
                        life = true;
                    }
                    else
                    {
                        color = dead;
                        life = false;
                    }
                    bitmap.SetPixel(x, y, color);
                    map.setPixel(x, y, life);
                    Invalidate();
                }
            }
        }

        private void tickToggle()
        {
            if (tick.Enabled)
            {
                tick.Stop();
            }
            else
            {
                start();
            }
        }

        private void reload() //Reloads from current internal map
        {
            bitmap = map.GetBitmap();
            tick.Stop();
            Invalidate();
        }

        private void rescale()
        {
            mapWidth = bigBox.Width / scale;
            mapHeight = bigBox.Height / scale;
            grid = new Bitmap(bigBox.Width, bigBox.Height);
            
                for (int x = 0; x < bigBox.Width; x++)
                {
                    for (int y = 0; y < bigBox.Height; y++)
                    {
                        if (x % scale == scale-1 || y % scale == scale-1)
                            grid.SetPixel(x, y, Color.Gray);
                    }
                }
            map.resize(mapWidth, mapHeight);
            initialMap.resize(mapWidth, mapHeight); // Cant be good
            reload();

        }

        public void setScale(int scale)
        {
            if (scale > 0 && scale <= 16 && scale != this.scale)
            {
                this.scale = scale;
                rescale();
            }
        }
        public int getScale()
        {
            return scale;
        }

        public string getRule()
        {
            return map.Rule;
        }
        public void setRule(string rule)
        {
            if (this.rule != rule)
            {
                this.rule = rule;
                map.changeRule(rule);
                initialMap.changeRule(rule);
            }
        }
        public int getSpeed()
        {
            return tick.Interval;
        }
        public void setSpeed(int speed)
        {
            tick.Interval = speed;
        }
        public bool getWarp()
        {
            return warp;
        }
        public void setWarp(bool warp)
        {
            this.warp = warp;
        }
        public bool getGrid()
        {
            return showGrid;
        }
        public void setGrid(bool grid)
        {
            if (showGrid != grid)
            {
                this.showGrid = grid;
                update();
            }
        }

        private Bitmap ResizeImage(Bitmap image, int width, int height)
        {
            //a holder for the result
            Bitmap result = new Bitmap(width, height);

            //use a graphics object to draw the resized image into the bitmap
            using (Graphics graphics = Graphics.FromImage(result))
            {
                //set the resize quality modes to high quality
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
                //draw the image into the target bitmap
                graphics.DrawImage(image, 0, 0, result.Width, result.Height);
                if (showGrid)
                    graphics.DrawImage(grid, 0, 0);

            }

            //return the resulting bitmap
            return result;
        }

		private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			update();
		}

		private void StepButton_Click(object sender, System.EventArgs e)
		{
            tick.Stop();
			step();
		}

		private void StartButton_Click(object sender, System.EventArgs e)
		{
            tickToggle();
		}

		private void Tick_Tick(object sender, System.EventArgs e)
		{
			step();
		}

        private void fps_Tick(object sender, EventArgs e)
        {
            stripFPSlabel.Text = frames.ToString();
            frames = 0;
        }
        #region Mouse methods
        private void bigBox_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;
            draw(e.Button, e.X, e.Y);
        }

        private void bigBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (click)
            {
                draw(e.Button, e.X, e.Y);
            }
        }

        private void bigBox_MouseUp(object sender, MouseEventArgs e)
        {
            click = false;
        }
        #endregion
        #region Saveing of Map region
        private void SaveMap(string filename, myMap map)
        {
            if (filename.ToString().Length > 0)
            {
                Stream streamWrite = File.Create(filename);
                BinaryFormatter binaryWrite = new BinaryFormatter();
                binaryWrite.Serialize(streamWrite, map);
                streamWrite.Close();
            }
        }

        private myMap LoadMap(string filename)
        {
            if (filename.ToString().Length > 0)
            {
                Stream streamRead = File.OpenRead(filename);
                BinaryFormatter binaryRead = new BinaryFormatter();
                myMap map = (myMap)binaryRead.Deserialize(streamRead);
                streamRead.Close();
                return map;
            }
            return this.map;
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (saveFileDialog.FileName != null)
                SaveMap(saveFileDialog.FileName, map);
        }

        private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            map = LoadMap(openFileDialog.FileName);
            bigBox.Width = map.getwidth * scale;
            bigBox.Height = map.getheight * scale;
            reload();
        }
        #endregion
        #region Menu item methods
        private void menuItem3_Click(object sender, System.EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void menuItem4_Click(object sender, System.EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            saveFileDialog.Title = "Save initial map";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != null)
                SaveMap(saveFileDialog.FileName, initialMap);
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            map = new myMap(rule,warp, mapWidth, mapHeight);
            reload();
        }

        private void menuItem9_Click(object sender, EventArgs e)
        {
            map = initialMap;
            reload();
        }

        private void menuItem12_Click(object sender, EventArgs e)
        {
            start();
        }

        private void menuItem13_Click(object sender, EventArgs e)
        {
            tick.Stop();
        }

        private void menuItem14_Click(object sender, EventArgs e)
        {
            tick.Stop();
            step();
        }
        #endregion

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if ((mapWidth != bigBox.Width / scale) || (mapHeight != bigBox.Height / scale))
            {
                rescale();
            }
        }

        private void menuItem18_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }
    }

    #region myMap class declaration
    [Serializable]
	class myMap 
	{
		//private Bitmap b;
        private Regex rulePattern;
        private string B, S;
		private bool [,] map;

		private int height;
		private int width;
        private bool locked;
        private bool warp;
        public bool Lock // while locked you cant resize it
        {
            get
            {
                return locked;
            }
            set
            {
                this.locked = value;
            }
        }
        private string rule = "B3/S23"; // Incase created without rule
        public string Rule
        {
            get
            {
                return this.rule;
            }
            set
            {
                if (rulePattern.IsMatch(value))
                {
                    this.rule = value;
                }
                
            }
        }

		public myMap(string rule, bool warp, int x, int y)
		{
            this.warp = warp;
			width = x;
			height = y;
			map = new bool[x,y];

            rulePattern = new Regex("^B(?'B'[0-8]*)/S(?'S'[0-8]*)$");
            //string rule = "B3/S23";
            //rule = "B234/S";
            Match match = rulePattern.Match(rule);
            B = match.Groups[1].ToString();
            S = match.Groups[2].ToString();
		}

        public void changeRule(string rule)
        {
            Match match = rulePattern.Match(rule);
            B = match.Groups[1].ToString();
            S = match.Groups[2].ToString();
            this.rule = rule;
        }

        public void resize(int x, int y)
        {
            if (!locked)
            {
                bool[,] map = new bool[x, y];
                
                for (int ix = 0; ix < x; ix++)
                {
                    for (int iy = 0; iy < y; iy++)
                    {
                        if (this.width > ix && this.height > iy) //internal map is smaller
                        {
                            map[ix, iy] = this.map[ix, iy];
                        }
                    }
                }
                //Array.Copy(this.map, map, this.map.Length);
                this.map = map;
                width = x;
                height = y;
            }
        }

        public int getheight
        {
            get
            {
                return height;
            }
        }
        public int getwidth
        {
            get
            {
                return width;
            }
        }

		public bool getN (int x, int y)
		{
			int i = 0;
			
			//Get number of naighbours and load into i
            i += getPixel(x-1,y-1);
			i += getPixel(x,y-1);
			i += getPixel(x+1,y-1);

			i += getPixel(x-1,y);
			int cell = getPixel(x,y);
			i += getPixel(x+1,y);
			
			i += getPixel(x-1,y+1);
			i += getPixel(x,y+1);
			i += getPixel(x+1,y+1);

            return calculate(cell, i);
	    }

		public void setPixel(int x, int y, bool life)
		{
            if ((x >= 0) && (x < width))
                if ((y >= 0) && (y < height))
                    map[x,y] = life;
		}

		public int getPixel(int x, int y)
		{
            if (warp)
            {
                if (x < 0)
                    x = x + width;
                if (y < 0)
                    y = y + height;

                x = x % width;
                y = y % height;
            }
            else
            {
                if (x < 0 || x >= width)
                    return 0;
                if (y < 0 || y >= height)
                    return 0;
            }

			if(map[x,y])
				return 1;
			return 0;
		}
		public Bitmap GetBitmap()
		{
            Bitmap b = new Bitmap(width, height);
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (map[x, y])
                    {
                        b.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        b.SetPixel(x, y, Color.White);
                    }
                }
            }
			return b;
		}

		public void LoadBitmap(Bitmap b)
		{
		    // not implemented (=
		}

        public bool calculate(int cell, int i)
        {
            if (cell == 0) // dead cell
            {
                for (int c = 0; c < B.Length; c++)
                {
                    if (i == int.Parse(B[c].ToString()))
                        return true;
                }
                return false;
                //if (i == 3)
                //     return true;
                //else
                //    return false;
            }
            else
            {
                for (int c = 0; c < S.Length; c++)
                {
                    if (i == int.Parse(S[c].ToString()))
                        return true;
                }
                return false;
                //if (i <= 1)
                //{
                //    return false;
                //}
                //else if (i >= 4)
                //{
                //    return false;
                //}
                //else
                //{
                //    return true;
                //}
            }
        }
	}
    #endregion
}
