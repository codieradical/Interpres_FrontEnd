namespace Interpres
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findAndReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importJSONMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCSVMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.runScriptMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.textEditorBox = new System.Windows.Forms.RichTextBox();
            this.lineNumbersBox = new System.Windows.Forms.RichTextBox();
            this.textStatusStrip = new System.Windows.Forms.StatusStrip();
            this.paragraphCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.wordCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.characterCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.linesCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dividerStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.filePathLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.variableListBox = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.scrollbackTextBox = new System.Windows.Forms.RichTextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.commandInputBox = new System.Windows.Forms.TextBox();
            this.commandExecuteButton = new System.Windows.Forms.Button();
            this.workspaceTabs = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.textStatusStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.dataMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutButton,
            this.runScriptMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenu,
            this.openToolStripMenu,
            this.toolStripSeparator1,
            this.saveToolStripMenu,
            this.saveAsToolStripMenu,
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.closeToolStripMenu,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.ToolTipText = "Opens the File sub menu.";
            // 
            // newToolStripMenu
            // 
            this.newToolStripMenu.Name = "newToolStripMenu";
            this.newToolStripMenu.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenu.Text = "New";
            this.newToolStripMenu.ToolTipText = "Creates a new file in the text editor.";
            this.newToolStripMenu.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openToolStripMenu
            // 
            this.openToolStripMenu.Name = "openToolStripMenu";
            this.openToolStripMenu.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenu.Text = "Open";
            this.openToolStripMenu.ToolTipText = "Opens an existing file into the text editor.";
            this.openToolStripMenu.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // saveToolStripMenu
            // 
            this.saveToolStripMenu.Enabled = false;
            this.saveToolStripMenu.Name = "saveToolStripMenu";
            this.saveToolStripMenu.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenu.Text = "Save";
            this.saveToolStripMenu.ToolTipText = "Overwrites the file.";
            this.saveToolStripMenu.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenu
            // 
            this.saveAsToolStripMenu.Enabled = false;
            this.saveAsToolStripMenu.Name = "saveAsToolStripMenu";
            this.saveAsToolStripMenu.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenu.Text = "Save As";
            this.saveAsToolStripMenu.ToolTipText = "Saves the file to a new location.";
            this.saveAsToolStripMenu.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Enabled = false;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.ToolTipText = "Prints the file.";
            this.printToolStripMenuItem.Visible = false;
            this.printToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(111, 6);
            // 
            // closeToolStripMenu
            // 
            this.closeToolStripMenu.Enabled = false;
            this.closeToolStripMenu.Name = "closeToolStripMenu";
            this.closeToolStripMenu.Size = new System.Drawing.Size(114, 22);
            this.closeToolStripMenu.Text = "Close";
            this.closeToolStripMenu.ToolTipText = "Closes the currently open file.";
            this.closeToolStripMenu.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Closes the text editor.";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.settingsToolStripMenuItem,
            this.findAndReplaceToolStripMenuItem});
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.ToolTipText = "Moves the selected region from the text box to the clip board.";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.ToolTipText = "Copies the selected region to the clipboard.";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.ToolTipText = "Pastes the contents of the clipboard.";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.Image")));
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.ToolTipText = "Undo last changes.";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.AutoSize = false;
            this.redoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripMenuItem.Image")));
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.ToolTipText = "Redo last changes.";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Enabled = false;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.ToolTipText = "NYI";
            this.settingsToolStripMenuItem.Visible = false;
            // 
            // findAndReplaceToolStripMenuItem
            // 
            this.findAndReplaceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("findAndReplaceToolStripMenuItem.Image")));
            this.findAndReplaceToolStripMenuItem.Name = "findAndReplaceToolStripMenuItem";
            this.findAndReplaceToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.findAndReplaceToolStripMenuItem.Text = "Find and Replace";
            this.findAndReplaceToolStripMenuItem.ToolTipText = "Find and replace text.";
            this.findAndReplaceToolStripMenuItem.Click += new System.EventHandler(this.FindAndReplaceToolStripMenuItem_Click);
            // 
            // dataMenuItem
            // 
            this.dataMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importJSONMenuItem,
            this.importCSVMenuItem});
            this.dataMenuItem.Name = "dataMenuItem";
            this.dataMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataMenuItem.Text = "Data";
            // 
            // importJSONMenuItem
            // 
            this.importJSONMenuItem.Name = "importJSONMenuItem";
            this.importJSONMenuItem.Size = new System.Drawing.Size(141, 22);
            this.importJSONMenuItem.Text = "Import JSON";
            this.importJSONMenuItem.Click += new System.EventHandler(this.importJSONMenuItem_Click);
            // 
            // importCSVMenuItem
            // 
            this.importCSVMenuItem.Name = "importCSVMenuItem";
            this.importCSVMenuItem.Size = new System.Drawing.Size(141, 22);
            this.importCSVMenuItem.Text = "Import CSV";
            this.importCSVMenuItem.Click += new System.EventHandler(this.importCSVMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.lineNumbersToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.statusBarToolStripMenuItem.Text = "Status Bar";
            this.statusBarToolStripMenuItem.ToolTipText = "Toggles the status bar at the bottom of the text box.";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.AutoSize = false;
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.ToolTipText = "Opens the font dialog.";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // lineNumbersToolStripMenuItem
            // 
            this.lineNumbersToolStripMenuItem.Checked = true;
            this.lineNumbersToolStripMenuItem.CheckOnClick = true;
            this.lineNumbersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lineNumbersToolStripMenuItem.Name = "lineNumbersToolStripMenuItem";
            this.lineNumbersToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.lineNumbersToolStripMenuItem.Text = "Line Numbers";
            this.lineNumbersToolStripMenuItem.ToolTipText = "Toggles line numbers on the left of the text box.";
            this.lineNumbersToolStripMenuItem.Click += new System.EventHandler(this.LineNumbersToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.ToolTipText = "Opens the help documents.";
            this.helpToolStripMenuItem.Visible = false;
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Visible = false;
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(52, 20);
            this.aboutButton.Text = "About";
            this.aboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // runScriptMenuItem
            // 
            this.runScriptMenuItem.Name = "runScriptMenuItem";
            this.runScriptMenuItem.Size = new System.Drawing.Size(73, 20);
            this.runScriptMenuItem.Text = "Run Script";
            this.runScriptMenuItem.Click += new System.EventHandler(this.runScriptMenuItem_Click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // textEditorBox
            // 
            this.textEditorBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditorBox.Enabled = false;
            this.textEditorBox.Location = new System.Drawing.Point(58, 3);
            this.textEditorBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textEditorBox.Name = "textEditorBox";
            this.textEditorBox.Size = new System.Drawing.Size(638, 294);
            this.textEditorBox.TabIndex = 1;
            this.textEditorBox.Text = "";
            this.textEditorBox.WordWrap = false;
            this.textEditorBox.VScroll += new System.EventHandler(this.TextEditorBox_VScroll);
            this.textEditorBox.TextChanged += new System.EventHandler(this.TextEditorBox_TextChanged);
            // 
            // lineNumbersBox
            // 
            this.lineNumbersBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lineNumbersBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.lineNumbersBox.Enabled = false;
            this.lineNumbersBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lineNumbersBox.Location = new System.Drawing.Point(4, 3);
            this.lineNumbersBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lineNumbersBox.Name = "lineNumbersBox";
            this.lineNumbersBox.ReadOnly = true;
            this.lineNumbersBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lineNumbersBox.Size = new System.Drawing.Size(46, 294);
            this.lineNumbersBox.TabIndex = 2;
            this.lineNumbersBox.Text = "";
            this.lineNumbersBox.Visible = false;
            // 
            // textStatusStrip
            // 
            this.textStatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.textStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paragraphCountLabel,
            this.toolStripStatusLabel2,
            this.wordCountLabel,
            this.toolStripStatusLabel1,
            this.characterCountLabel,
            this.toolStripStatusLabel4,
            this.linesCountLabel,
            this.dividerStatusLabel,
            this.filePathLabel});
            this.textStatusStrip.Location = new System.Drawing.Point(0, 451);
            this.textStatusStrip.Name = "textStatusStrip";
            this.textStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.textStatusStrip.Size = new System.Drawing.Size(840, 22);
            this.textStatusStrip.TabIndex = 3;
            this.textStatusStrip.Text = "textStatusStrip";
            // 
            // paragraphCountLabel
            // 
            this.paragraphCountLabel.Enabled = false;
            this.paragraphCountLabel.Name = "paragraphCountLabel";
            this.paragraphCountLabel.Size = new System.Drawing.Size(75, 17);
            this.paragraphCountLabel.Text = "0 Paragraphs";
            this.paragraphCountLabel.Visible = false;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Enabled = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            this.toolStripStatusLabel2.Visible = false;
            // 
            // wordCountLabel
            // 
            this.wordCountLabel.Enabled = false;
            this.wordCountLabel.Name = "wordCountLabel";
            this.wordCountLabel.Size = new System.Drawing.Size(50, 17);
            this.wordCountLabel.Text = "0 Words";
            this.wordCountLabel.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Enabled = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            this.toolStripStatusLabel1.Visible = false;
            // 
            // characterCountLabel
            // 
            this.characterCountLabel.Name = "characterCountLabel";
            this.characterCountLabel.Size = new System.Drawing.Size(72, 17);
            this.characterCountLabel.Text = "0 Characters";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel4.Text = "|";
            // 
            // linesCountLabel
            // 
            this.linesCountLabel.Name = "linesCountLabel";
            this.linesCountLabel.Size = new System.Drawing.Size(43, 17);
            this.linesCountLabel.Text = "0 Lines";
            // 
            // dividerStatusLabel
            // 
            this.dividerStatusLabel.Name = "dividerStatusLabel";
            this.dividerStatusLabel.Size = new System.Drawing.Size(10, 17);
            this.dividerStatusLabel.Text = "|";
            // 
            // filePathLabel
            // 
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.filePathLabel.Size = new System.Drawing.Size(84, 17);
            this.filePathLabel.Text = "No file loaded.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.textEditorBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lineNumbersBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(699, 300);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel2.Controls.Add(this.variableListBox);
            this.splitContainer1.Size = new System.Drawing.Size(840, 300);
            this.splitContainer1.SplitterDistance = 699;
            this.splitContainer1.TabIndex = 6;
            // 
            // variableListBox
            // 
            this.variableListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.variableListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.variableListBox.FormattingEnabled = true;
            this.variableListBox.ItemHeight = 15;
            this.variableListBox.Location = new System.Drawing.Point(0, 0);
            this.variableListBox.Name = "variableListBox";
            this.variableListBox.Size = new System.Drawing.Size(137, 300);
            this.variableListBox.TabIndex = 0;
            this.variableListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.variableListBox_KeyDown);
            this.variableListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.variableListBox_MouseDoubleClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 46);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(840, 405);
            this.splitContainer2.SplitterDistance = 300;
            this.splitContainer2.TabIndex = 7;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.scrollbackTextBox);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer4.Size = new System.Drawing.Size(840, 101);
            this.splitContainer4.SplitterDistance = 72;
            this.splitContainer4.TabIndex = 4;
            // 
            // scrollbackTextBox
            // 
            this.scrollbackTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollbackTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scrollbackTextBox.Location = new System.Drawing.Point(0, 0);
            this.scrollbackTextBox.Name = "scrollbackTextBox";
            this.scrollbackTextBox.ReadOnly = true;
            this.scrollbackTextBox.Size = new System.Drawing.Size(840, 72);
            this.scrollbackTextBox.TabIndex = 0;
            this.scrollbackTextBox.Text = "";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.commandInputBox);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.commandExecuteButton);
            this.splitContainer3.Size = new System.Drawing.Size(840, 25);
            this.splitContainer3.SplitterDistance = 790;
            this.splitContainer3.TabIndex = 3;
            // 
            // commandInputBox
            // 
            this.commandInputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandInputBox.Enabled = false;
            this.commandInputBox.Location = new System.Drawing.Point(0, 0);
            this.commandInputBox.Name = "commandInputBox";
            this.commandInputBox.Size = new System.Drawing.Size(790, 23);
            this.commandInputBox.TabIndex = 1;
            this.commandInputBox.TextChanged += new System.EventHandler(this.commandInputBox_TextChanged);
            this.commandInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // commandExecuteButton
            // 
            this.commandExecuteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandExecuteButton.Enabled = false;
            this.commandExecuteButton.Location = new System.Drawing.Point(0, 0);
            this.commandExecuteButton.Name = "commandExecuteButton";
            this.commandExecuteButton.Size = new System.Drawing.Size(46, 25);
            this.commandExecuteButton.TabIndex = 2;
            this.commandExecuteButton.Text = "Run";
            this.commandExecuteButton.UseVisualStyleBackColor = true;
            this.commandExecuteButton.Click += new System.EventHandler(this.commandExecuteButton_Click);
            // 
            // workspaceTabs
            // 
            this.workspaceTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.workspaceTabs.Location = new System.Drawing.Point(0, 24);
            this.workspaceTabs.Name = "workspaceTabs";
            this.workspaceTabs.SelectedIndex = 0;
            this.workspaceTabs.Size = new System.Drawing.Size(840, 22);
            this.workspaceTabs.TabIndex = 8;
            this.workspaceTabs.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 473);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.workspaceTabs);
            this.Controls.Add(this.textStatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Interpres";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.textStatusStrip.ResumeLayout(false);
            this.textStatusStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.RichTextBox textEditorBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineNumbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.RichTextBox lineNumbersBox;
        private System.Windows.Forms.ToolStripMenuItem findAndReplaceToolStripMenuItem;
        private System.Windows.Forms.StatusStrip textStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel wordCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel characterCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel paragraphCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel linesCountLabel;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel dividerStatusLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel filePathLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox variableListBox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox scrollbackTextBox;
        private System.Windows.Forms.TabControl workspaceTabs;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox commandInputBox;
        private System.Windows.Forms.Button commandExecuteButton;
        private System.Windows.Forms.ToolStripMenuItem runScriptMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importJSONMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importCSVMenuItem;
    }
}

