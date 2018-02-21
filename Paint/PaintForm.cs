
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using PluginStub;
using System.Threading;
using System.ComponentModel;

namespace Paint
{
  public partial class PaintForm : Form, IPaintSettings
  {
    private ImageFile imageFile;
    private ToolArgs toolArgs;
    private Tool curTool;
    private IPaintSettings settings;
    public ICollection<IPlugin> plugs;
    Dictionary<string, IPlugin> _Plugins= new Dictionary<string, IPlugin>();
    Stack<ImageFile> stack = new Stack<ImageFile>(10);

    public PaintForm() {
      InitializeComponent();
      toolsBar.ImageList = imageList;
      settings = (IPaintSettings)this;
    }

    private void toolsBar_ButtonClick(object sender, ToolBarButtonClickEventArgs e) {
      if(curTool!=null)
        curTool.UnloadTool();
      ToolBarButton curButton = e.Button;
      SetToolBarButtonsState(curButton);

      if (curButton == lineBtn) {
        curTool = new LineTool(toolArgs);
      } else if (curButton == rectangleBtn) {
        curTool = new RectangleTool(toolArgs);
      } else if (curButton == brushBtn) {
        curTool = new BrushTool(toolArgs, BrushToolType.FreeBrush);
      } else if (curButton == ellipseBtn) {
        curTool = new EllipseTool(toolArgs);
      }
    }

    private void SetToolBarButtonsState(ToolBarButton curButton) {
      curButton.Pushed = true;
      foreach (ToolBarButton btn in toolsBar.Buttons) {
        if (btn != curButton)
          btn.Pushed = false;
      }
    }

    private void imageBox_Paint(object sender, PaintEventArgs e) {
            stack.Push(imageFile);
            Rectangle clipRect = e.ClipRectangle;
            Bitmap b = toolArgs.bitmap.Clone(clipRect, toolArgs.bitmap.PixelFormat);
            e.Graphics.DrawImageUnscaledAndClipped(b, clipRect);
            b.Dispose();
    }

    private void PaintForm_Load(object sender, EventArgs e) {
      for (int i = 0; i < 4; i++) {
        DrawMode ss = (DrawMode)i;
        shapeStyleCombo.Items.Add(ss);
      }
      shapeStyleCombo.SelectedIndex = 0;

      for (int i = 1; i < 11; i++)
        widthCombo.Items.Add(i);
      for (int i = 15; i <= 60; i += 5)
        widthCombo.Items.Add(i);
      widthCombo.SelectedIndex = 0;

      for (int i = 0; i < 4; i++) {
        DashStyle ds = (DashStyle)i;
        lineStyleCombo.Items.Add(ds.ToString());
      }
      lineStyleCombo.SelectedIndex = 0;

      imageFile = new ImageFile(new Size(500, 500), Color.White);
      ShowImage();
    }

    DrawMode IPaintSettings.DrawMode {
      get {
        return (DrawMode)shapeStyleCombo.SelectedIndex;
      }
    }

    int IPaintSettings.Width {
      get {
        return Int32.Parse(widthCombo.Text);
      }
    }

    Color IPaintSettings.PrimaryColor {
      get {
        return primColorBox.BackColor;
      }
    }

    Color IPaintSettings.SecondaryColor {
      get {
        return secColorBox.BackColor;
      }
    }

    DashStyle IPaintSettings.LineStyle {
      get {
        return (DashStyle)lineStyleCombo.SelectedIndex;
      }
    }

    private void ColorBox_Click(object sender, EventArgs e) {
      PictureBox picBox = (PictureBox)sender;
      ColorDialog colorDlg = new ColorDialog();
      colorDlg.FullOpen = true;

      colorDlg.Color = picBox.BackColor;
      if (colorDlg.ShowDialog() == DialogResult.OK) {
        picBox.BackColor = colorDlg.Color;
      }
    }

    private void brushImageBox_Click(object sender, EventArgs e) {
      MessageBox.Show(imgContainer.DisplayRectangle.ToString());
      OpenFileDialog openDlg = new OpenFileDialog();
      openDlg.Filter = "Image Files .BMP .JPG .GIF .Png|*.BMP;*.JPG;*.GIF;*.PNG";
    }

    private void fileNewMnu_Click(object sender, EventArgs e) {
      NewDialog newDlg = new NewDialog();
      if (newDlg.ShowDialog() == DialogResult.OK) {
        imageFile = new ImageFile(newDlg.ImageSize, newDlg.imageBackColor);
        ShowImage();
      }
    }

    private void fileOpenMnu_Click(object sender, EventArgs e) {
      OpenFileDialog openDlg = new OpenFileDialog();
      openDlg.Filter = "Image Files .BMP .JPG .GIF .Png|*.BMP;*.JPG;*.GIF;*.PNG";
      if (openDlg.ShowDialog() == DialogResult.OK) {
        if (imageFile.Open(openDlg.FileName)) {
          ShowImage();
        } else {
          MessageBox.Show("Error");
        }
      }
    }

    private void fileSaveMnu_Click(object sender, EventArgs e) {
      if (imageFile.FileName != null) {
        if (!imageFile.Save(imageFile.FileName))
          MessageBox.Show("Error");
        else
          ShowImage();
      } else {
        fileSaveAsMnu_Click(sender, e);
      }
    }

    private void fileSaveAsMnu_Click(object sender, EventArgs e) {
      SaveFileDialog saveDlg = new SaveFileDialog();
      saveDlg.Filter = "Bitmap (*.BMP)|*.BMP";
      if (saveDlg.ShowDialog() == DialogResult.OK) {
        if (!imageFile.Save(saveDlg.FileName))
          MessageBox.Show("Error");
        else
          ShowImage();
      }
    }

    private void fileExitMnu_Click(object sender, EventArgs e) {
        DialogResult dr = MessageBox.Show("Wyłączyć aplikację?", "Wyjście", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        if (dr == DialogResult.Yes)
        {
            Application.Exit();
        }
            
    }

    private void ShowImage() {
      if (imageFile.FileName != null) {
          string t = imageFile.FileName;
          Text = String.Format("Paint - [{0}]", t == null ? "Untitled" : new FileInfo(t).Name);
      }
      
      imageBox.ClientSize = imageFile.Bitmap.Size;
      imageBox.Invalidate();
      toolArgs = new ToolArgs(imageFile.Bitmap, imageBox, pointPanel1, pointPanel2, settings);

      if (curTool != null)
        curTool.UnloadTool();
      SetToolBarButtonsState(arrowBtn);
    }

    private void pluginAddMnu_Click(object sender, EventArgs e)
    {
        OpenFileDialog openDlg = new OpenFileDialog();
        if (openDlg.ShowDialog() == DialogResult.OK)
        {
            ICollection<IPlugin> plugs = PluginLoader.LoadPlugin(openDlg.FileName);
            //pluginShowMnu.MenuItems.Clear();
            foreach (var item in plugs) {
                    _Plugins.Add(item.Name, item);
                    MenuItem mnItem = new MenuItem(item.Name);
                    mnItem.Name = item.Name;
                    pluginShowMnu.MenuItems.Add(mnItem);
                    mnItem.Click += mI_Click;
                }
            }
        }

    private void mI_Click(object sender, EventArgs e)
    {
        MenuItem mI = sender as MenuItem;

        if (mI != null)
        {
             string key = mI.Name.ToString();
             if (_Plugins.ContainsKey(key))
             {
                IPlugin plugin = _Plugins[key];
                plugin.Do(imageFile.Bitmap);
                ShowImage();
              }
         }
    }

    private void editUndoMnu_Click(object sender, EventArgs e)
    {
            stack.Pop();
            imageFile = stack.Peek();
            ShowImage();
    }

    private void editRedoMnu_Click(object sender, EventArgs e)
    {
            if (!imageFile.Open("temp/next.png"))
                MessageBox.Show("Error");
            else
                ShowImage();         
     }
   }
}