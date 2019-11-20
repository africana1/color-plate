using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Color_Plate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 200);
            this.MaximizeBox = false;
            StatusLabel1.Text = "Ready";
            StatusLabel2.Text = "Ready";
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            using (var Colorchange = new ColorDialog())
                if
                    (Colorchange.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.NewColor = Colorchange.Color;
                    Properties.Settings.Default.Save();
                    StatusLabel1.Text = "Last Click: My Color";
                }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {            
            btnResetColor.BackColor = Color.Olive;
            this.tabControl1.SelectedTab.BackColor = Color.Olive;
            Color_Plate.Properties.Settings.Default.ColorRest = Color.Olive;
            Color_Plate.Properties.Settings.Default.Save();
            StatusLabel1.Text = "Last Click: Reset";
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            btnGreen.BackColor = Color.Red;
            this.tabControl1.SelectedTab.BackColor = Color.Green;
            Color_Plate.Properties.Settings.Default.Green = Color.Green;
            Color_Plate.Properties.Settings.Default.Save();
            StatusLabel1.Text = "Last Click: Green";
        }
        private void btnRed_Click(object sender, EventArgs e)
        {
            btnRed.BackColor = Color.Red;
            this.tabControl1.SelectedTab.BackColor = Color.Red;
            Color_Plate.Properties.Settings.Default.Red = Color.Red;
            Color_Plate.Properties.Settings.Default.Save();
            StatusLabel1.Text = "Last Click: Red";
        }

        private void btnBrown_Click(object sender, EventArgs e)
        {
            btnBrown.BackColor = Color.Brown;
            this.tabControl1.SelectedTab.BackColor = Color.Brown;
            Color_Plate.Properties.Settings.Default.Brown = Color.Brown;
            Color_Plate.Properties.Settings.Default.Save();
            StatusLabel1.Text = "Last Click: Brown";
        }

        private void btnAlmond_Click(object sender, EventArgs e)
        {
            btnAlmond.BackColor = Color.BlanchedAlmond;
            this.tabControl1.SelectedTab.BackColor = Color.BlanchedAlmond;
            Color_Plate.Properties.Settings.Default.Yellow = Color.BlanchedAlmond;
            Color_Plate.Properties.Settings.Default.Save();
            StatusLabel1.Text = "Last Click: Almond";
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            btnYellow.BackColor = Color.Yellow;
            this.tabControl1.SelectedTab.BackColor = Color.Yellow;
            Color_Plate.Properties.Settings.Default.Yellow = Color.Yellow;
            Color_Plate.Properties.Settings.Default.Save();
            StatusLabel1.Text = "Last Click: Yellow";
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            btnOrange.BackColor = Color.Orange;
            this.tabControl1.SelectedTab.BackColor = Color.Orange;
            Color_Plate.Properties.Settings.Default.Orange = Color.Orange;
            Color_Plate.Properties.Settings.Default.Save();
            StatusLabel1.Text = "Last Click: Orange";
        }

        private void btnViolet_Click(object sender, EventArgs e)
        {
            btnViolet.BackColor = Color.Violet;
            this.tabControl1.SelectedTab.BackColor = Color.Violet;
            Color_Plate.Properties.Settings.Default.Violet = Color.Violet;
            Color_Plate.Properties.Settings.Default.Save();
            StatusLabel1.Text = "Last Click: Violet";

        }

        private void btnBeige_Click(object sender, EventArgs e)
        {
            btnBeige.BackColor = Color.Beige;
            this.tabControl1.SelectedTab.BackColor = Color.Beige;
            Color_Plate.Properties.Settings.Default.Beige = Color.Beige;
            Color_Plate.Properties.Settings.Default.Save();
            StatusLabel1.Text = "Last Click: Beige";
        }

        private void btnCoral_Click(object sender, EventArgs e)
        {
            btnCoral.BackColor = Color.Coral;
            this.tabControl1.SelectedTab.BackColor = Color.Coral;
            Color_Plate.Properties.Settings.Default.Coral = Color.Coral;
            Color_Plate.Properties.Settings.Default.Save();
            StatusLabel1.Text = "Last Click: Coral";
        }

        private void btnCyan_Click(object sender, EventArgs e)
        {
            btnCyan.BackColor = Color.Cyan;
            this.tabControl1.SelectedTab.BackColor = Color.Cyan;
            Color_Plate.Properties.Settings.Default.Cyan = Color.Cyan;
            Color_Plate.Properties.Settings.Default.Save();
            StatusLabel1.Text = "Last Click: Cyan";
        }

        private void btnDeepPink_Click(object sender, EventArgs e)
        {
            btnDeepPink.BackColor = Color.DeepPink;
            this.tabControl1.SelectedTab.BackColor = Color.DeepPink;
            Color_Plate.Properties.Settings.Default.DeepPink = Color.DeepPink;
            Color_Plate.Properties.Settings.Default.Save();
            StatusLabel1.Text = "Last Click: Deep Pink";
        }
        
        private void btnFireBrick_Click(object sender, EventArgs e)
        {
            btnFireBrick.BackColor = Color.Firebrick;
            this.tabControl1.SelectedTab.BackColor = Color.Firebrick;
            Color_Plate.Properties.Settings.Default.FireBrick = Color.Firebrick;
            Color_Plate.Properties.Settings.Default.Save();
            StatusLabel1.Text = "Last Click: Fire Brick";
        }        

        private void btnGold_Click(object sender, EventArgs e)
        {
            btnGold.BackColor = Color.Gold;
            this.tabControl1.SelectedTab.BackColor = Color.Gold;
            Color_Plate.Properties.Settings.Default.Gold = Color.Gold;
            Color_Plate.Properties.Settings.Default.Save();
            StatusLabel1.Text = "Last Click: Gold";
        }

        private void btnIndigo_Click(object sender, EventArgs e)
        {
            btnIndigo.BackColor = Color.IndianRed;
            this.tabControl1.SelectedTab.BackColor = Color.Indigo;
            Color_Plate.Properties.Settings.Default.Indigo = Color.Indigo;
            Color_Plate.Properties.Settings.Default.Save();
            StatusLabel1.Text = "Last Click: Indigo";
        }

        private void btnIvory_Click(object sender, EventArgs e)
        {
            btnIvory.BackColor = Color.Ivory;
            this.tabControl1.SelectedTab.BackColor = Color.Ivory;
            Color_Plate.Properties.Settings.Default.Ivory = Color.Ivory;
            Color_Plate.Properties.Settings.Default.Save();
            StatusLabel1.Text = "Last Click: Ivory";
        }

        private void btnLavender_Click(object sender, EventArgs e)
        {
            btnLavender.BackColor = Color.Lavender;
            this.tabControl1.SelectedTab.BackColor = Color.Lavender;
            Color_Plate.Properties.Settings.Default.Lavender = Color.Lavender;
            Color_Plate.Properties.Settings.Default.Save();
            StatusLabel1.Text = "Last Click: Lavender";
        }

        private void btnABBC_Click(object sender, EventArgs e)
        {
            btnABBC.BackColor = Color.LightSeaGreen;
            this.tabControl1.SelectedTab.BackColor = Color.LightSeaGreen;
            Color_Plate.Properties.Settings.Default.ABBC = Color.LightSeaGreen;
            Color_Plate.Properties.Settings.Default.Save();
            StatusLabel1.Text = "Last Click: ABBC";
        }

        private void btnMagenta_Click(object sender, EventArgs e)
        {           
            btnMagenta.BackColor = Color.Magenta;
            this.tabControl1.SelectedTab.BackColor = Color.Magenta;
            Color_Plate.Properties.Settings.Default.Magenta = Color.Magenta;
            Color_Plate.Properties.Settings.Default.Save();
            StatusLabel1.Text = "Last Click: Magenta";
        }

        #region Region Color....

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AllowFullOpen = false;
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            colorDlg.Color = Color.Red;

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {

                textBox1.ForeColor = colorDlg.Color;
                listBox1.ForeColor = colorDlg.Color;
                button3.ForeColor = colorDlg.Color;
                button4.ForeColor = colorDlg.Color;
                Properties.Settings.Default.ColFont = colorDlg.Color;
                Properties.Settings.Default.Save();
                StatusLabel2.Text = "Last Used: Fore Color";
            }
        }

        #endregion 

        #region Region Color Section...

        private void button2_Click(object sender, EventArgs e)
        {
            {
                ColorDialog colorDlg = new ColorDialog();
                if (colorDlg.ShowDialog() == DialogResult.OK)
                {
                    textBox1.BackColor = colorDlg.Color;
                    listBox1.BackColor = colorDlg.Color;
                    button3.BackColor = colorDlg.Color;
                    button4.ForeColor = colorDlg.Color;
                    Properties.Settings.Default.BackGrd2 = colorDlg.Color;
                    Properties.Settings.Default.Save();
                    StatusLabel2.Text = "Last Used: Back Color";
                }
            }
        }

        #endregion

        #region Region Font Section...

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog myfontdialog = new FontDialog();
            myfontdialog.ShowColor = true;
            myfontdialog.ShowApply = true;
            myfontdialog.ShowEffects = true;
            myfontdialog.ShowHelp = true;
            myfontdialog.MaxSize = 28;
            myfontdialog.MinSize = 10;

            if (myfontdialog.ShowDialog() != DialogResult.Cancel)
            {
                textBox1.Font = myfontdialog.Font;
                listBox1.Font = myfontdialog.Font;
                button3.Font = myfontdialog.Font;
                button4.Font = myfontdialog.Font;
                Properties.Settings.Default.RealFont = myfontdialog.Font;
                Properties.Settings.Default.Save();
                StatusLabel2.Text = "Last Used: Font";
            }
        }

        #endregion 

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this.tabControl1.SelectedTab = tabPage2;
            this.tabControl1.SelectedIndex = 0;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage1;
        }
    }
}
