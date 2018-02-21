namespace Paint {
  partial class PaintForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintForm));
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.fileMnu = new System.Windows.Forms.MenuItem();
            this.fileNewMnu = new System.Windows.Forms.MenuItem();
            this.fileOpenMnu = new System.Windows.Forms.MenuItem();
            this.fileSaveMnu = new System.Windows.Forms.MenuItem();
            this.fileSaveAsMnu = new System.Windows.Forms.MenuItem();
            this.sep1 = new System.Windows.Forms.MenuItem();
            this.fileExitMnu = new System.Windows.Forms.MenuItem();
            this.editMnu = new System.Windows.Forms.MenuItem();
            this.editUndoMnu = new System.Windows.Forms.MenuItem();
            this.editRedoMnu = new System.Windows.Forms.MenuItem();
            this.plugins = new System.Windows.Forms.MenuItem();
            this.pluginAddMnu = new System.Windows.Forms.MenuItem();
            this.pluginShowMnu = new System.Windows.Forms.MenuItem();
            this.helpAboutMnu = new System.Windows.Forms.MenuItem();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.pointPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.pointPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.toolsBar = new System.Windows.Forms.ToolBar();
            this.arrowBtn = new System.Windows.Forms.ToolBarButton();
            this.lineBtn = new System.Windows.Forms.ToolBarButton();
            this.rectangleBtn = new System.Windows.Forms.ToolBarButton();
            this.ellipseBtn = new System.Windows.Forms.ToolBarButton();
            this.brushBtn = new System.Windows.Forms.ToolBarButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.imgContainer = new System.Windows.Forms.Panel();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lineStyleCombo = new System.Windows.Forms.ComboBox();
            this.primColorBox = new System.Windows.Forms.PictureBox();
            this.secColorBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.widthCombo = new System.Windows.Forms.ComboBox();
            this.shapeStyleCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pointPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointPanel2)).BeginInit();
            this.imgContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.primColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secColorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMnu,
            this.editMnu,
            this.plugins});
            // 
            // fileMnu
            // 
            this.fileMnu.Index = 0;
            this.fileMnu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileNewMnu,
            this.fileOpenMnu,
            this.fileSaveMnu,
            this.fileSaveAsMnu,
            this.sep1,
            this.fileExitMnu});
            this.fileMnu.Text = "Plik";
            // 
            // fileNewMnu
            // 
            this.fileNewMnu.Index = 0;
            this.fileNewMnu.Text = "Nowy";
            this.fileNewMnu.Click += new System.EventHandler(this.fileNewMnu_Click);
            // 
            // fileOpenMnu
            // 
            this.fileOpenMnu.Index = 1;
            this.fileOpenMnu.Text = "Otwórz";
            this.fileOpenMnu.Click += new System.EventHandler(this.fileOpenMnu_Click);
            // 
            // fileSaveMnu
            // 
            this.fileSaveMnu.Index = 2;
            this.fileSaveMnu.Text = "Zapisz";
            this.fileSaveMnu.Click += new System.EventHandler(this.fileSaveMnu_Click);
            // 
            // fileSaveAsMnu
            // 
            this.fileSaveAsMnu.Index = 3;
            this.fileSaveAsMnu.Text = "Zapisz jako...";
            this.fileSaveAsMnu.Click += new System.EventHandler(this.fileSaveAsMnu_Click);
            // 
            // sep1
            // 
            this.sep1.Index = 4;
            this.sep1.Text = "-";
            // 
            // fileExitMnu
            // 
            this.fileExitMnu.Index = 5;
            this.fileExitMnu.Text = "Wyjdź";
            this.fileExitMnu.Click += new System.EventHandler(this.fileExitMnu_Click);
            // 
            // editMnu
            // 
            this.editMnu.Index = 1;
            this.editMnu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.editUndoMnu,
            this.editRedoMnu});
            this.editMnu.Text = "Edycja";
            // 
            // editUndoMnu
            // 
            this.editUndoMnu.Index = 0;
            this.editUndoMnu.Text = "Cofnij";
            this.editUndoMnu.Click += new System.EventHandler(this.editUndoMnu_Click);
            // 
            // editRedoMnu
            // 
            this.editRedoMnu.Index = 1;
            this.editRedoMnu.Text = "Ponów";
            this.editRedoMnu.Click += new System.EventHandler(this.editRedoMnu_Click);
            // 
            // plugins
            // 
            this.plugins.Index = 2;
            this.plugins.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.pluginAddMnu,
            this.pluginShowMnu});
            this.plugins.Text = "Wtyczki";
            // 
            // pluginAddMnu
            // 
            this.pluginAddMnu.Index = 0;
            this.pluginAddMnu.Text = "Dodaj...";
            this.pluginAddMnu.Click += new System.EventHandler(this.pluginAddMnu_Click);
            // 
            // pluginShowMnu
            // 
            this.pluginShowMnu.Index = 1;
            this.pluginShowMnu.Text = "Wtyczki";
            // 
            // helpAboutMnu
            // 
            this.helpAboutMnu.Index = -1;
            this.helpAboutMnu.Text = "";
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 682);
            this.statusBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statusBar.Name = "statusBar";
            this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.pointPanel1,
            this.pointPanel2});
            this.statusBar.ShowPanels = true;
            this.statusBar.Size = new System.Drawing.Size(1108, 1);
            this.statusBar.TabIndex = 1;
            // 
            // pointPanel1
            // 
            this.pointPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.pointPanel1.Name = "pointPanel1";
            this.pointPanel1.Width = 10;
            // 
            // pointPanel2
            // 
            this.pointPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.pointPanel2.Name = "pointPanel2";
            this.pointPanel2.Width = 10;
            // 
            // toolsBar
            // 
            this.toolsBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.arrowBtn,
            this.lineBtn,
            this.rectangleBtn,
            this.ellipseBtn,
            this.brushBtn});
            this.toolsBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolsBar.DropDownArrows = true;
            this.toolsBar.ImageList = this.imageList;
            this.toolsBar.Location = new System.Drawing.Point(0, 94);
            this.toolsBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolsBar.MinimumSize = new System.Drawing.Size(30, 0);
            this.toolsBar.Name = "toolsBar";
            this.toolsBar.ShowToolTips = true;
            this.toolsBar.Size = new System.Drawing.Size(30, 588);
            this.toolsBar.TabIndex = 2;
            this.toolsBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolsBar_ButtonClick);
            // 
            // arrowBtn
            // 
            this.arrowBtn.ImageIndex = 4;
            this.arrowBtn.Name = "arrowBtn";
            this.arrowBtn.Pushed = true;
            // 
            // lineBtn
            // 
            this.lineBtn.ImageIndex = 0;
            this.lineBtn.Name = "lineBtn";
            // 
            // rectangleBtn
            // 
            this.rectangleBtn.ImageIndex = 1;
            this.rectangleBtn.Name = "rectangleBtn";
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.ImageIndex = 3;
            this.ellipseBtn.Name = "ellipseBtn";
            // 
            // brushBtn
            // 
            this.brushBtn.ImageIndex = 2;
            this.brushBtn.Name = "brushBtn";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.White;
            this.imageList.Images.SetKeyName(0, "");
            this.imageList.Images.SetKeyName(1, "rectangle.bmp");
            this.imageList.Images.SetKeyName(2, "");
            this.imageList.Images.SetKeyName(3, "ellipse.bmp");
            this.imageList.Images.SetKeyName(4, "pointer.bmp");
            // 
            // imgContainer
            // 
            this.imgContainer.AutoScroll = true;
            this.imgContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgContainer.Controls.Add(this.imageBox);
            this.imgContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgContainer.Location = new System.Drawing.Point(30, 94);
            this.imgContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgContainer.Name = "imgContainer";
            this.imgContainer.Size = new System.Drawing.Size(1078, 588);
            this.imgContainer.TabIndex = 3;
            // 
            // imageBox
            // 
            this.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox.Location = new System.Drawing.Point(18, 18);
            this.imageBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(359, 422);
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            this.imageBox.Paint += new System.Windows.Forms.PaintEventHandler(this.imageBox_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lineStyleCombo);
            this.panel1.Controls.Add(this.primColorBox);
            this.panel1.Controls.Add(this.secColorBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.widthCombo);
            this.panel1.Controls.Add(this.shapeStyleCombo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 94);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Styl linii:";
            // 
            // lineStyleCombo
            // 
            this.lineStyleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lineStyleCombo.FormattingEnabled = true;
            this.lineStyleCombo.Location = new System.Drawing.Point(79, 50);
            this.lineStyleCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lineStyleCombo.Name = "lineStyleCombo";
            this.lineStyleCombo.Size = new System.Drawing.Size(180, 28);
            this.lineStyleCombo.TabIndex = 11;
            // 
            // primColorBox
            // 
            this.primColorBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.primColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.primColorBox.Location = new System.Drawing.Point(317, 48);
            this.primColorBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.primColorBox.Name = "primColorBox";
            this.primColorBox.Size = new System.Drawing.Size(36, 36);
            this.primColorBox.TabIndex = 9;
            this.primColorBox.TabStop = false;
            this.primColorBox.Click += new System.EventHandler(this.ColorBox_Click);
            // 
            // secColorBox
            // 
            this.secColorBox.BackColor = System.Drawing.Color.White;
            this.secColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secColorBox.Location = new System.Drawing.Point(296, 41);
            this.secColorBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.secColorBox.Name = "secColorBox";
            this.secColorBox.Size = new System.Drawing.Size(36, 36);
            this.secColorBox.TabIndex = 8;
            this.secColorBox.TabStop = false;
            this.secColorBox.Click += new System.EventHandler(this.ColorBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grubość:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wypełnienie:";
            // 
            // widthCombo
            // 
            this.widthCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.widthCombo.FormattingEnabled = true;
            this.widthCombo.Location = new System.Drawing.Point(374, 12);
            this.widthCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.widthCombo.Name = "widthCombo";
            this.widthCombo.Size = new System.Drawing.Size(91, 28);
            this.widthCombo.TabIndex = 2;
            // 
            // shapeStyleCombo
            // 
            this.shapeStyleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shapeStyleCombo.FormattingEnabled = true;
            this.shapeStyleCombo.Location = new System.Drawing.Point(111, 12);
            this.shapeStyleCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shapeStyleCombo.Name = "shapeStyleCombo";
            this.shapeStyleCombo.Size = new System.Drawing.Size(148, 28);
            this.shapeStyleCombo.TabIndex = 1;
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 683);
            this.Controls.Add(this.imgContainer);
            this.Controls.Add(this.toolsBar);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Menu = this.mainMenu;
            this.Name = "PaintForm";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.PaintForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pointPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointPanel2)).EndInit();
            this.imgContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.primColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secColorBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MainMenu mainMenu;
    private System.Windows.Forms.MenuItem fileMnu;
    private System.Windows.Forms.MenuItem editMnu;
    private System.Windows.Forms.MenuItem plugins;
    private System.Windows.Forms.StatusBar statusBar;
    private System.Windows.Forms.ToolBar toolsBar;
    private System.Windows.Forms.Panel imgContainer;
    private System.Windows.Forms.PictureBox imageBox;
    private System.Windows.Forms.StatusBarPanel pointPanel1;
    private System.Windows.Forms.StatusBarPanel pointPanel2;
    private System.Windows.Forms.MenuItem helpAboutMnu;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.ComboBox widthCombo;
    private System.Windows.Forms.ComboBox shapeStyleCombo;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.PictureBox primColorBox;
    private System.Windows.Forms.PictureBox secColorBox;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox lineStyleCombo;
    private System.Windows.Forms.ToolBarButton arrowBtn;
    private System.Windows.Forms.ToolBarButton lineBtn;
    private System.Windows.Forms.ToolBarButton rectangleBtn;
    private System.Windows.Forms.ToolBarButton ellipseBtn;
    private System.Windows.Forms.ToolBarButton brushBtn;
    private System.Windows.Forms.MenuItem fileNewMnu;
    private System.Windows.Forms.MenuItem fileOpenMnu;
    private System.Windows.Forms.MenuItem fileSaveMnu;
    private System.Windows.Forms.MenuItem fileSaveAsMnu;
    private System.Windows.Forms.MenuItem sep1;
    private System.Windows.Forms.MenuItem fileExitMnu;
    private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.MenuItem editUndoMnu;
        private System.Windows.Forms.MenuItem editRedoMnu;
        private System.Windows.Forms.MenuItem pluginAddMnu;
        private System.Windows.Forms.MenuItem pluginShowMnu;
    }
}

